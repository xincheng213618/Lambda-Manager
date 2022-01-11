namespace LambdaManager.DataType;

internal class Location
{
	internal Function Function { get; set; } = new Function();


	internal int Index { get; set; }

	public override bool Equals(object? obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is Location location))
		{
			return false;
		}
		if (Function == location.Function)
		{
			return Index == location.Index;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int hash = Function.GetHashCode();
		return Index.GetHashCode() ^ hash;
	}
}
