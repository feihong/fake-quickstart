#r "packages/FAKE/tools/FakeLib.dll"
// open Fake
open Fake.FileSystemHelper

open System.IO


let relativePath dir path =
    let dirInfo = directoryInfo dir
    let path' = fileInfo path
    path'.FullName.Substring(dirInfo.FullName.Length + 1)
