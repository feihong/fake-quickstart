#r "packages/FAKE/tools/FakeLib.dll"
#load "./convert.fsx"
#load "./util.fsx"
open System.IO
open Fake
open Fake.StringHelper
open Fake.EnvironmentHelper
open Fake.FileSystemHelper

open Util
open Convert

// Properties
let buildDir = "./build/"

// Targets
Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "Build" (fun _ ->
    let fileSet = !! "src/**/*.md"
    for p in fileSet do
        let buildPath = toBuildPath p |> changeExt ".html"
        trace <| sprintf "%s -> %s" p buildPath
        let buildPathInfo = fileInfo buildPath
        buildPathInfo.Directory |> ensureDirExists
        let html = parseFile p
        File.WriteAllText(buildPath, html)
)

Target "Hello" (fun _ ->
    trace "Hello World from FAKE"
    trace <| sprintf "Source directory: %s" __SOURCE_DIRECTORY__
    trace <| sprintf "Source file: %s" __SOURCE_FILE__
    trace <| sprintf "Source path: %s" (__SOURCE_DIRECTORY__ </> __SOURCE_FILE__)
)

// Dependencies
"Clean"
    ==> "Build"

// start build
RunTargetOrDefault "Build"
