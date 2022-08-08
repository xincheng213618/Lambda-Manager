using System.Collections.Generic;

namespace LambdaManager.DataType;

public class Routine
{
	public static Routine PLACEHOLDER = new Routine();

	public bool Async;

	public List<Function>? Functions { get; set; }

	public Dictionary<Location, LocationConverter>? Referring { get; set; }

	public Dictionary<Function, List<Location>>? Referred { get; set; }

	public Routine Clone()
	{
		return new Routine
		{
			Functions = Functions,
			Referring = Referring,
			Referred = Referred
		};
	}
}
