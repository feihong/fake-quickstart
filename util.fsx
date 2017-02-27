#r "packages/FAKE/tools/FakeLib.dll"
// open Fake
open Fake.FileSystemHelper

open System.IO

/// Custom operator for combining paths
let (+/) path1 path2 = Path.Combine(path1, path2)

let relativePath dir path = 
    let dirInfo = directoryInfo dir
    let path' = fileInfo path
    path'.FullName.Substring(dirInfo.FullName.Length + 1)