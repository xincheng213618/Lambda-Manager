using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S2
{
	public static int Invoke(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[0] switch
		{
			'0' => Invoke0X(code, p, args), 
			'1' => Invoke1X(code, p, args), 
			'2' => Invoke2X(code, p, args), 
			'6' => Invoke6X(code, p, args), 
			'3' => Invoke3X(code, p, args), 
			'5' => Invoke5X(code, p, args), 
			'4' => Invoke4X(code, p, args), 
			'7' => Invoke7X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke0X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<byte, byte, int>)(void*)p)((byte)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<byte, short, int>)(void*)p)((byte)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<byte, int, int>)(void*)p)((byte)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<byte, float, int>)(void*)p)((byte)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<byte, long, int>)(void*)p)((byte)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<byte, double, int>)(void*)p)((byte)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<byte, decimal, int>)(void*)p)((byte)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, int>)(void*)p)((byte)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke1X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<short, byte, int>)(void*)p)((short)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<short, short, int>)(void*)p)((short)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<short, int, int>)(void*)p)((short)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<short, float, int>)(void*)p)((short)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<short, long, int>)(void*)p)((short)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<short, double, int>)(void*)p)((short)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<short, decimal, int>)(void*)p)((short)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<short, IntPtr, int>)(void*)p)((short)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, int>)(void*)p)((int)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, int>)(void*)p)((int)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int>)(void*)p)((int)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int>)(void*)p)((int)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int>)(void*)p)((int)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int>)(void*)p)((int)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, int>)(void*)p)((int)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, int>)(void*)p)((float)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, int>)(void*)p)((float)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int>)(void*)p)((float)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int>)(void*)p)((float)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int>)(void*)p)((float)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int>)(void*)p)((float)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, int>)(void*)p)((float)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, int>)(void*)p)((long)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, int>)(void*)p)((long)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int>)(void*)p)((long)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int>)(void*)p)((long)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int>)(void*)p)((long)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int>)(void*)p)((long)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, int>)(void*)p)((long)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke4X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, int>)(void*)p)((decimal)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, int>)(void*)p)((decimal)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, int>)(void*)p)((decimal)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, int>)(void*)p)((decimal)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, int>)(void*)p)((decimal)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, int>)(void*)p)((decimal)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, int>)(void*)p)((double)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, int>)(void*)p)((double)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int>)(void*)p)((double)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int>)(void*)p)((double)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int>)(void*)p)((double)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int>)(void*)p)((double)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, int>)(void*)p)((double)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int>)(void*)p)((IntPtr)args![0], (short)args![1]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1]), 
			_ => -1, 
		};
	}
}
