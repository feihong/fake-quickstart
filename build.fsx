// include Fake lib
#r "packages/FAKE/tools/FakeLib.dll"
#load "./convert.fsx"
#load "./util.fsx"
open Fake
open Fake.FileSystemHelper
open Util

// Properties
let buildDir = "./build/"

// Targets
Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "Build" (fun _ ->
    let fileSet = !! "src/**/*.md"
    for p in fileSet do
        trace p 
        trace <| "build" +/ (relativePath "src" p)
    
    // let dirInfo = directoryInfo  "src"
    // trace dirInfo.FullName
    // for fileInfo in filesInDirMatchingRecursive "*.md" dirInfo do
    //     trace <| fileInfo.FullName
)

Target "Hello" (fun _ ->
    trace "Hello World from FAKE"
    trace <| sprintf "Source directory: %s" __SOURCE_DIRECTORY__
    trace <| sprintf "Source file: %s" __SOURCE_FILE__
    trace <| sprintf "Source path: %s" (__SOURCE_DIRECTORY__ +/ __SOURCE_FILE__)
)

// Dependencies
"Clean"
    ==> "Build"

// start build
RunTargetOrDefault "Build"
