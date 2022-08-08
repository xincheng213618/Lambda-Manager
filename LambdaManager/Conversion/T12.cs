using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T12
{
	public static object ToBool(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToBoolean((bool)value);
		case 12:
			return value;
		case 13:
			return Convert.ToBoolean((byte)value);
		case 14:
			return Convert.ToInt32((byte)value);
		case 17:
			return Convert.ToBoolean((sbyte)value);
		case 18:
			return Convert.ToInt32((sbyte)value);
		case 20:
			return Convert.ToBoolean((char)value);
		case 21:
			return Convert.ToInt32((sbyte)value);
		case 22:
			return Convert.ToInt32((byte)value);
		case 23:
			return Convert.ToBoolean((short)value);
		case 24:
		case 25:
			return Convert.ToInt32((short)value);
		case 27:
			return Convert.ToBoolean((ushort)value);
		case 28:
			return Convert.ToInt32((ushort)value);
		case 30:
			return Convert.ToBoolean((int)value);
		case 31:
		case 32:
			return Convert.ToInt32((int)value);
		case 35:
			return Convert.ToBoolean((uint)value);
		case 36:
			return Convert.ToInt32((uint)value);
		case 40:
			return Convert.ToBoolean((long)value);
		case 41:
		case 60:
			return (info.Size == 4) ? Convert.ToInt32((int)value) : Convert.ToInt32((long)value);
		case 42:
		case 61:
			return Convert.ToInt32((long)value);
		case 45:
			return Convert.ToBoolean((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToInt32((uint)value) : Convert.ToInt32((ulong)value);
		case 50:
			return Convert.ToBoolean((float)value);
		case 51:
			return Convert.ToInt32((float)value);
		case 55:
			return Convert.ToBoolean((double)value);
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
