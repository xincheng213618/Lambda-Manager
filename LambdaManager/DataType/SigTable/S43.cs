using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S43
{
	public static int Invoke3(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => Invoke30XX(code, p, args), 
			'1' => Invoke31XX(code, p, args), 
			'2' => Invoke32XX(code, p, args), 
			'6' => Invoke36XX(code, p, args), 
			'3' => Invoke33XX(code, p, args), 
			'5' => Invoke35XX(code, p, args), 
			'4' => Invoke34XX(code, p, args), 
			'7' => Invoke37XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke30XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke300X(code, p, args), 
			'1' => Invoke301X(code, p, args), 
			'2' => Invoke302X(code, p, args), 
			'6' => Invoke306X(code, p, args), 
			'3' => Invoke303X(code, p, args), 
			'5' => Invoke305X(code, p, args), 
			'4' => Invoke304X(code, p, args), 
			'7' => Invoke307X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke300X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, byte, byte, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, byte, short, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, byte, int, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, byte, float, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, byte, long, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, byte, double, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, byte, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, byte, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke301X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, short, byte, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, short, short, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, short, int, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, short, float, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, short, long, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, short, double, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, short, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, short, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke302X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, int, byte, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, int, short, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, int, int, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, int, float, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, int, long, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, int, double, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, int, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, int, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke306X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, float, byte, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, float, short, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, float, int, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, float, float, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, float, long, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, float, double, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, float, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, float, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke303X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, long, byte, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, long, short, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, long, int, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, long, float, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, long, long, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, long, double, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, long, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, long, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke305X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, double, byte, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, double, short, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, double, int, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, double, float, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, double, long, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, double, double, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, double, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, double, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke304X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, byte, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, short, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, int, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, float, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, long, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, double, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke307X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, byte, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, short, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, int, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, float, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, long, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, double, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke31XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke310X(code, p, args), 
			'1' => Invoke311X(code, p, args), 
			'2' => Invoke312X(code, p, args), 
			'6' => Invoke316X(code, p, args), 
			'3' => Invoke313X(code, p, args), 
			'5' => Invoke315X(code, p, args), 
			'4' => Invoke314X(code, p, args), 
			'7' => Invoke317X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke310X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, byte, byte, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, byte, short, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, byte, int, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, byte, float, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, byte, long, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, byte, double, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, byte, decimal, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, byte, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke311X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, short, byte, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, short, short, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, short, int, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, short, float, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, short, long, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, short, double, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, short, decimal, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, short, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke312X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, int, byte, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, int, short, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, int, int, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, int, float, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, int, long, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, int, double, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, int, decimal, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, int, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke316X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, float, byte, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, float, short, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, float, int, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, float, float, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, float, long, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, float, double, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, float, decimal, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, float, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke313X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, long, byte, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, long, short, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, long, int, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, long, float, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, long, long, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, long, double, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, long, decimal, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, long, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke315X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, double, byte, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, double, short, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, double, int, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, double, float, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, double, long, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, double, double, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, double, decimal, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, double, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke314X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, decimal, byte, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, decimal, short, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, decimal, int, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, decimal, float, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, decimal, long, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, decimal, double, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, decimal, decimal, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, decimal, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke317X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, byte, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, short, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, int, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, float, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, long, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, double, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, decimal, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke32XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke320X(code, p, args), 
			'1' => Invoke321X(code, p, args), 
			'2' => Invoke322X(code, p, args), 
			'6' => Invoke326X(code, p, args), 
			'3' => Invoke323X(code, p, args), 
			'5' => Invoke325X(code, p, args), 
			'4' => Invoke324X(code, p, args), 
			'7' => Invoke327X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke320X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, byte, byte, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, byte, short, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, byte, int, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, byte, float, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, byte, long, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, byte, double, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, byte, decimal, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, byte, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke321X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, short, byte, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, short, short, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, short, int, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, short, float, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, short, long, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, short, double, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, short, decimal, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, short, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, int, byte, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, int, short, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, int, decimal, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, float, byte, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, float, short, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, float, decimal, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, long, byte, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, long, short, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, long, decimal, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, double, byte, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, double, short, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, double, decimal, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke324X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, decimal, byte, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, decimal, short, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, decimal, int, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, decimal, float, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, decimal, long, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, decimal, double, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, decimal, decimal, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, decimal, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, byte, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, short, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, decimal, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke36XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke360X(code, p, args), 
			'1' => Invoke361X(code, p, args), 
			'2' => Invoke362X(code, p, args), 
			'6' => Invoke366X(code, p, args), 
			'3' => Invoke363X(code, p, args), 
			'5' => Invoke365X(code, p, args), 
			'4' => Invoke364X(code, p, args), 
			'7' => Invoke367X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke360X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, byte, byte, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, byte, short, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, byte, int, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, byte, float, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, byte, long, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, byte, double, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, byte, decimal, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, byte, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke361X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, short, byte, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, short, short, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, short, int, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, short, float, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, short, long, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, short, double, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, short, decimal, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, short, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, int, byte, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, int, short, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, int, decimal, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, float, byte, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, float, short, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, float, decimal, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, long, byte, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, long, short, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, long, decimal, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, double, byte, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, double, short, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, double, decimal, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke364X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, decimal, byte, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, decimal, short, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, decimal, int, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, decimal, float, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, decimal, long, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, decimal, double, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, decimal, decimal, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, decimal, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, byte, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, short, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, decimal, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke33XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke330X(code, p, args), 
			'1' => Invoke331X(code, p, args), 
			'2' => Invoke332X(code, p, args), 
			'6' => Invoke336X(code, p, args), 
			'3' => Invoke333X(code, p, args), 
			'5' => Invoke335X(code, p, args), 
			'4' => Invoke334X(code, p, args), 
			'7' => Invoke337X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke330X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, byte, byte, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, byte, short, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, byte, int, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, byte, float, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, byte, long, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, byte, double, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, byte, decimal, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, byte, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke331X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, short, byte, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, short, short, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, short, int, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, short, float, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, short, long, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, short, double, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, short, decimal, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, short, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, int, byte, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, int, short, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, int, decimal, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, float, byte, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, float, short, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, float, decimal, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, long, byte, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, long, short, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, long, decimal, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, double, byte, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, double, short, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, double, decimal, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke334X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, decimal, byte, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, decimal, short, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, decimal, int, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, decimal, float, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, decimal, long, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, decimal, double, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, decimal, decimal, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, decimal, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, byte, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, short, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, decimal, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke35XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke350X(code, p, args), 
			'1' => Invoke351X(code, p, args), 
			'2' => Invoke352X(code, p, args), 
			'6' => Invoke356X(code, p, args), 
			'3' => Invoke353X(code, p, args), 
			'5' => Invoke355X(code, p, args), 
			'4' => Invoke354X(code, p, args), 
			'7' => Invoke357X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke350X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, byte, byte, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, byte, short, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, byte, int, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, byte, float, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, byte, long, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, byte, double, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, byte, decimal, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, byte, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke351X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, short, byte, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, short, short, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, short, int, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, short, float, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, short, long, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, short, double, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, short, decimal, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, short, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, int, byte, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, int, short, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, int, decimal, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, float, byte, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, float, short, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, float, decimal, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, long, byte, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, long, short, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, long, decimal, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, double, byte, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, double, short, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, double, decimal, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke354X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, decimal, byte, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, decimal, short, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, decimal, int, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, decimal, float, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, decimal, long, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, decimal, double, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, decimal, decimal, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, decimal, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, byte, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, short, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, decimal, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke34XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke340X(code, p, args), 
			'1' => Invoke341X(code, p, args), 
			'2' => Invoke342X(code, p, args), 
			'6' => Invoke346X(code, p, args), 
			'3' => Invoke343X(code, p, args), 
			'5' => Invoke345X(code, p, args), 
			'4' => Invoke344X(code, p, args), 
			'7' => Invoke347X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke340X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, short, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, int, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, float, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, long, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, double, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke341X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, short, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, short, short, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, short, int, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, short, float, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, short, long, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, short, double, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, short, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, short, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke342X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, int, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, int, short, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, int, int, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, int, float, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, int, long, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, int, double, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, int, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, int, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke346X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, float, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, float, short, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, float, int, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, float, float, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, float, long, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, float, double, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, float, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, float, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke343X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, long, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, long, short, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, long, int, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, long, float, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, long, long, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, long, double, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, long, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, long, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke345X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, double, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, double, short, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, double, int, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, double, float, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, double, long, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, double, double, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, double, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, double, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke344X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, short, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, int, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, float, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, long, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, double, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke347X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, short, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, int, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, float, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, long, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, double, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke37XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke370X(code, p, args), 
			'1' => Invoke371X(code, p, args), 
			'2' => Invoke372X(code, p, args), 
			'6' => Invoke376X(code, p, args), 
			'3' => Invoke373X(code, p, args), 
			'5' => Invoke375X(code, p, args), 
			'4' => Invoke374X(code, p, args), 
			'7' => Invoke377X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke370X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke371X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke374X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}
}
