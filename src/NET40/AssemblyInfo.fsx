﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp Composable Extension Functions")>]
[<assembly: AssemblyDescriptionAttribute("NET40: Inline composable fsharp functions around BCL static methods. Supports F# 3.0 and later with .NET runtimes v2.0,v4.0, Sliverlight 5.0 and WinRT")>]
[<assembly: AssemblyProductAttribute("ComposableExtensions")>]
[<assembly: AssemblyVersionAttribute("0.11.0")>]
[<assembly: AssemblyFileVersionAttribute("0.11.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.11.0"
