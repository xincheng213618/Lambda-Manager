using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T14
{
	public static object ToByte(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToByte((bool)value),
            12 => Convert.ToByte((int)value),
            13 or 14 or 22 => value,
            17 or 18 or 21 => Convert.ToByte((sbyte)value),
            20 => Convert.ToByte((char)value),
            23 or 24 or 25 => Convert.ToByte((short)value),
            27 or 28 => Convert.ToByte((ushort)value),
            30 or 31 or 32 => Convert.ToByte((int)value),
            35 or 36 => Convert.ToByte((uint)value),
            40 or 42 or 61 => Convert.ToByte((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToByte((int)value) : Convert.ToByte((long)value),
            45 => Convert.ToByte((ulong)value),
            46 => (info.Size == 4) ? Convert.ToByte((uint)value) : Convert.ToByte((ulong)value),
            50 or 51 => Convert.ToByte((float)value),
            55 or 56 => Convert.ToByte((double)value),
            62 => (info.Size == 8) ? Convert.ToByte((double)value) : Convert.ToByte((decimal)value),
            65 or 66 or 67 => Convert.ToByte((decimal)value),
            _ => value,
        };
    }
}
