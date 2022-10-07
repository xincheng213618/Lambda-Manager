using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S45
{
	public static int Invoke5(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => Invoke50XX(code, p, args), 
			'1' => Invoke51XX(code, p, args), 
			'2' => Invoke52XX(code, p, args), 
			'6' => Invoke56XX(code, p, args), 
			'3' => Invoke53XX(code, p, args), 
			'5' => Invoke55XX(code, p, args), 
			'4' => Invoke54XX(code, p, args), 
			'7' => Invoke57XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke50XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke500X(code, p, args), 
			'1' => Invoke501X(code, p, args), 
			'2' => Invoke502X(code, p, args), 
			'6' => Invoke506X(code, p, args), 
			'3' => Invoke503X(code, p, args), 
			'5' => Invoke505X(code, p, args), 
			'4' => Invoke504X(code, p, args), 
			'7' => Invoke507X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke500X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, byte, byte, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, byte, short, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, byte, int, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, byte, float, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, byte, long, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, byte, double, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, byte, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, byte, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke501X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, short, byte, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, short, short, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, short, int, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, short, float, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, short, long, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, short, double, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, short, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, short, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke502X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, int, byte, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, int, short, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, int, int, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, int, float, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, int, long, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, int, double, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, int, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, int, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke506X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, float, byte, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, float, short, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, float, int, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, float, float, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, float, long, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, float, double, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, float, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, float, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke503X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, long, byte, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, long, short, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, long, int, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, long, float, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, long, long, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, long, double, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, long, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, long, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke505X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, double, byte, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, double, short, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, double, int, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, double, float, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, double, long, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, double, double, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, double, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, double, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke504X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, byte, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, short, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, int, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, float, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, long, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, double, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke507X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, byte, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, short, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, int, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, float, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, long, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, double, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke51XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke510X(code, p, args), 
			'1' => Invoke511X(code, p, args), 
			'2' => Invoke512X(code, p, args), 
			'6' => Invoke516X(code, p, args), 
			'3' => Invoke513X(code, p, args), 
			'5' => Invoke515X(code, p, args), 
			'4' => Invoke514X(code, p, args), 
			'7' => Invoke517X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke510X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, byte, byte, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, byte, short, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, byte, int, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, byte, float, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, byte, long, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, byte, double, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, byte, decimal, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, byte, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke511X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, short, byte, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, short, short, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, short, int, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, short, float, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, short, long, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, short, double, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, short, decimal, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, short, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke512X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, int, byte, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, int, short, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, int, int, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, int, float, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, int, long, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, int, double, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, int, decimal, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, int, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke516X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, float, byte, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, float, short, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, float, int, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, float, float, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, float, long, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, float, double, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, float, decimal, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, float, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke513X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, long, byte, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, long, short, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, long, int, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, long, float, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, long, long, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, long, double, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, long, decimal, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, long, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke515X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, double, byte, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, double, short, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, double, int, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, double, float, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, double, long, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, double, double, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, double, decimal, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, double, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke514X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, decimal, byte, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, decimal, short, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, decimal, int, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, decimal, float, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, decimal, long, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, decimal, double, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, decimal, decimal, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, decimal, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke517X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, byte, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, short, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, int, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, float, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, long, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, double, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, decimal, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke52XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke520X(code, p, args), 
			'1' => Invoke521X(code, p, args), 
			'2' => Invoke522X(code, p, args), 
			'6' => Invoke526X(code, p, args), 
			'3' => Invoke523X(code, p, args), 
			'5' => Invoke525X(code, p, args), 
			'4' => Invoke524X(code, p, args), 
			'7' => Invoke527X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke520X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, byte, byte, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, byte, short, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, byte, int, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, byte, float, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, byte, long, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, byte, double, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, byte, decimal, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, byte, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke521X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, short, byte, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, short, short, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, short, int, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, short, float, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, short, long, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, short, double, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, short, decimal, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, short, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, int, byte, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, int, short, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, int, decimal, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, float, byte, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, float, short, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, float, decimal, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, long, byte, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, long, short, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, long, decimal, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, double, byte, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, double, short, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, double, decimal, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke524X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, decimal, byte, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, decimal, short, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, decimal, int, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, decimal, float, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, decimal, long, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, decimal, double, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, decimal, decimal, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, decimal, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, byte, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, short, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, decimal, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke56XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke560X(code, p, args), 
			'1' => Invoke561X(code, p, args), 
			'2' => Invoke562X(code, p, args), 
			'6' => Invoke566X(code, p, args), 
			'3' => Invoke563X(code, p, args), 
			'5' => Invoke565X(code, p, args), 
			'4' => Invoke564X(code, p, args), 
			'7' => Invoke567X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke560X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, byte, byte, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, byte, short, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, byte, int, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, byte, float, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, byte, long, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, byte, double, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, byte, decimal, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, byte, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke561X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, short, byte, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, short, short, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, short, int, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, short, float, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, short, long, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, short, double, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, short, decimal, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, short, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, int, byte, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, int, short, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, int, decimal, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, float, byte, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, float, short, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, float, decimal, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, long, byte, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, long, short, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, long, decimal, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, double, byte, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, double, short, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, double, decimal, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke564X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, decimal, byte, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, decimal, short, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, decimal, int, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, decimal, float, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, decimal, long, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, decimal, double, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, decimal, decimal, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, decimal, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, byte, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, short, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, decimal, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke53XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke530X(code, p, args), 
			'1' => Invoke531X(code, p, args), 
			'2' => Invoke532X(code, p, args), 
			'6' => Invoke536X(code, p, args), 
			'3' => Invoke533X(code, p, args), 
			'5' => Invoke535X(code, p, args), 
			'4' => Invoke534X(code, p, args), 
			'7' => Invoke537X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke530X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, byte, byte, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, byte, short, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, byte, int, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, byte, float, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, byte, long, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, byte, double, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, byte, decimal, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, byte, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke531X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, short, byte, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, short, short, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, short, int, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, short, float, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, short, long, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, short, double, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, short, decimal, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, short, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, int, byte, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, int, short, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, int, decimal, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, float, byte, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, float, short, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, float, decimal, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, long, byte, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, long, short, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, long, decimal, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, double, byte, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, double, short, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, double, decimal, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke534X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, decimal, byte, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, decimal, short, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, decimal, int, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, decimal, float, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, decimal, long, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, decimal, double, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, decimal, decimal, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, decimal, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, byte, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, short, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, decimal, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke55XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke550X(code, p, args), 
			'1' => Invoke551X(code, p, args), 
			'2' => Invoke552X(code, p, args), 
			'6' => Invoke556X(code, p, args), 
			'3' => Invoke553X(code, p, args), 
			'5' => Invoke555X(code, p, args), 
			'4' => Invoke554X(code, p, args), 
			'7' => Invoke557X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke550X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, byte, byte, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, byte, short, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, byte, int, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, byte, float, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, byte, long, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, byte, double, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, byte, decimal, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, byte, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke551X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, short, byte, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, short, short, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, short, int, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, short, float, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, short, long, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, short, double, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, short, decimal, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, short, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, int, byte, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, int, short, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, int, decimal, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, float, byte, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, float, short, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, float, decimal, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, long, byte, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, long, short, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, long, decimal, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, double, byte, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, double, short, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, double, decimal, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke554X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, decimal, byte, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, decimal, short, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, decimal, int, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, decimal, float, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, decimal, long, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, decimal, double, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, decimal, decimal, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, decimal, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, byte, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, short, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, decimal, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke54XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke540X(code, p, args), 
			'1' => Invoke541X(code, p, args), 
			'2' => Invoke542X(code, p, args), 
			'6' => Invoke546X(code, p, args), 
			'3' => Invoke543X(code, p, args), 
			'5' => Invoke545X(code, p, args), 
			'4' => Invoke544X(code, p, args), 
			'7' => Invoke547X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke540X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, short, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, int, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, float, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, long, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, double, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke541X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, short, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, short, short, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, short, int, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, short, float, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, short, long, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, short, double, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, short, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, short, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke542X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, int, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, int, short, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, int, int, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, int, float, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, int, long, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, int, double, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, int, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, int, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke546X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, float, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, float, short, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, float, int, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, float, float, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, float, long, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, float, double, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, float, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, float, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke543X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, long, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, long, short, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, long, int, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, long, float, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, long, long, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, long, double, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, long, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, long, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke545X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, double, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, double, short, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, double, int, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, double, float, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, double, long, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, double, double, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, double, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, double, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke544X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, short, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, int, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, float, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, long, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, double, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke547X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, short, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, int, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, float, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, long, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, double, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke57XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke570X(code, p, args), 
			'1' => Invoke571X(code, p, args), 
			'2' => Invoke572X(code, p, args), 
			'6' => Invoke576X(code, p, args), 
			'3' => Invoke573X(code, p, args), 
			'5' => Invoke575X(code, p, args), 
			'4' => Invoke574X(code, p, args), 
			'7' => Invoke577X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke570X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke571X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke574X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}
}
