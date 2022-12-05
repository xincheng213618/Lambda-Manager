using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S46
{
	public static int Invoke6(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => Invoke60XX(code, p, args), 
			'1' => Invoke61XX(code, p, args), 
			'2' => Invoke62XX(code, p, args), 
			'6' => Invoke66XX(code, p, args), 
			'3' => Invoke63XX(code, p, args), 
			'5' => Invoke65XX(code, p, args), 
			'4' => Invoke64XX(code, p, args), 
			'7' => Invoke67XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke60XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke600X(code, p, args), 
			'1' => Invoke601X(code, p, args), 
			'2' => Invoke602X(code, p, args), 
			'6' => Invoke606X(code, p, args), 
			'3' => Invoke603X(code, p, args), 
			'5' => Invoke605X(code, p, args), 
			'4' => Invoke604X(code, p, args), 
			'7' => Invoke607X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke600X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, byte, byte, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, byte, short, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, byte, int, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, byte, float, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, byte, long, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, byte, double, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, byte, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, byte, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke601X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, short, byte, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, short, short, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, short, int, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, short, float, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, short, long, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, short, double, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, short, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, short, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke602X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, int, byte, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, int, short, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, int, int, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, int, float, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, int, long, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, int, double, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, int, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, int, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke606X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, float, byte, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, float, short, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, float, int, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, float, float, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, float, long, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, float, double, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, float, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, float, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke603X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, long, byte, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, long, short, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, long, int, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, long, float, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, long, long, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, long, double, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, long, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, long, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke605X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, double, byte, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, double, short, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, double, int, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, double, float, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, double, long, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, double, double, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, double, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, double, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke604X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, byte, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, short, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, int, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, float, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, long, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, double, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke607X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, byte, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, short, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, int, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, float, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, long, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, double, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke61XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke610X(code, p, args), 
			'1' => Invoke611X(code, p, args), 
			'2' => Invoke612X(code, p, args), 
			'6' => Invoke616X(code, p, args), 
			'3' => Invoke613X(code, p, args), 
			'5' => Invoke615X(code, p, args), 
			'4' => Invoke614X(code, p, args), 
			'7' => Invoke617X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke610X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, byte, byte, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, byte, short, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, byte, int, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, byte, float, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, byte, long, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, byte, double, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, byte, decimal, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, byte, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke611X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, short, byte, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, short, short, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, short, int, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, short, float, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, short, long, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, short, double, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, short, decimal, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, short, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke612X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, int, byte, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, int, short, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, int, int, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, int, float, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, int, long, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, int, double, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, int, decimal, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, int, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke616X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, float, byte, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, float, short, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, float, int, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, float, float, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, float, long, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, float, double, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, float, decimal, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, float, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke613X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, long, byte, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, long, short, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, long, int, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, long, float, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, long, long, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, long, double, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, long, decimal, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, long, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke615X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, double, byte, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, double, short, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, double, int, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, double, float, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, double, long, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, double, double, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, double, decimal, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, double, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke614X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, decimal, byte, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, decimal, short, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, decimal, int, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, decimal, float, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, decimal, long, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, decimal, double, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, decimal, decimal, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, decimal, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke617X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, byte, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, short, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, int, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, float, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, long, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, double, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, decimal, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke62XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke620X(code, p, args), 
			'1' => Invoke621X(code, p, args), 
			'2' => Invoke622X(code, p, args), 
			'6' => Invoke626X(code, p, args), 
			'3' => Invoke623X(code, p, args), 
			'5' => Invoke625X(code, p, args), 
			'4' => Invoke624X(code, p, args), 
			'7' => Invoke627X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke620X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, byte, byte, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, byte, short, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, byte, int, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, byte, float, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, byte, long, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, byte, double, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, byte, decimal, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, byte, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke621X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, short, byte, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, short, short, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, short, int, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, short, float, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, short, long, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, short, double, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, short, decimal, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, short, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, int, byte, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, int, short, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, int, float, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, int, long, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, int, double, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, int, decimal, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, float, byte, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, float, short, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, float, int, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, float, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, float, long, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, float, double, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, float, decimal, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, float, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, long, byte, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, long, short, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, long, int, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, long, float, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, long, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, long, double, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, long, decimal, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, long, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, double, byte, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, double, short, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, double, int, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, double, float, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, double, long, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, double, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, double, decimal, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, double, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke624X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, decimal, byte, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, decimal, short, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, decimal, int, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, decimal, float, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, decimal, long, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, decimal, double, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, decimal, decimal, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, decimal, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, byte, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, short, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, float, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, long, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, double, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, decimal, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke66XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke660X(code, p, args), 
			'1' => Invoke661X(code, p, args), 
			'2' => Invoke662X(code, p, args), 
			'6' => Invoke666X(code, p, args), 
			'3' => Invoke663X(code, p, args), 
			'5' => Invoke665X(code, p, args), 
			'4' => Invoke664X(code, p, args), 
			'7' => Invoke667X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke660X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, byte, byte, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, byte, short, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, byte, int, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, byte, float, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, byte, long, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, byte, double, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, byte, decimal, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, byte, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke661X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, short, byte, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, short, short, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, short, int, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, short, float, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, short, long, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, short, double, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, short, decimal, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, short, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, int, byte, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, int, short, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, int, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int, float, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, int, long, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, int, double, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, int, decimal, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, int, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, float, byte, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, float, short, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, float, int, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, float, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, float, long, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, float, double, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, float, decimal, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, long, byte, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, long, short, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, long, int, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, long, float, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, long, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, long, double, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, long, decimal, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, long, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, double, byte, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, double, short, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, double, int, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, double, float, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, double, long, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, double, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, double, decimal, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, double, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke664X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, decimal, byte, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, decimal, short, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, decimal, int, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, decimal, float, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, decimal, long, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, decimal, double, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, decimal, decimal, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, decimal, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, byte, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, short, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, float, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, long, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, double, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, decimal, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke63XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke630X(code, p, args), 
			'1' => Invoke631X(code, p, args), 
			'2' => Invoke632X(code, p, args), 
			'6' => Invoke636X(code, p, args), 
			'3' => Invoke633X(code, p, args), 
			'5' => Invoke635X(code, p, args), 
			'4' => Invoke634X(code, p, args), 
			'7' => Invoke637X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke630X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, byte, byte, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, byte, short, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, byte, int, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, byte, float, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, byte, long, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, byte, double, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, byte, decimal, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, byte, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke631X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, short, byte, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, short, short, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, short, int, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, short, float, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, short, long, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, short, double, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, short, decimal, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, short, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, int, byte, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, int, short, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, int, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, int, float, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int, long, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, int, double, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, int, decimal, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, int, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, float, byte, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, float, short, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, float, int, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, float, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, float, long, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, float, double, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, float, decimal, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, float, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, long, byte, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, long, short, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, long, int, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, long, float, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, long, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, long, double, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, long, decimal, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, double, byte, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, double, short, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, double, int, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, double, float, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, double, long, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, double, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, double, decimal, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, double, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke634X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, decimal, byte, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, decimal, short, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, decimal, int, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, decimal, float, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, decimal, long, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, decimal, double, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, decimal, decimal, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, decimal, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, byte, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, short, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, float, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, long, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, double, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, decimal, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke65XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke650X(code, p, args), 
			'1' => Invoke651X(code, p, args), 
			'2' => Invoke652X(code, p, args), 
			'6' => Invoke656X(code, p, args), 
			'3' => Invoke653X(code, p, args), 
			'5' => Invoke655X(code, p, args), 
			'4' => Invoke654X(code, p, args), 
			'7' => Invoke657X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke650X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, byte, byte, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, byte, short, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, byte, int, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, byte, float, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, byte, long, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, byte, double, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, byte, decimal, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, byte, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke651X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, short, byte, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, short, short, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, short, int, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, short, float, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, short, long, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, short, double, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, short, decimal, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, short, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, int, byte, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, int, short, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, int, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, int, float, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, int, long, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int, double, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, int, decimal, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, int, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, float, byte, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, float, short, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, float, int, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, float, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, float, long, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, float, double, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, float, decimal, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, float, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, long, byte, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, long, short, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, long, int, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, long, float, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, long, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, long, double, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, long, decimal, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, long, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, double, byte, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, double, short, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, double, int, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, double, float, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, double, long, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, double, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, double, decimal, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke654X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, decimal, byte, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, decimal, short, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, decimal, int, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, decimal, float, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, decimal, long, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, decimal, double, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, decimal, decimal, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, decimal, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, byte, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, short, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, float, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, long, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, double, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, decimal, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke64XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke640X(code, p, args), 
			'1' => Invoke641X(code, p, args), 
			'2' => Invoke642X(code, p, args), 
			'6' => Invoke646X(code, p, args), 
			'3' => Invoke643X(code, p, args), 
			'5' => Invoke645X(code, p, args), 
			'4' => Invoke644X(code, p, args), 
			'7' => Invoke647X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke640X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, short, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, int, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, float, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, long, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, double, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke641X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, short, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, short, short, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, short, int, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, short, float, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, short, long, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, short, double, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, short, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, short, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke642X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, int, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, int, short, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, int, int, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, int, float, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, int, long, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, int, double, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, int, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, int, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke646X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, float, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, float, short, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, float, int, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, float, float, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, float, long, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, float, double, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, float, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, float, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke643X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, long, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, long, short, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, long, int, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, long, float, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, long, long, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, long, double, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, long, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, long, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke645X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, double, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, double, short, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, double, int, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, double, float, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, double, long, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, double, double, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, double, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, double, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke644X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, short, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, int, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, float, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, long, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, double, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke647X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, short, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, int, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, float, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, long, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, double, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke67XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke670X(code, p, args), 
			'1' => Invoke671X(code, p, args), 
			'2' => Invoke672X(code, p, args), 
			'6' => Invoke676X(code, p, args), 
			'3' => Invoke673X(code, p, args), 
			'5' => Invoke675X(code, p, args), 
			'4' => Invoke674X(code, p, args), 
			'7' => Invoke677X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke670X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke671X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke674X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}
}
