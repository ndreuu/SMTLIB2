module Tests.Tests
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<TestFixture>]
type ParserIsIdempotentSamples () =
    inherit FileIdempotentContentsTester("samples")

    [<Test>]
    member x.LtLt () =
        x.RunTest "ltlt.smt2" ".orig"


[<TestFixture>]
type ParserReadAsIsSamples () =
    inherit FileAsIsContentsTester("samples")

    [<Test>]
    member x.Even () =
        x.RunTest "even.smt2" ".asis"

    [<Test>]
    member x.EvenUnsat () =
        x.RunTest "even.unsat.smt2" ".asis"

    [<Test>]
    member x.Prop01 () =
        x.RunTest "prop_01.smt2" ".asis"

    [<Test>]
    member x.Ltlt () =
        x.RunTest "ltlt.smt2" ".asis"

    [<Test>]
    member x.Drop () =
        x.RunTest "drop.smt2" ".asis"

    [<Test>]
    member x.CHC000 () =
        x.RunTest "chc-ADT-NonLin_000.smt2" ".asis"

    [<Test>]
    member x.CHCLia060 () =
        x.RunTest "chc-LIA_060.smt2" ".asis"
