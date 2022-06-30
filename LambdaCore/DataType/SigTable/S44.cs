using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S44
{
	public static int Invoke4(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => Invoke40XX(code, p, args), 
			'1' => Invoke41XX(code, p, args), 
			'2' => Invoke42XX(code, p, args), 
			'6' => Invoke46XX(code, p, args), 
			'3' => Invoke43XX(code, p, args), 
			'5' => Invoke45XX(code, p, args), 
			'4' => Invoke44XX(code, p, args), 
			'7' => Invoke47XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke40XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke400X(code, p, args), 
			'1' => Invoke401X(code, p, args), 
			'2' => Invoke402X(code, p, args), 
			'6' => Invoke406X(code, p, args), 
			'3' => Invoke403X(code, p, args), 
			'5' => Invoke405X(code, p, args), 
			'4' => Invoke404X(code, p, args), 
			'7' => Invoke407X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke400X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke401X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke402X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke406X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke403X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke405X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke404X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke407X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke41XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke410X(code, p, args), 
			'1' => Invoke411X(code, p, args), 
			'2' => Invoke412X(code, p, args), 
			'6' => Invoke416X(code, p, args), 
			'3' => Invoke413X(code, p, args), 
			'5' => Invoke415X(code, p, args), 
			'4' => Invoke414X(code, p, args), 
			'7' => Invoke417X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke410X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, short, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, int, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, float, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, long, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, double, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke411X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, short, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, short, short, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, short, int, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, short, float, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, short, long, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, short, double, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, short, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, short, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke412X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, int, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, int, short, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, int, int, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, int, float, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, int, long, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, int, double, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, int, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, int, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke416X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, float, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, float, short, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, float, int, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, float, float, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, float, long, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, float, double, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, float, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, float, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke413X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, long, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, long, short, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, long, int, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, long, float, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, long, long, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, long, double, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, long, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, long, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke415X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, double, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, double, short, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, double, int, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, double, float, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, double, long, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, double, double, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, double, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, double, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke414X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, short, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, int, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, float, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, long, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, double, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke417X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, short, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, int, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, float, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, long, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, double, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke42XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke420X(code, p, args), 
			'1' => Invoke421X(code, p, args), 
			'2' => Invoke422X(code, p, args), 
			'6' => Invoke426X(code, p, args), 
			'3' => Invoke423X(code, p, args), 
			'5' => Invoke425X(code, p, args), 
			'4' => Invoke424X(code, p, args), 
			'7' => Invoke427X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke420X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, short, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, int, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, float, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, long, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, double, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke421X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, short, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, short, short, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, short, int, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, short, float, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, short, long, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, short, double, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, short, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, short, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke422X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, int, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, int, short, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, int, int, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, int, float, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, int, long, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, int, double, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, int, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, int, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke426X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, float, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, float, short, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, float, int, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, float, float, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, float, long, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, float, double, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, float, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, float, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke423X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, long, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, long, short, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, long, int, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, long, float, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, long, long, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, long, double, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, long, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, long, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke425X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, double, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, double, short, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, double, int, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, double, float, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, double, long, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, double, double, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, double, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, double, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke424X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, short, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, int, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, float, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, long, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, double, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke427X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, short, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, int, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, float, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, long, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, double, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke46XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke460X(code, p, args), 
			'1' => Invoke461X(code, p, args), 
			'2' => Invoke462X(code, p, args), 
			'6' => Invoke466X(code, p, args), 
			'3' => Invoke463X(code, p, args), 
			'5' => Invoke465X(code, p, args), 
			'4' => Invoke464X(code, p, args), 
			'7' => Invoke467X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke460X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, short, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, int, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, float, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, long, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, double, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke461X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, short, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, short, short, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, short, int, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, short, float, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, short, long, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, short, double, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, short, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, short, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke462X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, int, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, int, short, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, int, int, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, int, float, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, int, long, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, int, double, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, int, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, int, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke466X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, float, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, float, short, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, float, int, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, float, float, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, float, long, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, float, double, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, float, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, float, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke463X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, long, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, long, short, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, long, int, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, long, float, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, long, long, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, long, double, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, long, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, long, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke465X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, double, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, double, short, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, double, int, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, double, float, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, double, long, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, double, double, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, double, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, double, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke464X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, short, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, int, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, float, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, long, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, double, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke467X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, short, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, int, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, float, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, long, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, double, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke43XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke430X(code, p, args), 
			'1' => Invoke431X(code, p, args), 
			'2' => Invoke432X(code, p, args), 
			'6' => Invoke436X(code, p, args), 
			'3' => Invoke433X(code, p, args), 
			'5' => Invoke435X(code, p, args), 
			'4' => Invoke434X(code, p, args), 
			'7' => Invoke437X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke430X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, short, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, int, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, float, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, long, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, double, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke431X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, short, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, short, short, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, short, int, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, short, float, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, short, long, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, short, double, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, short, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, short, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke432X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, int, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, int, short, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, int, int, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, int, float, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, int, long, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, int, double, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, int, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, int, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke436X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, float, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, float, short, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, float, int, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, float, float, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, float, long, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, float, double, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, float, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, float, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke433X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, long, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, long, short, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, long, int, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, long, float, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, long, long, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, long, double, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, long, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, long, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke435X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, double, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, double, short, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, double, int, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, double, float, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, double, long, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, double, double, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, double, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, double, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke434X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, short, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, int, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, float, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, long, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, double, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke437X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, short, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, int, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, float, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, long, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, double, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke45XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke450X(code, p, args), 
			'1' => Invoke451X(code, p, args), 
			'2' => Invoke452X(code, p, args), 
			'6' => Invoke456X(code, p, args), 
			'3' => Invoke453X(code, p, args), 
			'5' => Invoke455X(code, p, args), 
			'4' => Invoke454X(code, p, args), 
			'7' => Invoke457X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke450X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, short, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, int, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, float, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, long, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, double, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke451X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, short, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, short, short, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, short, int, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, short, float, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, short, long, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, short, double, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, short, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, short, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke452X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, int, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, int, short, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, int, int, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, int, float, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, int, long, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, int, double, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, int, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, int, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke456X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, float, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, float, short, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, float, int, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, float, float, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, float, long, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, float, double, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, float, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, float, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke453X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, long, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, long, short, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, long, int, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, long, float, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, long, long, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, long, double, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, long, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, long, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke455X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, double, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, double, short, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, double, int, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, double, float, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, double, long, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, double, double, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, double, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, double, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke454X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, short, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, int, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, float, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, long, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, double, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke457X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, short, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, int, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, float, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, long, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, double, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke44XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke440X(code, p, args), 
			'1' => Invoke441X(code, p, args), 
			'2' => Invoke442X(code, p, args), 
			'6' => Invoke446X(code, p, args), 
			'3' => Invoke443X(code, p, args), 
			'5' => Invoke445X(code, p, args), 
			'4' => Invoke444X(code, p, args), 
			'7' => Invoke447X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke440X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke441X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke442X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke446X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke443X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke445X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke444X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke447X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke47XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke470X(code, p, args), 
			'1' => Invoke471X(code, p, args), 
			'2' => Invoke472X(code, p, args), 
			'6' => Invoke476X(code, p, args), 
			'3' => Invoke473X(code, p, args), 
			'5' => Invoke475X(code, p, args), 
			'4' => Invoke474X(code, p, args), 
			'7' => Invoke477X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke470X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke471X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke472X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke476X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke473X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke475X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke474X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke477X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}
}
