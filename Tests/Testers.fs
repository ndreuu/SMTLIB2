[<AutoOpen>]
module Tests.Testers
open System
open NUnit.Framework
open System.IO
open SMTLIB2

type IComparator =
    abstract member Compare : path -> path -> unit

[<AbstractClass>]
type FileComparator () =
    abstract member CompareContents : path -> path -> unit

    interface IComparator with
        member x.Compare truthFile candidateFile =
            if not <| File.Exists(candidateFile) then Assert.Fail($"{candidateFile} does not exist so cannot compare it with {truthFile}")
            elif SetupTrace.OverwriteGoldValues then File.Move(candidateFile, truthFile, true)
            elif not <| File.Exists(truthFile) then
                let content = File.ReadAllText(candidateFile)
                Console.WriteLine("\nThe output is:")
                Console.Write(content)
                Assert.Fail($"{truthFile} does not exist so cannot compare it with {candidateFile}")
            else x.CompareContents truthFile candidateFile

type FileContentsComparator () =
    inherit FileComparator ()

    override x.CompareContents truthFile candidateFile =
        match File.tryFindDistinctFragments truthFile candidateFile with
        | Some (l1, l2) -> Assert.Fail($"{candidateFile} content is distinct from {truthFile}:\nTruth: {l1}\n  New: {l2}")
        | None -> ()

type DirectoryComparator (fc : FileComparator) =
    let c = fc :> IComparator

    interface IComparator with
        member x.Compare truthPath candidatePath =
            walk_through_copy truthPath candidatePath c.Compare

type DirectoryContentsComparator () =
    inherit DirectoryComparator(FileContentsComparator ())

//[<AbstractClass>]
//type Tester<'filenameEntry, 'config> (c : IComparator) =
//    abstract member FullPath : 'filenameEntry -> 'filenameEntry
//    abstract member OutputPath : 'filenameEntry -> path
//    abstract member GoldPath : 'config -> path
//    abstract member RealGeneratedPath : 'config -> path
//    abstract member RunConfiguration : 'config -> unit
//
//    member x.Compare = c.Compare
//
//    member x.Test (fe : 'filenameEntry) config =
//        let path = x.FullPath fe
//        let outPath = x.OutputPath path
//        if Directory.Exists(outPath) then Directory.Delete(outPath, true)
//        let runCommand = config path outPath
//        x.RunConfiguration(runCommand)
//        let targetPath = x.RealGeneratedPath runCommand
//        let gold = x.GoldPath runCommand
//        c.Compare gold targetPath

type FileIdempotentTester (fc : FileComparator, fileFolder) =
//    inherit Tester<path * string, path * path>(fc)

    let testsFolder = Path.Join(__SOURCE_DIRECTORY__, fileFolder)

    member x.RunTest origName postfix =
        let origPath = Path.Join(testsFolder, origName)
        let outpath = origPath + postfix + ".generated"
        if Directory.Exists(outpath) then Directory.Delete(outpath, true)
        Directory.CreateDirectory(outpath) |> ignore
        let p = Parser.Parser(true)
        let cOrig = p.ParseFile(origPath)
        IdentGenerator.reset()
        let onePath = Path.Join(outpath, "1.smt2")
        File.AppendAllLines(onePath, Seq.map toString cOrig)
        p.ResetEverything()
        let one = p.ParseFile(onePath)
        let secPath = Path.Join(outpath, "2.smt2")
        File.AppendAllLines(secPath, Seq.map toString one)
        fc.CompareContents onePath secPath

//    override x.FullPath fe =
//        let name, postfix = fe
//        Path.Join(testsFolder, name), postfix
//    override x.OutputPath fe =
//        let path, postfix = fe
//        Path.ChangeExtension(path, postfix + ".generated")
//    override x.GoldPath  fe =
//        let path, postfix = fe
//        Path.ChangeExtension(path, postfix + ".gold.smt2")
//    override x.RealGeneratedPath path = Directory.GetFiles(path).[0]
//
//    member x.RunTest name postfix =
//        x.Test (name, postfix) (fun (path, _) out -> path, out)

type FileAsIsTester (fc : FileComparator, fileFolder) =
//    inherit Tester<path * string, path * path>(fc)

    let testsFolder = Path.Join(__SOURCE_DIRECTORY__, fileFolder)

    member x.RunTest origName postfix =
        let origPath = Path.Join(testsFolder, origName)
        let outpath = origPath + postfix + ".generated"
        if Directory.Exists(outpath) then Directory.Delete(outpath, true)
        Directory.CreateDirectory(outpath) |> ignore
        let cOrig = Parser.Parser(false).ParseFile(origPath)
        let onePath = Path.Join(outpath, "1.smt2")
        File.AppendAllLines(onePath, Seq.map toString cOrig)
        fc.CompareContents origPath onePath

type FileIdempotentContentsTester (fileFolder) =
    inherit FileIdempotentTester(FileContentsComparator(), fileFolder)

type FileAsIsContentsTester (fileFolder) =
    inherit FileAsIsTester(FileContentsComparator(), fileFolder)