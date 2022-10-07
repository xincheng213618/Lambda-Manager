using System;
using System.Collections.Generic;

namespace LambdaManager.DataType;

public class Lib
{
    public IntPtr Addr { get; set; }

    public string? Path { get; set; }

    public List<EntryPoint>? EntryPoints { get; set; }
}
