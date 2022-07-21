namespace Tests
open System.Text.RegularExpressions
open NUnit.Framework
open System.IO

[<SetUpFixture>]
type SetupTrace () =
    let out = System.Console.Out

    static member OverwriteGoldValues = false

    [<OneTimeSetUp>]
    member x.StartTest () =
        System.Console.SetOut(TestContext.Progress)

    [<OneTimeTearDown>]
    member x.StopTest () =
        System.Console.SetOut(out)

module File =
    let tryFindDistinctFragments fn1 fn2 =
        let chunk_size = 50
        let readLines fn =
            Regex.Replace(File.ReadAllText(fn), "\s+", " ").Trim().Replace(" )", ")").Replace("( ", "(")
            |> Seq.chunkBySize chunk_size
            |> Seq.map System.String
            |> fun s -> Seq.append s ["EOF"]
        let f1 = readLines fn1
        let f2 = readLines fn2
        Seq.zip f1 f2 |> Seq.tryFind (fun (line1, line2) -> line1 <> line2)
