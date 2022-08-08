using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T14
{
	public static object ToByte(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToByte((bool)value);
		case 12:
			return Convert.ToByte((int)value);
		case 13:
		case 14:
		case 22:
			return value;
		case 17:
		case 18:
		case 21:
			return Convert.ToByte((sbyte)value);
		case 20:
			return Convert.ToByte((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToByte((short)value);
		case 27:
		case 28:
			return Convert.ToByte((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToByte((int)value);
		case 35:
		case 36:
			return Convert.ToByte((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToByte((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToByte((int)value) : Convert.ToByte((long)value);
		case 45:
			return Convert.ToByte((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToByte((uint)value) : Convert.ToByte((ulong)value);
		case 50:
		case 51:
			return Convert.ToByte((float)value);
		case 55:
		case 56:
			return Convert.ToByte((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToByte((double)value) : Convert.ToByte((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToByte((decimal)value);
		default:
			return value;
		}
	}
}
