using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T18
{
	public static object ToSByte(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToSByte((bool)value),
            12 => Convert.ToSByte((int)value),
            13 or 14 or 22 => Convert.ToSByte((byte)value),
            17 or 18 or 21 => value,
            20 => Convert.ToSByte((char)value),
            23 or 24 or 25 => Convert.ToSByte((short)value),
            27 or 28 => Convert.ToSByte((ushort)value),
            30 or 31 or 32 => Convert.ToSByte((int)value),
            35 or 36 => Convert.ToSByte((uint)value),
            40 or 42 or 61 => Convert.ToSByte((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToSByte((int)value) : Convert.ToSByte((long)value),
            45 => Convert.ToSByte((ulong)value),
            46 => (info.Size == 4) ? Convert.ToSByte((uint)value) : Convert.ToSByte((ulong)value),
            50 or 51 => Convert.ToSByte((float)value),
            55 or 56 => Convert.ToSByte((double)value),
            62 => (info.Size == 8) ? Convert.ToSByte((double)value) : Convert.ToSByte((decimal)value),
            65 or 66 or 67 => Convert.ToSByte((decimal)value),
            _ => value,
        };
    }
}
