[<AutoOpen>]
module SMTLIB2.Prelude
open System.IO
open System.Numerics

type path = string

let private walk_through (srcDir : path) targetDir gotoFile gotoDirectory transform =
    let rec walk sourceFolder destFolder =
        for file in Directory.GetFiles(sourceFolder) do
            let name = Path.GetFileName(file)
            let dest = gotoFile destFolder name
            transform file dest
        for folder in Directory.GetDirectories(sourceFolder) do
            let name = Path.GetFileName(folder)
            let dest = gotoDirectory destFolder name
            walk folder dest
    walk srcDir targetDir

let walk_through_copy srcDir targetDir transform =
    let gotoFile folder name = Path.Combine(folder, name)
    let gotoDirectory folder name =
            let dest = Path.Combine(folder, name)
            Directory.CreateDirectory(dest) |> ignore
            dest
    walk_through srcDir targetDir gotoFile gotoDirectory transform

type symbol = string
type ident = string

module Symbols =
    let addPrefix (pref : string) s = pref + s

type sort =
    | BoolSort
    | IntSort
    | FreeSort of ident
    | ADTSort of ident
    | ArraySort of sort * sort
    override x.ToString() =
        match x with
        | BoolSort -> "Bool"
        | IntSort -> "Int"
        | FreeSort s
        | ADTSort s -> s
        | ArraySort(s1, s2) -> $"(Array {s1} {s2})"

module Sort =
    let sortToFlatString s =
        let rec sortToFlatString = function
            | BoolSort -> ["Bool"]
            | IntSort -> ["Int"]
            | FreeSort s
            | ADTSort s -> [s]
            | ArraySort(s1, s2) -> "Array" :: sortToFlatString s1 @ sortToFlatString s2
        sortToFlatString s |> join ""

    let compare (s1 : sort) (s2 : sort) =
        let s1 = hash s1
        let s2 = hash s2
        s1.CompareTo(s2)

type sorted_var = symbol * sort

module SortedVar =
    let freshFromSort s : sorted_var = IdentGenerator.gensym (), s
    let freshFromVar ((v, s) : sorted_var) : sorted_var = IdentGenerator.gensymp v, s

    let compare ((v1, s1) : sorted_var) ((v2, s2) : sorted_var) =
        //let cmpSorts = Sort.compare s1 s2
        // prioritize sort name in comparison
        //if cmpSorts = 0 then v1.CompareTo(v2) else cmpSorts
        v1.CompareTo(v2)

