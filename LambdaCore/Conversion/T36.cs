using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T36
{
	public static object ToUInt32(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToUInt32((bool)value);
		case 12:
			return Convert.ToUInt32((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToUInt32((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToUInt32((sbyte)value);
		case 20:
			return Convert.ToUInt32((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToUInt32((short)value);
		case 27:
		case 28:
			return Convert.ToUInt32((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToUInt32((int)value);
		case 35:
		case 36:
			return value;
		case 40:
		case 42:
		case 61:
			return Convert.ToUInt32((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToUInt32((int)value) : Convert.ToUInt32((long)value);
		case 45:
			return Convert.ToUInt32((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToUInt32((uint)value) : Convert.ToUInt32((ulong)value);
		case 50:
		case 51:
			return Convert.ToUInt32((float)value);
		case 55:
		case 56:
			return Convert.ToUInt32((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToUInt32((double)value) : Convert.ToUInt32((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToUInt32((decimal)value);
		default:
			return value;
		}
	}
}
