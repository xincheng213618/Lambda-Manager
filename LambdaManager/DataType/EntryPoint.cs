using System;
using System.Collections.Generic;
using LambdaManager.Core;

namespace LambdaManager.DataType;

internal class EntryPoint
{
	internal IntPtr FuncAddr { get; set; }

	internal List<TypeInfo?>? Paremeters { get; set; }

	internal int InputCount { get; set; }

	internal string Code { get; set; } = "";


	internal Dictionary<int, int>? Exports { get; set; }
}
