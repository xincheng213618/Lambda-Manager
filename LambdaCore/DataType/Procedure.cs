using System.Collections.Generic;

namespace LambdaManager.DataType;

internal class Procedure
{
	internal Component? Parent { get; set; }

	internal string? Name { get; set; }

	internal string? Icon { get; set; }

	internal List<string>? Event { get; set; }

	internal List<string>? Key { get; set; }

	internal List<string>? Arg { get; set; }

	internal string? Timer { get; set; }

	internal List<Action>? Actions { get; set; }

	internal List<string>? Exports { get; set; }

	internal string? Aysnc { get; set; }

	internal Routine? Routine { get; set; }

	internal bool IsGUIProcedure { get; set; }
}
