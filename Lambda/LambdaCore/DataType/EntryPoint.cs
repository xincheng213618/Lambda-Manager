using System;
using System.Collections.Generic;
using LambdaManager.Core;

namespace LambdaManager.DataType;

public class EntryPoint
{
    public IntPtr FuncAddr { get; set; }

    public List<TypeInfo?>? Paremeters { get; set; }

    public int InputCount { get; set; }

    public string Code { get; set; } = "";


    public Dictionary<int, int>? Exports { get; set; }
}
