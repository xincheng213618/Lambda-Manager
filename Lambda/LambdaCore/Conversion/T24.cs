using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T24
{
	public static object ToInt16(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToInt16((bool)value),
            12 => Convert.ToInt16((int)value),
            13 or 14 or 22 => Convert.ToInt16((byte)value),
            17 or 18 or 21 => Convert.ToInt16((sbyte)value),
            20 => Convert.ToInt16((char)value),
            23 or 24 or 25 => value,
            27 or 28 => Convert.ToInt16((ushort)value),
            30 or 31 or 32 => Convert.ToInt16((int)value),
            35 or 36 => Convert.ToInt16((uint)value),
            40 or 42 or 61 => Convert.ToInt16((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToInt16((int)value) : Convert.ToInt16((long)value),
            45 => Convert.ToInt16((ulong)value),
            46 => (info.Size == 4) ? Convert.ToInt16((uint)value) : Convert.ToInt16((ulong)value),
            50 or 51 => Convert.ToInt16((float)value),
            55 or 56 => Convert.ToInt16((double)value),
            62 => (info.Size == 8) ? Convert.ToInt16((double)value) : Convert.ToInt16((decimal)value),
            65 or 66 or 67 => Convert.ToInt16((decimal)value),
            _ => value,
        };
    }
}
