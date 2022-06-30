using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

internal class T22
{
	public static object ToUChar(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToChar((bool)value);
		case 12:
			return Convert.ToByte((int)value);
		case 13:
			return Convert.ToChar((byte)value);
		case 14:
			return Convert.ToByte((byte)value);
		case 17:
			return Convert.ToChar((sbyte)value);
		case 18:
			return Convert.ToByte((sbyte)value);
		case 20:
			return Convert.ToChar((char)value);
		case 21:
			return Convert.ToByte((sbyte)value);
		case 22:
			return value;
		case 23:
			return Convert.ToChar((short)value);
		case 24:
		case 25:
			return Convert.ToByte((short)value);
		case 27:
			return Convert.ToChar((ushort)value);
		case 28:
			return Convert.ToByte((ushort)value);
		case 30:
			return Convert.ToChar((int)value);
		case 31:
		case 32:
			return Convert.ToByte((int)value);
		case 35:
			return Convert.ToChar((uint)value);
		case 36:
			return Convert.ToByte((uint)value);
		case 40:
			return Convert.ToChar((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToByte((int)value) : Convert.ToByte((long)value);
		case 42:
		case 61:
			return Convert.ToByte((long)value);
		case 45:
			return Convert.ToChar((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToByte((uint)value) : Convert.ToByte((ulong)value);
		case 50:
			return Convert.ToChar((float)value);
		case 51:
			return Convert.ToByte((float)value);
		case 55:
			return Convert.ToChar((double)value);
		case 56:
			return Convert.ToByte((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToByte((double)value) : Convert.ToByte((decimal)value);
		case 65:
			return Convert.ToChar((decimal)value);
		case 66:
		case 67:
			return Convert.ToByte((decimal)value);
		default:
			return value;
		}
	}
}
