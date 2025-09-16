using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T56
{
	public static object ToDouble(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToDouble((bool)value),
            12 => Convert.ToDouble((int)value),
            13 or 14 or 22 => Convert.ToDouble((byte)value),
            17 or 18 or 21 => Convert.ToDouble((sbyte)value),
            20 => Convert.ToDouble((char)value),
            23 or 24 or 25 => Convert.ToDouble((short)value),
            27 or 28 => Convert.ToDouble((ushort)value),
            30 or 31 or 32 => Convert.ToDouble((int)value),
            35 or 36 => Convert.ToDouble((uint)value),
            40 or 42 or 61 => Convert.ToDouble((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToDouble((int)value) : Convert.ToDouble((long)value),
            45 => Convert.ToDouble((ulong)value),
            46 => (info.Size == 4) ? Convert.ToDouble((uint)value) : Convert.ToDouble((ulong)value),
            50 or 51 => Convert.ToDouble((float)value),
            55 or 56 => value,
            62 => (info.Size == 8) ? Convert.ToDouble((double)value) : Convert.ToDouble((decimal)value),
            65 or 66 or 67 => Convert.ToDouble((decimal)value),
            _ => value,
        };
    }
}
