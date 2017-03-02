module Convert

#r "packages/FSharp.Formatting/lib/net40/FSharp.Formatting.Common.dll"
#r "packages/FSharp.Formatting/lib/net40/FSharp.Markdown.dll"
open System.IO
open FSharp.Markdown
open FSharp.Formatting.Common
 
let parseFile mdfile = 
    let html = File.ReadAllText(mdfile)
    Markdown.TransformHtml html