using LambdaManager.Core;
using System;
using System.Collections.Generic;

namespace LambdaManager.Conversion;

public class T11
{
    private static readonly Dictionary<int, Func<TypeInfo, object, object>> BooleanConverters = new()
    {
        [10] = (_, v) => v,
        [11] = (_, v) => v,
        [12] = (_, v) => Convert.ToBoolean((int)v),
        [13] = (_, v) => Convert.ToBoolean((byte)v),
        [17] = (_, v) => Convert.ToBoolean((sbyte)v),
        [20] = (_, v) => Convert.ToBoolean((char)v),
        [23] = (_, v) => Convert.ToBoolean((short)v),
        [27] = (_, v) => Convert.ToBoolean((ushort)v),
        [30] = (_, v) => Convert.ToBoolean((int)v),
        [35] = (_, v) => Convert.ToBoolean((uint)v),
        [40] = (_, v) => Convert.ToBoolean((long)v),
        [41] = (info, v) => info.Size == 4 ? Convert.ToBoolean((int)v) : Convert.ToBoolean((long)v),
        [45] = (_, v) => Convert.ToBoolean((ulong)v),
        [46] = (info, v) => info.Size == 4 ? Convert.ToBoolean((uint)v) : Convert.ToBoolean((ulong)v),
        [50] = (_, v) => Convert.ToBoolean((float)v),
        [55] = (_, v) => Convert.ToBoolean((double)v),
        [62] = (info, v) => info.Size == 8 ? Convert.ToBoolean((double)v) : Convert.ToBoolean((decimal)v),
        [65] = (_, v) => Convert.ToBoolean((decimal)v),
    };

    public static object ToBoolean(TypeInfo info, object value)
    {
        if (BooleanConverters.TryGetValue(info.Id, out var conv))
            return conv(info, value);
        return value;
    }
}
