using System.Collections.Generic;
using LambdaManager.Core;

namespace LambdaManager.DataType;

internal class Link
{
	internal int SourceIndex;

	internal int TargetIndex;

	internal Action Source { get; set; } = new Action();


	internal Action Target { get; set; } = new Action();


	internal List<CastType> CastTypes { get; set; } = new List<CastType>();


	internal bool IsInputSource()
	{
		int? obj = Source.Inputs?.Count;
		return SourceIndex < obj;
	}

	internal bool IsOutputSource()
	{
		int? obj = Source.Inputs?.Count;
		return SourceIndex >= obj;
	}

	internal IO? GetSourceIO()
	{
		return Source.GetIO(SourceIndex);
	}

	internal bool IsInputTarget()
	{
		int? obj = Target.Inputs?.Count;
		return TargetIndex < obj;
	}

	internal bool IsOutputTarget()
	{
		int? obj = Target.Inputs?.Count;
		return TargetIndex >= obj;
	}

	internal IO? GetTargetIO()
	{
		return Target.GetIO(TargetIndex);
	}

	internal TypeInfo? GetSourceType()
	{
		string text = Source.GetIO(SourceIndex)?.Type;
		if (text != null)
		{
			return TypesInterop.GetTypeInfo(text);
		}
		return null;
	}

	internal TypeInfo? GetTargetType()
	{
		string text = Target.GetIO(TargetIndex)?.Type;
		if (text != null)
		{
			return TypesInterop.GetTypeInfo(text);
		}
		return null;
	}
}
