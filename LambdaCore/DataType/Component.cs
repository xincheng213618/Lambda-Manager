using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LambdaManager.DataType;

internal class Component
{
	internal string? Name { get; set; }

	internal string? Lib { get; set; }

	internal List<string>? Init { get; set; }

	internal string? Mount { get; set; }

	internal List<string>? Depend { get; set; }

	internal List<Procedure>? Procedures { get; set; }

	internal string? GetLibShortName()
	{
		if (Lib == null)
		{
			return null;
		}
		return Regex.Replace(Regex.Split(Lib, "[/\\\\]+")[^1], "\\.dll", "", RegexOptions.IgnoreCase);
	}

	internal bool IsGUIComponent()
	{
		return Mount != null;
	}
}
