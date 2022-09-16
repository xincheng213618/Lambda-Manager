using System.Collections.Generic;
using LambdaManager.Core;

namespace LambdaManager.DataType;

public class Link
{
	public int SourceIndex;

	public int TargetIndex;

	public Actions Source { get; set; } = new Actions();


	public Actions Target { get; set; } = new Actions();


	public List<CastType> CastTypes { get; set; } = new List<CastType>();


	public bool IsInputSource()
	{
		int? obj = Source.Inputs?.Count;
		return SourceIndex < obj;
	}

	public bool IsOutputSource()
	{
		int? obj = Source.Inputs?.Count;
		return SourceIndex >= obj;
	}

	public IO? GetSourceIO()
	{
		return Source.GetIO(SourceIndex);
	}

	public bool IsInputTarget()
	{
		int? obj = Target.Inputs?.Count;
		return TargetIndex < obj;
	}

	public bool IsOutputTarget()
	{
		int? obj = Target.Inputs?.Count;
		return TargetIndex >= obj;
	}

	public IO? GetTargetIO()
	{
		return Target.GetIO(TargetIndex);
	}

	public TypeInfo? GetSourceType()
	{
		string type = Source.GetIO(SourceIndex)?.Type;
		if (type != null)
		{
			return TypesInterop.GetTypeInfo(type);
		}
		return null;
	}

	public TypeInfo? GetTargetType()
	{
		string type = Target.GetIO(TargetIndex)?.Type;
		if (type != null)
		{
			return TypesInterop.GetTypeInfo(type);
		}
		return null;
	}
}
