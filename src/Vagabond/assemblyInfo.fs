﻿namespace System
open System.Reflection

[<assembly: AssemblyVersionAttribute("0.6.12")>]
[<assembly: AssemblyFileVersionAttribute("0.6.12")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.6.12"
