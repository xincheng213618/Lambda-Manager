using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T51
{
	public static object ToFloat(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToSingle((bool)value),
            12 => Convert.ToSingle((int)value),
            13 or 14 or 22 => Convert.ToSingle((byte)value),
            17 or 18 or 21 => Convert.ToSingle((sbyte)value),
            20 => Convert.ToSingle((char)value),
            23 or 24 or 25 => Convert.ToSingle((short)value),
            27 or 28 => Convert.ToSingle((ushort)value),
            30 or 31 or 32 => Convert.ToSingle((int)value),
            35 or 36 => Convert.ToSingle((uint)value),
            40 or 42 or 61 => Convert.ToSingle((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToSingle((int)value) : Convert.ToSingle((long)value),
            45 => Convert.ToSingle((ulong)value),
            46 => (info.Size == 4) ? Convert.ToSingle((uint)value) : Convert.ToSingle((ulong)value),
            50 or 51 => value,
            55 or 56 => Convert.ToSingle((double)value),
            62 => (info.Size == 8) ? Convert.ToSingle((double)value) : Convert.ToSingle((decimal)value),
            65 or 66 or 67 => Convert.ToSingle((decimal)value),
            _ => value,
        };
    }
}
