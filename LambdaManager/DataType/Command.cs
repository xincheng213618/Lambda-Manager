using System.Collections.Generic;

namespace LambdaManager.DataType;

internal class Command
{
	internal string? Name { get; set; }

	internal List<string>? Raise { get; set; }

	internal string? Icon { get; set; }
}
