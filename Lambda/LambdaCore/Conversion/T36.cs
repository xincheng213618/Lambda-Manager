using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T36
{
	public static object ToUInt32(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToUInt32((bool)value),
            12 => Convert.ToUInt32((int)value),
            13 or 14 or 22 => Convert.ToUInt32((byte)value),
            17 or 18 or 21 => Convert.ToUInt32((sbyte)value),
            20 => Convert.ToUInt32((char)value),
            23 or 24 or 25 => Convert.ToUInt32((short)value),
            27 or 28 => Convert.ToUInt32((ushort)value),
            30 or 31 or 32 => Convert.ToUInt32((int)value),
            35 or 36 => value,
            40 or 42 or 61 => Convert.ToUInt32((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToUInt32((int)value) : Convert.ToUInt32((long)value),
            45 => Convert.ToUInt32((ulong)value),
            46 => (info.Size == 4) ? Convert.ToUInt32((uint)value) : Convert.ToUInt32((ulong)value),
            50 or 51 => Convert.ToUInt32((float)value),
            55 or 56 => Convert.ToUInt32((double)value),
            62 => (info.Size == 8) ? Convert.ToUInt32((double)value) : Convert.ToUInt32((decimal)value),
            65 or 66 or 67 => Convert.ToUInt32((decimal)value),
            _ => value,
        };
    }
}
