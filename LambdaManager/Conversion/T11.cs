using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T11
{
	public static object ToBoolean(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return value;
		case 12:
			return Convert.ToBoolean((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToBoolean((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToBoolean((sbyte)value);
		case 20:
			return Convert.ToBoolean((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToBoolean((short)value);
		case 27:
		case 28:
			return Convert.ToBoolean((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToBoolean((int)value);
		case 35:
		case 36:
			return Convert.ToBoolean((uint)value);
		case 40:
		case 42:
		case 61:
			return Convert.ToBoolean((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToBoolean((int)value) : Convert.ToBoolean((long)value);
		case 45:
			return Convert.ToBoolean((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToBoolean((uint)value) : Convert.ToBoolean((ulong)value);
		case 50:
		case 51:
			return Convert.ToBoolean((float)value);
		case 55:
		case 56:
			return Convert.ToBoolean((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToBoolean((double)value) : Convert.ToBoolean((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToBoolean((decimal)value);
		default:
			return value;
		}
	}
}
