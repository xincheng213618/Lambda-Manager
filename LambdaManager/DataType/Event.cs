using System.Collections.Generic;
using LambdaManager.Core;

namespace LambdaManager.DataType;

internal class Event
{
	internal string? Type { get; set; }

	internal ArgumentType ArgType { get; set; }

	internal Dictionary<string, int>? Keys { get; set; }

	internal string? Data { get; set; }

	internal Dictionary<Routine, Dictionary<string, int>>? DataMap { get; set; }

	internal void AddEventMap(Routine routine, string key, int index)
	{
		if (DataMap == null)
		{
			DataMap = new Dictionary<Routine, Dictionary<string, int>>();
		}
		DataMap!.TryGetValue(routine, out var map);
		if (map == null)
		{
			map = new Dictionary<string, int>();
			DataMap!.Add(routine, map);
		}
		map.Add(key, index);
	}

	internal Dictionary<string, int>? GetEventMap(Routine routine)
	{
		return DataMap?[routine];
	}

	internal void SetArgType(bool hasKey, bool isArg, bool allJsonValue, bool hasBracket)
	{
		if (isArg)
		{
			ArgType = ArgumentType.POINTER;
		}
		else if (hasBracket)
		{
			ArgType = ArgumentType.JSON_STRING;
		}
		else if (hasKey)
		{
			ArgType = (allJsonValue ? ArgumentType.JSON_OBJECT : ArgumentType.STL_MAP);
		}
		else
		{
			ArgType = ArgumentType.NO_ARGS;
		}
	}
}
