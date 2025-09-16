using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion
{
    public static class T12
    {
        private static readonly System.Collections.Generic.Dictionary<int, Func<TypeInfo, object, object>> BoolConverters = new()
        {
            [10] = (_, v) => Convert.ToBoolean((bool)v),
            [11] = (_, v) => Convert.ToBoolean((bool)v),
            [12] = (_, v) => v, // ÒÑ¾­ÊÇ bool
            [13] = (_, v) => Convert.ToBoolean((byte)v),
            [14] = (_, v) => Convert.ToInt32((byte)v),
            [17] = (_, v) => Convert.ToBoolean((sbyte)v),
            [18] = (_, v) => Convert.ToInt32((sbyte)v),
            [20] = (_, v) => Convert.ToBoolean((char)v),
            [21] = (_, v) => Convert.ToInt32((sbyte)v),
            [22] = (_, v) => Convert.ToInt32((byte)v),
            [23] = (_, v) => Convert.ToBoolean((short)v),
            [24] = (_, v) => Convert.ToInt32((short)v),
            [25] = (_, v) => Convert.ToInt32((short)v),
            [27] = (_, v) => Convert.ToBoolean((ushort)v),
            [28] = (_, v) => Convert.ToInt32((ushort)v),
            [30] = (_, v) => Convert.ToBoolean((int)v),
            [31] = (_, v) => Convert.ToInt32((int)v),
            [32] = (_, v) => Convert.ToInt32((int)v),
            [35] = (_, v) => Convert.ToBoolean((uint)v),
            [36] = (_, v) => Convert.ToInt32((uint)v),
            [40] = (_, v) => Convert.ToBoolean((long)v),
            [41] = (info, v) => info.Size == 4 ? Convert.ToInt32((int)v) : Convert.ToInt32((long)v),
            [42] = (_, v) => Convert.ToInt32((long)v),
            [45] = (_, v) => Convert.ToBoolean((ulong)v),
            [46] = (info, v) => info.Size == 4 ? Convert.ToInt32((uint)v) : Convert.ToInt32((ulong)v),
            [50] = (_, v) => Convert.ToBoolean((float)v),
            [51] = (_, v) => Convert.ToInt32((float)v),
            [55] = (_, v) => Convert.ToBoolean((double)v),
            [56] = (_, v) => Convert.ToInt32((double)v),
            [60] = (info, v) => info.Size == 4 ? Convert.ToInt32((int)v) : Convert.ToInt32((long)v),
            [61] = (_, v) => Convert.ToInt32((long)v),
            [62] = (info, v) => info.Size == 8 ? Convert.ToInt32((double)v) : Convert.ToInt32((decimal)v),
            [65] = (_, v) => Convert.ToInt32((decimal)v),
            [66] = (_, v) => Convert.ToInt32((decimal)v),
            [67] = (_, v) => Convert.ToInt32((decimal)v),
        };

        public static object ToBool(TypeInfo info, object value)
        {
            if (BoolConverters.TryGetValue(info.Id, out var conv))
                return conv(info, value);
            return value;
        }
    }
}