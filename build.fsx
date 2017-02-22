// include Fake lib
#r @"packages/FAKE/tools/FakeLib.dll"
open Fake

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
)

Target "Hello" (fun _ ->
    trace "Hello World from FAKE"
)

// Dependencies
"Clean"
    ==> "Build"

// start build
RunTargetOrDefault "Build"
