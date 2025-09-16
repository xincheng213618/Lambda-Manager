using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T45
{
	public static object ToUInt64(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToUInt64((bool)value),
            12 => Convert.ToUInt64((int)value),
            13 or 14 or 22 => Convert.ToUInt64((byte)value),
            17 or 18 or 21 => Convert.ToUInt64((sbyte)value),
            20 => Convert.ToUInt64((char)value),
            23 or 24 or 25 => Convert.ToUInt64((short)value),
            27 or 28 => Convert.ToUInt64((ushort)value),
            30 or 31 or 32 => Convert.ToUInt64((int)value),
            35 or 36 => Convert.ToUInt64((uint)value),
            40 or 42 or 61 => Convert.ToUInt64((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToUInt64((int)value) : Convert.ToUInt64((long)value),
            45 => value,
            46 => (info.Size == 4) ? Convert.ToUInt64((uint)value) : Convert.ToUInt64((ulong)value),
            50 or 51 => Convert.ToUInt64((float)value),
            55 or 56 => Convert.ToUInt64((double)value),
            62 => (info.Size == 8) ? Convert.ToUInt64((double)value) : Convert.ToUInt64((decimal)value),
            65 or 66 or 67 => Convert.ToUInt64((decimal)value),
            _ => value,
        };
    }
}
