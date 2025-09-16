using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T21
{
	public static object ToChar(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToChar((bool)value),
            12 => Convert.ToSByte((int)value),
            13 => Convert.ToChar((byte)value),
            14 => Convert.ToSByte((byte)value),
            17 => Convert.ToChar((sbyte)value),
            18 => Convert.ToSByte((sbyte)value),
            20 => Convert.ToChar((char)value),
            21 => value,
            22 => Convert.ToSByte((byte)value),
            23 => Convert.ToChar((short)value),
            24 or 25 => Convert.ToSByte((short)value),
            27 => Convert.ToChar((ushort)value),
            28 => Convert.ToSByte((ushort)value),
            30 => Convert.ToChar((int)value),
            31 or 32 => Convert.ToSByte((int)value),
            35 => Convert.ToChar((uint)value),
            36 => Convert.ToSByte((uint)value),
            40 => Convert.ToChar((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToSByte((int)value) : Convert.ToSByte((long)value),
            42 or 61 => Convert.ToSByte((long)value),
            45 => Convert.ToChar((ulong)value),
            46 => (info.Size == 4) ? Convert.ToSByte((uint)value) : Convert.ToSByte((ulong)value),
            50 => Convert.ToChar((float)value),
            51 => Convert.ToSByte((float)value),
            55 => Convert.ToChar((double)value),
            56 => Convert.ToSByte((double)value),
            62 => (info.Size == 8) ? Convert.ToSByte((double)value) : Convert.ToSByte((decimal)value),
            65 => Convert.ToChar((decimal)value),
            66 or 67 => Convert.ToSByte((decimal)value),
            _ => value,
        };
    }
}