module SortedVars =
    let mapFold = List.mapFold

    let sort = List.sortWith SortedVar.compare

    let withFreshVariables = List.mapFold (fun freshVarsMap vs -> let vs' = SortedVar.freshFromVar vs in vs', Map.add vs vs' freshVarsMap)

    let generateNVariablesOfSort n sort = List.init n (fun _ -> SortedVar.freshFromSort sort)

    let toString : sorted_var list -> string = List.map (fun (v, s) -> $"({v} {s})") >> join " "

type operation =
    | ElementaryOperation of ident * sort list * sort
    | UserDefinedOperation of ident * sort list * sort

    override x.ToString() =
        match x with
        | ElementaryOperation(s, _, _)
        | UserDefinedOperation(s, _, _) -> toString s

module Operation =
    let argumentTypes = function
        | ElementaryOperation(_, s, _)
        | UserDefinedOperation(_, s, _) -> s
    let returnType = function
        | ElementaryOperation(_, _, s)
        | UserDefinedOperation(_, _, s) -> s
    let opName = function
        | ElementaryOperation(n, _, _)
        | UserDefinedOperation(n, _, _) -> n
    let toTuple = function
        | ElementaryOperation(n, a, s)
        | UserDefinedOperation(n, a, s) -> n, a, s

    let isUserOperation = function UserDefinedOperation _ -> true | _ -> false

    let changeName name = function
        | ElementaryOperation(_, s1, s2) -> ElementaryOperation(name, s1, s2)
        | UserDefinedOperation(_, s1, s2) -> UserDefinedOperation(name, s1, s2)

    let flipOperationKind = function
        | UserDefinedOperation(n, s1, s2) -> ElementaryOperation(n, s1, s2)
        | ElementaryOperation(n, s1, s2) -> UserDefinedOperation(n, s1, s2)

    let makeUserOperationFromVars name vars retSort = UserDefinedOperation(name, List.map snd vars, retSort)
    let makeUserOperationFromSorts name argSorts retSort = UserDefinedOperation(name, argSorts, retSort)
    let makeUserRelationFromVars name vars = makeUserOperationFromVars name vars BoolSort
    let makeUserRelationFromSorts name sorts = makeUserOperationFromSorts name sorts BoolSort
    let makeElementaryOperationFromVars name vars retSort = ElementaryOperation(name, List.map snd vars, retSort)
    let makeElementaryOperationFromSorts name argSorts retSort = ElementaryOperation(name, argSorts, retSort)
    let makeElementaryRelationFromVars name vars = makeElementaryOperationFromVars name vars BoolSort
    let makeElementaryRelationFromSorts name argSorts = makeElementaryOperationFromSorts name argSorts BoolSort

    let makeADTOperations adtSort cName tName selectorSorts =
        let cOp = makeElementaryOperationFromVars cName selectorSorts adtSort
        let tOp = makeElementaryOperationFromSorts tName [adtSort] BoolSort
        let selOps = List.map (fun (selName, selSort) -> makeElementaryOperationFromSorts selName [adtSort] selSort) selectorSorts
        cOp, tOp, selOps

type quantifier =
    | ForallQuantifier of sorted_var list
    | ExistsQuantifier of sorted_var list
    | StableForallQuantifier of sorted_var list // for metavariables, such as in let bindings

module Quantifier =
    let toString q =
        let name, vars =
            match q with
            | ForallQuantifier vars -> "forall", vars
            | ExistsQuantifier vars -> "exists", vars
            | StableForallQuantifier vars -> "forall", vars
        fun body -> $"""(%s{name} (%s{vars |> List.map (fun (v, e) -> $"({v} {e})") |> join " "})%s{"\n    "}%s{body}%s{"\n  "})"""

type quantifiers = quantifier list

module Quantifiers =
    let empty : quantifiers = []

    let add q (qs : quantifiers) : quantifiers =
        match q with
        | ForallQuantifier []
        | ExistsQuantifier []
        | StableForallQuantifier [] -> qs
        | _ ->
        match qs with
        | [] -> [q]
        | q'::qs ->
        match q, q' with
        | ForallQuantifier vars, ForallQuantifier vars' -> ForallQuantifier (vars @ vars')::qs
        | ExistsQuantifier vars, ExistsQuantifier vars' -> ExistsQuantifier (vars @ vars')::qs
        | StableForallQuantifier vars, StableForallQuantifier vars' -> StableForallQuantifier (vars @ vars')::qs
        | _ -> q::q'::qs

    let private squashStableIntoForall (qs : quantifiers) =
        List.foldBack add (List.map (function StableForallQuantifier vars -> ForallQuantifier vars | q -> q) qs) empty

    let toString (qs : quantifiers) o = List.foldBack Quantifier.toString (squashStableIntoForall qs) (o.ToString())

type smtExpr =
    | Number of BigInteger
    | BoolConst of bool
    | Ident of ident * sort
    | Apply of operation * smtExpr list
    | Let of (sorted_var * smtExpr) list * smtExpr
    | Match of smtExpr * (smtExpr * smtExpr) list
    | Ite of smtExpr * smtExpr * smtExpr
    | And of smtExpr list
    | Or of smtExpr list
    | Not of smtExpr
    | Hence of smtExpr * smtExpr
    | QuantifierApplication of quantifiers * smtExpr
    override x.ToString() =
        let term_list_to_string = List.map toString >> join " "
        let atom_list_to_string = List.map toString >> join " "
        let bindings_to_string = List.map (fun ((v, _), e) -> $"({v} {e})") >> join " "
        match x with
        | Apply(f, []) -> f.ToString()
        | Apply(f, xs) -> $"({f} {term_list_to_string xs})"
        | Number n -> toString n
        | BoolConst true -> "true"
        | BoolConst false -> "false"
        | Ident(x, _) -> x.ToString()
        | Let(bindings, body) ->
            $"(let (%s{bindings_to_string bindings}) {body})"
        | Match(t, cases) ->
            sprintf "(match %O (%s))" t (cases |> List.map (fun (pat, t) -> $"({pat} {t})") |> join " ")
        | Ite(i, t, e) -> $"(ite {i} {t} {e})"
        | And xs -> $"(and {atom_list_to_string xs})"
        | Or xs -> $"(or {atom_list_to_string xs})"
        | Not x -> $"(not {x})"
        | Hence(i, t) ->
            $"""(=>%s{"\n"}      %s{i.ToString()}%s{"\n"}      %s{t.ToString()}%s{"\n"}    )"""
        | QuantifierApplication(qs, e) -> Quantifiers.toString qs e

