using System.Collections.Generic;
using LambdaManager.Utils;

namespace LambdaManager.DataType;

internal class Function
{
	internal static Function PLACEHOLDER = new Function();

	internal bool Async;

	internal Routine? Routine { get; set; }

	internal EntryPoint? EntryPoint { get; set; }

	internal int Times { get; set; } = 1;


	internal List<object?>? Values { get; set; }

	internal List<object?>? DefaultValues { get; set; }

	internal bool IsReferred { get; set; }

	internal Dictionary<Location, LocationConverter>? Exports { get; set; }

	internal Dictionary<int, int>? Imports { get; set; }

	internal List<Event>? Raise { get; set; }

	internal bool IsVariable(object? value)
	{
		return value == this;
	}

	internal void MarkVariable(int index)
	{
		if (Values == null)
		{
			Values = new List<object>();
		}
		object obj = CollectionUtils.Insert(Values, index, this);
		if (obj != null)
		{
			if (DefaultValues == null)
			{
				DefaultValues = new List<object>();
			}
			CollectionUtils.Insert(DefaultValues, index, obj);
		}
	}

	internal void AddValue(object? value)
	{
		if (Values == null)
		{
			Values = new List<object>();
		}
		Values!.Add(value);
	}
}
