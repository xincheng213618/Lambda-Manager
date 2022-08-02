using System;
using System.Collections.Generic;

namespace LambdaManager.DataType;

public class Lib
{
	public IntPtr Addr { get; set; }

	internal string? Path { get; set; }

	internal List<EntryPoint>? EntryPoints { get; set; }
}
