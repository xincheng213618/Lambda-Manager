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
		string type = Source.GetIO(SourceIndex)?.Type;
		if (type != null)
		{
			return TypesInterop.GetTypeInfo(type);
		}
		return null;
	}

	internal TypeInfo? GetTargetType()
	{
		string type = Target.GetIO(TargetIndex)?.Type;
		if (type != null)
		{
			return TypesInterop.GetTypeInfo(type);
		}
		return null;
	}
}
