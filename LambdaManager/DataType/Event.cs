using System.Collections.Generic;
using LambdaManager.Core;

namespace LambdaManager.DataType
{

    public class Event
    {
        public string? Type { get; set; }

        public ArgumentType ArgType { get; set; }

        public Dictionary<string, int>? Keys { get; set; }

        public string? Data { get; set; }

        public Dictionary<Routine, Dictionary<string, int>>? DataMap { get; set; }

        public void AddEventMap(Routine routine, string key, int index)
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

        public Dictionary<string, int>? GetEventMap(Routine routine)
        {
            return DataMap?[routine];
        }

        public void SetArgType(bool hasKey, bool allJsonValue, bool hasBracket)
        {
            if (hasBracket)
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

}
