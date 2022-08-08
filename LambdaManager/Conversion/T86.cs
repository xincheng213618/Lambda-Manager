using System;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

public class T86
{
	public static Array ToArrayPtr(TypeInfo info, object?[] value)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return ToBoolArray(info, value);
		case 12:
			return ToInt32Array(info, value);
		case 13:
		case 14:
		case 22:
			return ToByteArray(info, value);
		case 17:
		case 18:
		case 21:
			return ToSByteArray(info, value);
		case 20:
			return ToCharArray(info, value);
		case 23:
		case 24:
		case 25:
			return ToInt16Array(info, value);
		case 27:
		case 28:
			return ToUInt16Array(info, value);
		case 30:
		case 31:
		case 32:
			return ToInt32Array(info, value);
		case 35:
		case 36:
			return ToUInt32Array(info, value);
		case 40:
		case 42:
		case 61:
			return ToInt64Array(info, value);
		case 41:
		case 60:
			if (info.Size != 4)
			{
				return ToInt64Array(info, value);
			}
			return ToInt32Array(info, value);
		case 45:
			return ToUInt64Array(info, value);
		case 46:
			if (info.Size != 4)
			{
				return ToUInt64Array(info, value);
			}
			return ToUInt32Array(info, value);
		case 50:
		case 51:
			return ToFloatArray(info, value);
		case 55:
		case 56:
			return ToDoubleArray(info, value);
		case 62:
			if (info.Size != 8)
			{
				return ToDecimalArray(info, value);
			}
			return ToDoubleArray(info, value);
		case 65:
		case 66:
		case 67:
			return ToDecimalArray(info, value);
		case 86:
		case 87:
			return value;
		default:
			return ToIntPtrArray(info, value);
		}
	}

	public static Array ToBoolArray(TypeInfo info, object?[] array)
	{
		bool[] result = new bool[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (bool)array[i];
		}
		return result;
	}

	public static Array ToByteArray(TypeInfo info, object?[] array)
	{
		byte[] result = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (byte)array[i];
		}
		return result;
	}

	public static Array ToSByteArray(TypeInfo info, object?[] array)
	{
		sbyte[] result = new sbyte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (sbyte)array[i];
		}
		return result;
	}

	public static Array ToCharArray(TypeInfo info, object?[] array)
	{
		char[] result = new char[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (char)array[i];
		}
		return result;
	}

	public static Array ToInt16Array(TypeInfo info, object?[] array)
	{
		short[] result = new short[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (short)array[i];
		}
		return result;
	}

	public static Array ToUInt16Array(TypeInfo info, object?[] array)
	{
		ushort[] result = new ushort[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (ushort)array[i];
		}
		return result;
	}

	public static Array ToInt32Array(TypeInfo info, object?[] array)
	{
		int[] result = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (int)array[i];
		}
		return result;
	}

	public static Array ToUInt32Array(TypeInfo info, object?[] array)
	{
		uint[] result = new uint[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (uint)array[i];
		}
		return result;
	}

	public static Array ToInt64Array(TypeInfo info, object?[] array)
	{
		long[] result = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (long)array[i];
		}
		return result;
	}

	public static Array ToUInt64Array(TypeInfo info, object?[] array)
	{
		ulong[] result = new ulong[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (ulong)array[i];
		}
		return result;
	}

	public static Array ToFloatArray(TypeInfo info, object?[] array)
	{
		float[] result = new float[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (float)array[i];
		}
		return result;
	}

	public static Array ToDoubleArray(TypeInfo info, object?[] array)
	{
		double[] result = new double[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (double)array[i];
		}
		return result;
	}

	public static Array ToDecimalArray(TypeInfo info, object?[] array)
	{
		decimal[] result = new decimal[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (decimal)array[i];
		}
		return result;
	}

	public static Array ToIntPtrArray(TypeInfo info, object?[] array)
	{
		IntPtr[] result = new IntPtr[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			result[i] = (IntPtr)array[i];
		}
		return result;
	}
}
