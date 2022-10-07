using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T41
{
	public static object ToInt64(TypeInfo info, object value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return Convert.ToInt64((bool)value);
		case 12:
			return Convert.ToInt64((int)value);
		case 13:
		case 14:
		case 22:
			return Convert.ToInt64((byte)value);
		case 17:
		case 18:
		case 21:
			return Convert.ToInt64((sbyte)value);
		case 20:
			return Convert.ToInt64((char)value);
		case 23:
		case 24:
		case 25:
			return Convert.ToInt64((short)value);
		case 27:
		case 28:
			return Convert.ToInt64((ushort)value);
		case 30:
		case 31:
		case 32:
			return Convert.ToInt64((int)value);
		case 35:
		case 36:
			return Convert.ToInt64((uint)value);
		case 40:
		case 42:
		case 61:
			return value;
		case 41:
		case 60:
			if (info.Size != 4)
			{
				return value;
			}
			return Convert.ToInt64((int)value);
		case 45:
			return Convert.ToInt64((ulong)value);
		case 46:
			return (info.Size == 4) ? Convert.ToInt64((uint)value) : Convert.ToInt64((ulong)value);
		case 50:
		case 51:
			return Convert.ToInt64((float)value);
		case 55:
		case 56:
			return Convert.ToInt64((double)value);
		case 62:
			return (info.Size == 8) ? Convert.ToInt64((double)value) : Convert.ToInt64((decimal)value);
		case 65:
		case 66:
		case 67:
			return Convert.ToInt64((decimal)value);
		default:
			return value;
		}
	}
}
