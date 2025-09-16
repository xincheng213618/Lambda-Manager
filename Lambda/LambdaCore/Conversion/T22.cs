using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T22
{
	public static object ToUChar(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToChar((bool)value),
            12 => Convert.ToByte((int)value),
            13 => Convert.ToChar((byte)value),
            14 => Convert.ToByte((byte)value),
            17 => Convert.ToChar((sbyte)value),
            18 => Convert.ToByte((sbyte)value),
            20 => Convert.ToChar((char)value),
            21 => Convert.ToByte((sbyte)value),
            22 => value,
            23 => Convert.ToChar((short)value),
            24 or 25 => Convert.ToByte((short)value),
            27 => Convert.ToChar((ushort)value),
            28 => Convert.ToByte((ushort)value),
            30 => Convert.ToChar((int)value),
            31 or 32 => Convert.ToByte((int)value),
            35 => Convert.ToChar((uint)value),
            36 => Convert.ToByte((uint)value),
            40 => Convert.ToChar((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToByte((int)value) : Convert.ToByte((long)value),
            42 or 61 => Convert.ToByte((long)value),
            45 => Convert.ToChar((ulong)value),
            46 => (info.Size == 4) ? Convert.ToByte((uint)value) : Convert.ToByte((ulong)value),
            50 => Convert.ToChar((float)value),
            51 => Convert.ToByte((float)value),
            55 => Convert.ToChar((double)value),
            56 => Convert.ToByte((double)value),
            62 => (info.Size == 8) ? Convert.ToByte((double)value) : Convert.ToByte((decimal)value),
            65 => Convert.ToChar((decimal)value),
            66 or 67 => Convert.ToByte((decimal)value),
            _ => value,
        };
    }
}
