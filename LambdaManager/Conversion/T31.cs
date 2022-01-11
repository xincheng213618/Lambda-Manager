using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

internal class T31
{
	public static object ToInt32(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToInt32((bool)value);
		case 12:
			return value;
		case 13:
		case 14:
		case 22:
			return Convert.ToInt32((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToInt32((sbyte)value);
		case 20:
			return Convert.ToInt32((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToInt32((short)value);
		case 27:
		case 28:
			return Convert.ToInt32((ushort)value);
		case 30:
		case 31:
		case 32:
			return value;
		case 35:
		case 36:
			return Convert.ToInt32((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToInt32((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToInt32((int)value) : Convert.ToInt32((long)value);
		case 45:
			return Convert.ToInt32((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToInt32((uint)value) : Convert.ToInt32((ulong)value);
		case 50:
		case 51:
			return Convert.ToInt32((float)value);
		case 55:
		case 56:
			return Convert.ToInt32((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToInt32((double)value) : Convert.ToInt32((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToInt32((decimal)value);
		default:
			return value;
		}
	}
}
