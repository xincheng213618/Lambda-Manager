using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

internal class T51
{
	public static object ToFloat(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToSingle((bool)value);
		case 12:
			return Convert.ToSingle((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToSingle((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToSingle((sbyte)value);
		case 20:
			return Convert.ToSingle((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToSingle((short)value);
		case 27:
		case 28:
			return Convert.ToSingle((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToSingle((int)value);
		case 35:
		case 36:
			return Convert.ToSingle((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToSingle((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToSingle((int)value) : Convert.ToSingle((long)value);
		case 45:
			return Convert.ToSingle((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToSingle((uint)value) : Convert.ToSingle((ulong)value);
		case 50:
		case 51:
			return value;
		case 55:
		case 56:
			return Convert.ToSingle((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToSingle((double)value) : Convert.ToSingle((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToSingle((decimal)value);
		default:
			return value;
		}
	}
}
