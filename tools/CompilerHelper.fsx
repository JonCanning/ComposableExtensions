// Copyright 2014 Jay Tuley <jay+code@tuley.name>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


[<AutoOpen>]
module CompilerHelper

#I "packages/FSharp.Compiler.Service/lib/net40/"
#r "FSharp.Compiler.Service.dll"
#I "packages/FAKE/tools"
#r "FakeLib.dll"

open Microsoft.FSharp.Compiler.SimpleSourceCodeServices
open Fake.TraceHelper
open System.IO
open System.Reflection

type TargetFramework =
    | NET45
    | NET40
    | NET35
    | PORTABLE_47
    | PORTABLE_7

type FSharpVersion =
    | FS30
    | FS31

exception CompilerError of string

let defaultSystemDlls (target:TargetFramework) =
    match target with
        | NET45 | NET40 ->
            [
                "mscorlib.dll"
                "System.dll"
                "System.Core.dll"
                "System.Numerics.dll"
            ]
        | PORTABLE_47 ->
            [
                "mscorlib.dll"
                "System.dll"
                "System.Core.dll"
                "System.Numerics.dll"
                "System.Net.dll"
            ]
        | NET35 ->
            [
                "mscorlib.dll"
                "System.dll"
                "System.Core.dll"
            ]
        | PORTABLE_7 ->
            [
                "mscorlib.dll"
                "System.dll"
                "System.Core.dll"
                "System.Collections.dll"
                "System.Collections.Concurrent.dll"
                "System.Diagnostics.Debug.dll"
                "System.Globalization.dll"
                "System.IO.dll"
                "System.Linq.dll"
                "System.Linq.Expressions.dll"
                "System.Linq.Queryable.dll"
                "System.Net.Requests.dll"
                "System.Reflection.dll"
                "System.Reflection.Extensions.dll"
                "System.Resources.ResourceManager.dll"
                "System.Runtime.dll"
                "System.Runtime.Extensions.dll"
                "System.Runtime.Numerics.dll"
                "System.Text.Encoding.dll"
                "System.Threading.dll"
                "System.Threading.Tasks.dll"
                "System.Threading.Tasks.Parallel.dll"
            ]

let systemTargetInfo (target:TargetFramework) ( version:FSharpVersion) =
    (defaultSystemDlls target, target, version)

