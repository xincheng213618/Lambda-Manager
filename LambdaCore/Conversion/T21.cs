using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

internal class T21
{
	public static object ToChar(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToChar((bool)value);
		case 12:
			return Convert.ToSByte((int)value);
		case 13:
			return Convert.ToChar((byte)value);
		case 14:
			return Convert.ToSByte((byte)value);
		case 17:
			return Convert.ToChar((sbyte)value);
		case 18:
			return Convert.ToSByte((sbyte)value);
		case 20:
			return Convert.ToChar((char)value);
		case 21:
			return value;
		case 22:
			return Convert.ToSByte((byte)value);
		case 23:
			return Convert.ToChar((short)value);
		case 24:
		case 25:
			return Convert.ToSByte((short)value);
		case 27:
			return Convert.ToChar((ushort)value);
		case 28:
			return Convert.ToSByte((ushort)value);
		case 30:
			return Convert.ToChar((int)value);
		case 31:
		case 32:
			return Convert.ToSByte((int)value);
		case 35:
			return Convert.ToChar((uint)value);
		case 36:
			return Convert.ToSByte((uint)value);
		case 40:
			return Convert.ToChar((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToSByte((int)value) : Convert.ToSByte((long)value);
		case 42:
		case 61:
			return Convert.ToSByte((long)value);
		case 45:
			return Convert.ToChar((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToSByte((uint)value) : Convert.ToSByte((ulong)value);
		case 50:
			return Convert.ToChar((float)value);
		case 51:
			return Convert.ToSByte((float)value);
		case 55:
			return Convert.ToChar((double)value);
		case 56:
			return Convert.ToSByte((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToSByte((double)value) : Convert.ToSByte((decimal)value);
		case 65:
			return Convert.ToChar((decimal)value);
		case 66:
		case 67:
			return Convert.ToSByte((decimal)value);
		default:
			return value;
		}
	}
}
