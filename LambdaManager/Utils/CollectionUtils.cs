using System.Collections.Generic;
using LambdaManager.DataType;

namespace LambdaManager.Utils;

internal class CollectionUtils
{
	public static void Insert<T>(List<T?> list, int index, T? value)
	{
		if (index < list.Count)
		{
			list[index] = value;
			return;
		}
		for (int i = list.Count; i < index; i++)
		{
			list.Add(default(T));
		}
		list.Add(value);
	}

	public static void Insert2(List<KeyValuePair<Action, int>?> list, int index, KeyValuePair<Action, int> value)
	{
		if (index < list.Count)
		{
			list[index] = value;
			return;
		}
		for (int i = list.Count; i < index; i++)
		{
			list.Add(null);
		}
		list.Add(value);
	}
}
