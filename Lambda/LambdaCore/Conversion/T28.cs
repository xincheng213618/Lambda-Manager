using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T28
{
	public static object ToUInt16(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToUInt16((bool)value);
		case 12:
			return Convert.ToUInt16((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToUInt16((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToUInt16((sbyte)value);
		case 20:
			return Convert.ToUInt16((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToUInt16((short)value);
		case 27:
		case 28:
			return Convert.ToUInt16((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToUInt16((int)value);
		case 35:
		case 36:
			return value;
		case 40:
		case 42:
		case 61:
			return Convert.ToUInt16((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToUInt16((int)value) : Convert.ToUInt16((long)value);
		case 45:
			return Convert.ToUInt16((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToUInt16((uint)value) : Convert.ToUInt16((ulong)value);
		case 50:
		case 51:
			return Convert.ToUInt16((float)value);
		case 55:
		case 56:
			return Convert.ToUInt16((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToUInt16((double)value) : Convert.ToUInt16((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToUInt16((decimal)value);
		default:
			return value;
		}
	}
}
