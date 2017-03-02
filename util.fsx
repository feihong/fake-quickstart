#r "packages/FAKE/tools/FakeLib.dll"
open Fake.FileSystemHelper
open Fake.StringHelper


let buildDir = FullName "build"
let srcDir = FullName "src"

/// Based on FAKE's CopyFileWithSubfolder function.
let toBuildPath fileName =
  let fileName = FullName fileName
  let relative = (ProduceRelativePath srcDir fileName).TrimStart('.')
  buildDir + relative
