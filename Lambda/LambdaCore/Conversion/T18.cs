using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T18
{
	public static object ToSByte(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToSByte((bool)value);
		case 12:
			return Convert.ToSByte((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToSByte((byte)value);
		case 17:
		case 18:
		case 21:
			return value;
		case 20:
			return Convert.ToSByte((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToSByte((short)value);
		case 27:
		case 28:
			return Convert.ToSByte((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToSByte((int)value);
		case 35:
		case 36:
			return Convert.ToSByte((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToSByte((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToSByte((int)value) : Convert.ToSByte((long)value);
		case 45:
			return Convert.ToSByte((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToSByte((uint)value) : Convert.ToSByte((ulong)value);
		case 50:
		case 51:
			return Convert.ToSByte((float)value);
		case 55:
		case 56:
			return Convert.ToSByte((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToSByte((double)value) : Convert.ToSByte((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToSByte((decimal)value);
		default:
			return value;
		}
	}
}
