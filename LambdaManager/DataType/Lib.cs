using System;
using System.Collections.Generic;

namespace LambdaManager.DataType;

internal class Lib
{
	internal IntPtr Addr { get; set; }

	internal string? Path { get; set; }

	internal List<EntryPoint>? EntryPoints { get; set; }
}