module Expr =
    let makeConst name sort = Apply (UserDefinedOperation (name, [], sort), [])
    let makeUnaryOp op x = Apply(op, [x])
    let makeBinaryOp op x y = Apply(op, [x; y])
    let makeBinary name arg1Sort arg2Sort resSort =
      makeBinaryOp (Operation.makeElementaryOperationFromSorts name [arg1Sort; arg2Sort] resSort)

let QuantifierApplication(qs, body) =
    match qs with
    | [] -> body
    | _ -> QuantifierApplication(qs, body)

type function_def = symbol * sorted_var list * sort * smtExpr

type definition =
    | DefineFun of function_def
    | DefineFunRec of function_def
    | DefineFunsRec of function_def list
    override x.ToString() =
        match x with
        | DefineFunRec(name, vars, returnType, body) ->
            $"(define-fun-rec {name} (%s{SortedVars.toString vars}) {returnType} {body})"
        | DefineFun(name, vars, returnType, body) ->
            $"(define-fun {name} (%s{SortedVars.toString vars}) {returnType} {body})"
        | DefineFunsRec fs ->
            let signs, bodies = List.map (fun (n, vs, s, b) -> (n, vs, s), b) fs |> List.unzip
            let signs = signs |> List.map (fun (name, vars, sort) -> $"({name} ({SortedVars.toString vars}) {sort})") |> join " "
            let bodies = bodies |> List.map toString |> join " "
            $"(define-funs-rec (%s{signs}) (%s{bodies}))"

type datatype_def = symbol * (operation * operation * operation list) list // adt name, [constr, tester, [selector]]

module Datatype =
    let noConstructorArity = 0

    let maxConstructorArity ((_, cs) : datatype_def) = cs |> List.map (thd3 >> List.length) |> List.max


type asserted =
    | Asserted of smtExpr
    override x.ToString() = match x with Asserted x -> $"(asserted {x})"

