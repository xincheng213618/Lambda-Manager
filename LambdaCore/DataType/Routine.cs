using System.Collections.Generic;

namespace LambdaManager.DataType;

public class Routine
{
	internal static Routine PLACEHOLDER = new Routine();

	internal bool Async;

	internal List<Function>? Functions { get; set; }

	internal Dictionary<Location, LocationConverter>? Referring { get; set; }

	internal Dictionary<Function, List<Location>>? Referred { get; set; }

	internal Routine Clone()
	{
		return new Routine
		{
			Functions = Functions,
			Referring = Referring,
			Referred = Referred
		};
	}
}
