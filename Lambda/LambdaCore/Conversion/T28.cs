using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T28
{
	public static object ToUInt16(TypeInfo info, object value)
	{
        return info.Id switch
        {
            10 or 11 => Convert.ToUInt16((bool)value),
            12 => Convert.ToUInt16((int)value),
            13 or 14 or 22 => Convert.ToUInt16((byte)value),
            17 or 18 or 21 => Convert.ToUInt16((sbyte)value),
            20 => Convert.ToUInt16((char)value),
            23 or 24 or 25 => Convert.ToUInt16((short)value),
            27 or 28 => Convert.ToUInt16((ushort)value),
            30 or 31 or 32 => Convert.ToUInt16((int)value),
            35 or 36 => value,
            40 or 42 or 61 => Convert.ToUInt16((long)value),
            41 or 60 => (info.Size == 4) ? Convert.ToUInt16((int)value) : Convert.ToUInt16((long)value),
            45 => Convert.ToUInt16((ulong)value),
            46 => (info.Size == 4) ? Convert.ToUInt16((uint)value) : Convert.ToUInt16((ulong)value),
            50 or 51 => Convert.ToUInt16((float)value),
            55 or 56 => Convert.ToUInt16((double)value),
            62 => (info.Size == 8) ? Convert.ToUInt16((double)value) : Convert.ToUInt16((decimal)value),
            65 or 66 or 67 => Convert.ToUInt16((decimal)value),
            _ => value,
        };
    }
}
