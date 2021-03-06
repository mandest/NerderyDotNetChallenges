#load @"./packages/FSharp.Formatting/FSharp.Formatting.fsx"
open FSharp.Literate
open System.IO

let template = Path.Combine(__SOURCE_DIRECTORY__, "template/template.html")
Literate.ProcessDirectory(Path.Combine(__SOURCE_DIRECTORY__, "challenges"), template)
Literate.ProcessMarkdown(Path.Combine(__SOURCE_DIRECTORY__, "web/index.md"), template)