let systemDllsResolver (systemDlls:string list,target:TargetFramework,version:FSharpVersion) =
    let programFiles = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86)
    let msSDK = Path.Combine (programFiles, "Reference Assemblies","Microsoft","Framework");
    let fsharpSDK = Path.Combine (programFiles, "Reference Assemblies","Microsoft","FSharp");
    let fsharpSDK30 = Path.Combine (fsharpSDK,"3.0");

    let sysDotNetLibPath =
        Assembly.GetAssembly(typeof<System.Object>).Location
             |> Path.GetDirectoryName
             |> (fun x -> Path.Combine(x, ".."))
             |> Path.GetFullPath

    let monoFSharpSDK = Path.Combine (sysDotNetLibPath, "Reference Assemblies","Microsoft","FSharp");
    let allStdPaths =
        match target with
            | NET45 ->
                [
                  Path.Combine(msSDK,".NETFramework", "v4.5.1") //Windows
                  Path.Combine(msSDK,".NETFramework", "v4.5") //Windows
                  Path.Combine(sysDotNetLibPath,"4.5") //Mono
                ]
            | NET40 ->
                [
                  Path.Combine(msSDK,".NETFramework","v4.0") //Windows
                  Path.Combine(sysDotNetLibPath,"4.0") //Mono
                ]
            | NET35 ->
                [
                  Path.Combine(msSDK,".NETFramework","v3.5", "Profile", "Client") //Windows
                  Path.Combine(sysDotNetLibPath,"3.5") //Mono
                  Path.Combine(sysDotNetLibPath,"2.0") //Mono
                ]
            | PORTABLE_47 ->
                [
                    Path.Combine(msSDK, ".NETPortable", "v4.0", "Profile", "Profile47") //Windows
                    Path.Combine(sysDotNetLibPath,"xbuild-frameworks", ".NETPortable", "v4.0", "Profile", "Profile47") //Mono
                ]
            | PORTABLE_7 ->
                [
                    Path.Combine(msSDK, ".NETPortable", "v4.5", "Profile", "Profile7") //Windows
                    Path.Combine(sysDotNetLibPath,"xbuild-frameworks", ".NETPortable", "v4.5", "Profile", "Profile7") //Mono
                ]
        |> List.map Path.GetFullPath


    let fsharpPaths =
        match target,version with
            | PORTABLE_47,FS30 ->
                [
                    Path.Combine(fsharpSDK, ".NETPortable", "2.3.5.0") //Windows F# 3.0
                    Path.Combine(fsharpSDK30, "Runtime", ".NETPortable") //Windows F#3.0
                    Path.Combine(monoFSharpSDK, ".NETPortable", "2.3.5.0") //Mono F# 3.0
                    "./tools/packages/FSharp.Core.Open.FS30/lib/portable-net45+sl5+win8/"  //Fallback
                ]
            | PORTABLE_47,FS31 ->
                [
                    Path.Combine(fsharpSDK, ".NETPortable", "2.3.5.1") //Windows F# 3.1
                    Path.Combine(monoFSharpSDK, ".NETPortable", "2.3.5.1") //Mono F# 3.1
                    "./tools/packages/FSharp.Core.Open.FS31/lib/portable-net45+sl5+win8/"  //Fallback
                ]
            | PORTABLE_7,FS30 -> raise (CompilerError "Portable Profile 7 and F# 3.0 not supported")
            | PORTABLE_7,FS31 ->
                [
                    Path.Combine(fsharpSDK, ".NETCore", "3.3.1.0") //Windows F# 3.1
                    Path.Combine(monoFSharpSDK, ".NETCore", "3.3.1.0") //Mono F# 3.1
                    "./tools/packages/FSharp.Core.Open.FS31/lib/portable-net45+win8/"  //Fallback
                ]
            | NET35,FS30 ->
                [
                    Path.Combine(fsharpSDK, ".NETFramework","v2.0", "2.3.0.0") //Windows F# 3.0 new loc
                    Path.Combine(fsharpSDK30, "Runtime", "v2.0") //Windows F# 3.0
                    //Path.Combine(sysDotNetLibPath, "2.0") //Mono what version though?
                    "./tools/packages/FSharp.Core.Open.FS30/lib/net20/"  //Fallback
                ]
            | NET35,FS31 -> raise (CompilerError ".Net runtime v2.0 and F# 3.1 not supported")
            | NET40,FS30 ->
                [
                    Path.Combine(fsharpSDK, ".NETFramework","v4.0", "4.3.0.0") //Windows F# 3.0 new loc
                    Path.Combine(fsharpSDK30, "Runtime", "v4.0") //Windows F# 3.0
                    //Path.Combine(sysDotNetLibPath, "4.0") //Mono what version though?
                    "./tools/packages/FSharp.Core.Open.FS30/lib/net40/"  //Fallback
                ]
            | NET40,FS31 ->
                [
                    Path.Combine(fsharpSDK, ".NETFramework","v4.0", "4.3.1.0") //Windows F# 3.1
                    "./tools/packages/FSharp.Core.Open.FS31/lib/net40/" //Fallback
                ]
            | NET45,FS30 ->
                [
                    Path.Combine(fsharpSDK, ".NETFramework","v4.0", "4.3.0.0") //Windows F# 3.0 new loc
                    Path.Combine(fsharpSDK30, "Runtime", "v4.0") //Windows F# 3.0
                    //Path.Combine(sysDotNetLibPath, "4.5") //Mono what version though?
                    "./tools/packages/FSharp.Core.Open.FS30/lib/net40/" //Fallback
                ]
            | NET45,FS31 ->
                [
                    Path.Combine(fsharpSDK, ".NETFramework","v4.0", "4.3.1.0") //Windows F# 3.1
                    "./tools/packages/FSharp.Core.Open.FS31/lib/net40/" //Fallback
                ]
        |> List.map Path.GetFullPath

    let searchPaths (paths:string list) =
        paths
            |> Seq.map (fun p-> Path.GetFullPath p)
            |> Seq.filter (fun p -> Directory.Exists p)

    let fsharpCore =
        searchPaths fsharpPaths
            |> Seq.map (fun p -> Path.Combine(p, "FSharp.Core.dll"))
            |> Seq.find File.Exists

    let dllPath dll =
        searchPaths allStdPaths
            |> Seq.map (fun p -> Path.Combine(p, dll))
            |> Seq.tryFind File.Exists

    systemDlls
        |> List.choose dllPath
        |> List.append [fsharpCore]

let private fscTargetingHelper (systemDlls:string list) (target:TargetFramework option) (version:FSharpVersion option) (args:string list) =

    let extraArgs (t:TargetFramework) =
        ["--noframework"; sprintf "--define:%A" t]
            @ match t with
                | PORTABLE_7 -> ["--targetprofile:netcore"]
                | __________ -> List.empty

    let moreArgs =
        match target,version with
        | Some(t),Some(v) -> systemDllsResolver (systemDlls, t, v)
                                |> List.map (fun p-> sprintf "--reference:%s" p)
                                |> List.append (extraArgs t)
        | _______________ -> List.empty

    let compilerOpts = ["fsc.exe"] @ moreArgs @ args
    log (compilerOpts|> String.concat " ")
    let scs = SimpleSourceCodeServices()
    let errors,errorCode = scs.Compile(compilerOpts |> List.toArray)
    for e in errors do
        let errMsg = e.ToString()
        match e.Severity with
            | Microsoft.FSharp.Compiler.Warning -> traceImportant errMsg
            | Microsoft.FSharp.Compiler.Error -> traceError errMsg
    if errorCode = 0 then
        trace "Compile Success"
    else
        raise (CompilerError "Compile Failed")
    ()

let fsc = fscTargetingHelper [] None None
let fscTargeting (systemDlls, target, version) = fscTargetingHelper systemDlls (Some(target)) (Some(version))