type hyperProof =
    | HyperProof of asserted * hyperProof list * smtExpr
    override x.ToString() =
        match x with HyperProof(assert', hyerProofs, smt) ->
        let hyperProof = List.fold (fun acc x -> acc + "\n" + x.ToString()) "" hyerProofs
        $"\n((_ hyper-res)\n{assert'.ToString()}{hyperProof}{smt.ToString()})\n"

type command =
    | CheckSat
    | GetModel
    | Exit
    | GetInfo of string
    | GetProof
    | SetInfo of string * string option
    | SetLogic of string
    | SetOption of string
    | DeclareDatatype of datatype_def
    | DeclareDatatypes of datatype_def list
    | DeclareFun of symbol * bool * sort list * sort // bool = should be quoted
    | DeclareSort of symbol
    | DeclareConst of symbol * sort
    | Proof of hyperProof * asserted * smtExpr
    
    override x.ToString() =
        let constrEntryToString (constrOp, _, selOps) =
            let op = Operation.opName constrOp
            match selOps with
            | [] -> $"({op})"
            | _ -> $"""({op} {Operation.argumentTypes constrOp |> List.zip selOps |> List.map (fun (selOp, argSort) -> $"({Operation.opName selOp} {argSort})") |> join " "})"""
        let constrsOfOneADTToString = List.map constrEntryToString >> join " " >> sprintf "(%s)"
        let dtsToString dts =
            let sortNames, ops = List.unzip dts
            let sorts = sortNames |> List.map (sprintf "(%O 0)") |> join " "
            let constrs = ops |> List.map constrsOfOneADTToString |> join " "
            $"""(declare-datatypes ({sorts}) ({constrs}))"""
        match x with
        | Exit -> "(exit)"
        | CheckSat -> "(check-sat)"
        | GetModel -> "(get-model)"
        | GetProof -> "(get-proof)"
        | GetInfo s -> $"(get-info %s{s})"
        | SetInfo(k, vopt) -> $"""(set-info %s{k} %s{Option.defaultValue "" vopt})"""
        | SetLogic l -> $"(set-logic %s{l})"
        | SetOption l -> $"(set-option %s{l})"
        | DeclareConst(name, sort) -> $"(declare-const {name} {sort})"
        | DeclareSort sort -> $"(declare-sort {sort} 0)"
        | DeclareFun(name, shouldBeQuoted, args, ret) ->
            let fullName = if shouldBeQuoted then $"|{name}|" else name
            $"""(declare-fun {fullName} ({args |> List.map toString |> join " "}) {ret})"""
        | DeclareDatatype dt -> dtsToString [dt]
        | DeclareDatatypes dts -> dtsToString dts
        | Proof(hp, a, smt) -> $"(proof\nmp {hp.ToString()}\n{a.ToString()} {smt.ToString()})"

let DeclareFun(name, args, ret) = DeclareFun(name, false, args, ret)
let (|DeclareFun|_|) = function
    | command.DeclareFun(name, _, args, ret) -> Some(name, args, ret)
    | _ -> None

let private oldDtToNewDt oldDt = // TODO: delete this with refactoring
    let adtSort, fs = oldDt
    let adtSortName =
        match adtSort with
        | ADTSort adtSortName -> adtSortName
        | _ -> __notImplemented__()
    let toADTOps (cName, selectorSorts) =
        let tName = "is-" + cName
        Operation.makeADTOperations adtSort cName tName selectorSorts
    adtSortName, List.map toADTOps fs

let DeclareDatatype oldDt =
    DeclareDatatype(oldDtToNewDt oldDt)

let DeclareDatatypes oldDts =
    DeclareDatatypes(List.map oldDtToNewDt oldDts)

module Command =
    let declareOp = function
        | ElementaryOperation(name, argSorts, retSort)
        | UserDefinedOperation(name, argSorts, retSort) -> DeclareFun(name, argSorts, retSort)

    let maxConstructorArity = function
        | DeclareDatatype dt -> Datatype.maxConstructorArity dt
        | DeclareDatatypes dts -> dts |> List.map Datatype.maxConstructorArity |> List.max
        | _ -> Datatype.noConstructorArity


type originalCommand =
    | Definition of definition
    | Command of command
    | Assert of smtExpr
    override x.ToString() =
        match x with
        | Definition df -> df.ToString()
        | Command cmnd -> cmnd.ToString()
        | Assert f ->
            match f with
            | Apply _ as e ->
                $"""(assert%s{"\n"}%s{"  "}{(Hence (And [ BoolConst true ], e)).ToString()}%s{"\n"})"""    
            | QuantifierApplication ([ ForallQuantifier _ as forallQ], (Apply _ as e)) ->
                $"""(assert%s{"\n"}%s{"  "}{(QuantifierApplication ([ forallQ ], Hence (And [ BoolConst true ], e))).ToString()}%s{"\n"})"""    
            | _ ->  $"""(assert%s{"\n"}%s{"  "}{f.ToString()}%s{"\n"})"""    
            

let simplBinary zero one deconstr constr =
    let rec iter k = function
        | [] -> k []
        | x :: xs ->
            if x = one then x
            elif x = zero then iter k xs
            else
                match deconstr x with
                | Some ys -> iter (fun ys -> iter (fun xs -> k (ys @ xs)) xs) ys
                | None -> iter (fun res -> k (x :: res)) xs
    iter (function [] -> zero | [t] -> t | ts -> ts |> constr)
