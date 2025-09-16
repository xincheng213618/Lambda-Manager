using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T31
{
	public static object ToInt32(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToInt32((bool)value),
            12 => value,
            13 or 14 or 22 => Convert.ToInt32((byte)value),
            17 or 18 or 21 => Convert.ToInt32((sbyte)value),
            20 => Convert.ToInt32((char)value),
            23 or 24 or 25 => Convert.ToInt32((short)value),
            27 or 28 => Convert.ToInt32((ushort)value),
            30 or 31 or 32 => value,
            35 or 36 => Convert.ToInt32((uint)value),
            40 or 42 or 61 => Convert.ToInt32((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToInt32((int)value) : Convert.ToInt32((long)value),
            45 => Convert.ToInt32((ulong)value),
            46 => (info.Size == 4) ? Convert.ToInt32((uint)value) : Convert.ToInt32((ulong)value),
            50 or 51 => Convert.ToInt32((float)value),
            55 or 56 => Convert.ToInt32((double)value),
            62 => (info.Size == 8) ? Convert.ToInt32((double)value) : Convert.ToInt32((decimal)value),
            65 or 66 or 67 => Convert.ToInt32((decimal)value),
            _ => value,
        };
    }
}
