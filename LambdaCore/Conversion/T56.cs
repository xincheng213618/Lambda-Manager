using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

internal class T56
{
	public static object ToDouble(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToDouble((bool)value);
		case 12:
			return Convert.ToDouble((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToDouble((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToDouble((sbyte)value);
		case 20:
			return Convert.ToDouble((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToDouble((short)value);
		case 27:
		case 28:
			return Convert.ToDouble((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToDouble((int)value);
		case 35:
		case 36:
			return Convert.ToDouble((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToDouble((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToDouble((int)value) : Convert.ToDouble((long)value);
		case 45:
			return Convert.ToDouble((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToDouble((uint)value) : Convert.ToDouble((ulong)value);
		case 50:
		case 51:
			return Convert.ToDouble((float)value);
		case 55:
		case 56:
			return value;
		case 62:
			return (info.Size == 8) ? Convert.ToDouble((double)value) : Convert.ToDouble((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToDouble((decimal)value);
		default:
			return value;
		}
	}
}
