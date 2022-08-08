using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T45
{
	public static object ToUInt64(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToUInt64((bool)value);
		case 12:
			return Convert.ToUInt64((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToUInt64((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToUInt64((sbyte)value);
		case 20:
			return Convert.ToUInt64((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToUInt64((short)value);
		case 27:
		case 28:
			return Convert.ToUInt64((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToUInt64((int)value);
		case 35:
		case 36:
			return Convert.ToUInt64((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToUInt64((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToUInt64((int)value) : Convert.ToUInt64((long)value);
		case 45:
			return value;
		case 46:
			return (info.Size == 4) ? Convert.ToUInt64((uint)value) : Convert.ToUInt64((ulong)value);
		case 50:
		case 51:
			return Convert.ToUInt64((float)value);
		case 55:
		case 56:
			return Convert.ToUInt64((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToUInt64((double)value) : Convert.ToUInt64((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToUInt64((decimal)value);
		default:
			return value;
		}
	}
}
