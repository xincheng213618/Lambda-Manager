using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T66
{
	public static object ToDecimal(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToDecimal((bool)value);
		case 12:
			return Convert.ToDecimal((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToDecimal((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToDecimal((sbyte)value);
		case 20:
			return Convert.ToDecimal((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToDecimal((short)value);
		case 27:
		case 28:
			return Convert.ToDecimal((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToDecimal((int)value);
		case 35:
		case 36:
			return Convert.ToDecimal((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToDecimal((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToDecimal((int)value) : Convert.ToDecimal((long)value);
		case 45:
			return Convert.ToDecimal((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToDecimal((uint)value) : Convert.ToDecimal((ulong)value);
		case 50:
		case 51:
			return Convert.ToDecimal((float)value);
		case 55:
		case 56:
			return Convert.ToDecimal((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToDecimal((double)value) : Convert.ToDecimal((decimal)value);
		case 65:
		case 66:
		case 67:
			return value;
		default:
			return value;
		}
	}
}
