using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T66
{
	public static object ToDecimal(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToDecimal((bool)value),
            12 => Convert.ToDecimal((int)value),
            13 or 14 or 22 => Convert.ToDecimal((byte)value),
            17 or 18 or 21 => Convert.ToDecimal((sbyte)value),
            20 => Convert.ToDecimal((char)value),
            23 or 24 or 25 => Convert.ToDecimal((short)value),
            27 or 28 => Convert.ToDecimal((ushort)value),
            30 or 31 or 32 => Convert.ToDecimal((int)value),
            35 or 36 => Convert.ToDecimal((uint)value),
            40 or 42 or 61 => Convert.ToDecimal((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToDecimal((int)value) : Convert.ToDecimal((long)value),
            45 => Convert.ToDecimal((ulong)value),
            46 => (info.Size == 4) ? Convert.ToDecimal((uint)value) : Convert.ToDecimal((ulong)value),
            50 or 51 => Convert.ToDecimal((float)value),
            55 or 56 => Convert.ToDecimal((double)value),
            62 => (info.Size == 8) ? Convert.ToDecimal((double)value) : Convert.ToDecimal((decimal)value),
            65 or 66 or 67 => value,
            _ => value,
        };
    }
}
