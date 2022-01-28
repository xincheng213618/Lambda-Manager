namespace LambdaManager.DataType;

internal class Location
{
	internal Function Function { get; set; } = new Function();


	internal int Index { get; set; }

	internal int Group { get; set; }

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
		if (Function == location.Function && Index == location.Index)
		{
			return Group == location.Group;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int hashCode = Function.GetHashCode();
		int num = Index << 16;
		int hashCode2 = Group.GetHashCode();
		return hashCode ^ (num + hashCode2);
	}
}
