using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S42
{
	public static int Invoke2(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => Invoke20XX(code, p, args), 
			'1' => Invoke21XX(code, p, args), 
			'2' => Invoke22XX(code, p, args), 
			'6' => Invoke26XX(code, p, args), 
			'3' => Invoke23XX(code, p, args), 
			'5' => Invoke25XX(code, p, args), 
			'4' => Invoke24XX(code, p, args), 
			'7' => Invoke27XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke20XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke200X(code, p, args), 
			'1' => Invoke201X(code, p, args), 
			'2' => Invoke202X(code, p, args), 
			'6' => Invoke206X(code, p, args), 
			'3' => Invoke203X(code, p, args), 
			'5' => Invoke205X(code, p, args), 
			'4' => Invoke204X(code, p, args), 
			'7' => Invoke207X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke200X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, byte, byte, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, byte, short, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, byte, int, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, byte, float, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, byte, long, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, byte, double, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, byte, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, byte, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke201X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, short, byte, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, short, short, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, short, int, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, short, float, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, short, long, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, short, double, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, short, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, short, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke202X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, int, byte, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, int, short, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, int, int, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, int, float, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, int, long, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, int, double, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, int, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, int, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke206X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, float, byte, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, float, short, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, float, int, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, float, float, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, float, long, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, float, double, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, float, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, float, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke203X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, long, byte, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, long, short, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, long, int, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, long, float, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, long, long, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, long, double, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, long, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, long, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke205X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, double, byte, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, double, short, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, double, int, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, double, float, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, double, long, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, double, double, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, double, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, double, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke204X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, byte, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, short, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, int, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, float, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, long, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, double, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke207X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, byte, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, short, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, int, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, float, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, long, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, double, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke21XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke210X(code, p, args), 
			'1' => Invoke211X(code, p, args), 
			'2' => Invoke212X(code, p, args), 
			'6' => Invoke216X(code, p, args), 
			'3' => Invoke213X(code, p, args), 
			'5' => Invoke215X(code, p, args), 
			'4' => Invoke214X(code, p, args), 
			'7' => Invoke217X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke210X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, byte, byte, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, byte, short, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, byte, int, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, byte, float, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, byte, long, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, byte, double, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, byte, decimal, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, byte, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke211X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, short, byte, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, short, short, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, short, int, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, short, float, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, short, long, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, short, double, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, short, decimal, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, short, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke212X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, int, byte, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, int, short, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, int, int, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, int, float, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, int, long, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, int, double, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, int, decimal, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, int, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke216X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, float, byte, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, float, short, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, float, int, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, float, float, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, float, long, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, float, double, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, float, decimal, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, float, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke213X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, long, byte, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, long, short, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, long, int, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, long, float, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, long, long, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, long, double, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, long, decimal, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, long, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke215X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, double, byte, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, double, short, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, double, int, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, double, float, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, double, long, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, double, double, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, double, decimal, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, double, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke214X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, decimal, byte, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, decimal, short, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, decimal, int, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, decimal, float, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, decimal, long, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, decimal, double, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, decimal, decimal, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, decimal, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke217X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, byte, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, short, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, int, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, float, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, long, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, double, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, decimal, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke22XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke220X(code, p, args), 
			'1' => Invoke221X(code, p, args), 
			'2' => Invoke222X(code, p, args), 
			'6' => Invoke226X(code, p, args), 
			'3' => Invoke223X(code, p, args), 
			'5' => Invoke225X(code, p, args), 
			'4' => Invoke224X(code, p, args), 
			'7' => Invoke227X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke220X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, byte, byte, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, byte, short, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, byte, int, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, byte, float, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, byte, long, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, byte, double, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, byte, decimal, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, byte, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke221X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, short, byte, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, short, short, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, short, int, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, short, float, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, short, long, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, short, double, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, short, decimal, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, short, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, int, byte, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, int, short, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, int, decimal, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, float, byte, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, float, short, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, float, decimal, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, long, byte, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, long, short, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, long, decimal, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, double, byte, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, double, short, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, double, decimal, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke224X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, decimal, byte, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, decimal, short, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, decimal, int, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, decimal, float, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, decimal, long, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, decimal, double, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, decimal, decimal, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, decimal, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, byte, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, short, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, decimal, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke26XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke260X(code, p, args), 
			'1' => Invoke261X(code, p, args), 
			'2' => Invoke262X(code, p, args), 
			'6' => Invoke266X(code, p, args), 
			'3' => Invoke263X(code, p, args), 
			'5' => Invoke265X(code, p, args), 
			'4' => Invoke264X(code, p, args), 
			'7' => Invoke267X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke260X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, byte, byte, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, byte, short, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, byte, int, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, byte, float, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, byte, long, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, byte, double, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, byte, decimal, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, byte, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke261X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, short, byte, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, short, short, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, short, int, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, short, float, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, short, long, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, short, double, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, short, decimal, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, short, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, int, byte, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, int, short, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, int, decimal, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, float, byte, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, float, short, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, float, decimal, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, long, byte, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, long, short, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, long, decimal, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, double, byte, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, double, short, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, double, decimal, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke264X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, decimal, byte, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, decimal, short, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, decimal, int, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, decimal, float, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, decimal, long, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, decimal, double, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, decimal, decimal, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, decimal, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, byte, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, short, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, decimal, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke23XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke230X(code, p, args), 
			'1' => Invoke231X(code, p, args), 
			'2' => Invoke232X(code, p, args), 
			'6' => Invoke236X(code, p, args), 
			'3' => Invoke233X(code, p, args), 
			'5' => Invoke235X(code, p, args), 
			'4' => Invoke234X(code, p, args), 
			'7' => Invoke237X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke230X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, byte, byte, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, byte, short, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, byte, int, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, byte, float, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, byte, long, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, byte, double, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, byte, decimal, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, byte, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke231X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, short, byte, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, short, short, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, short, int, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, short, float, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, short, long, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, short, double, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, short, decimal, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, short, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, int, byte, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, int, short, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, int, decimal, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, float, byte, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, float, short, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, float, decimal, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, long, byte, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, long, short, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, long, decimal, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, double, byte, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, double, short, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, double, decimal, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke234X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, decimal, byte, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, decimal, short, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, decimal, int, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, decimal, float, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, decimal, long, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, decimal, double, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, decimal, decimal, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, decimal, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, byte, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, short, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, decimal, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke25XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke250X(code, p, args), 
			'1' => Invoke251X(code, p, args), 
			'2' => Invoke252X(code, p, args), 
			'6' => Invoke256X(code, p, args), 
			'3' => Invoke253X(code, p, args), 
			'5' => Invoke255X(code, p, args), 
			'4' => Invoke254X(code, p, args), 
			'7' => Invoke257X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke250X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, byte, byte, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, byte, short, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, byte, int, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, byte, float, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, byte, long, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, byte, double, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, byte, decimal, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, byte, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke251X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, short, byte, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, short, short, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, short, int, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, short, float, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, short, long, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, short, double, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, short, decimal, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, short, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, int, byte, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, int, short, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, int, decimal, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, float, byte, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, float, short, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, float, decimal, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, long, byte, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, long, short, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, long, decimal, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, double, byte, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, double, short, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, double, decimal, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke254X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, decimal, byte, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, decimal, short, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, decimal, int, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, decimal, float, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, decimal, long, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, decimal, double, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, decimal, decimal, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, decimal, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, byte, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, short, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, decimal, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke24XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke240X(code, p, args), 
			'1' => Invoke241X(code, p, args), 
			'2' => Invoke242X(code, p, args), 
			'6' => Invoke246X(code, p, args), 
			'3' => Invoke243X(code, p, args), 
			'5' => Invoke245X(code, p, args), 
			'4' => Invoke244X(code, p, args), 
			'7' => Invoke247X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke240X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, short, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, int, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, float, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, long, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, double, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke241X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, short, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, short, short, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, short, int, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, short, float, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, short, long, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, short, double, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, short, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, short, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke242X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, int, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, int, short, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, int, int, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, int, float, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, int, long, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, int, double, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, int, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, int, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke246X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, float, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, float, short, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, float, int, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, float, float, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, float, long, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, float, double, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, float, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, float, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke243X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, long, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, long, short, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, long, int, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, long, float, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, long, long, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, long, double, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, long, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, long, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke245X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, double, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, double, short, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, double, int, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, double, float, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, double, long, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, double, double, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, double, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, double, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke244X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, short, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, int, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, float, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, long, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, double, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke247X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, short, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, int, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, float, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, long, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, double, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke27XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke270X(code, p, args), 
			'1' => Invoke271X(code, p, args), 
			'2' => Invoke272X(code, p, args), 
			'6' => Invoke276X(code, p, args), 
			'3' => Invoke273X(code, p, args), 
			'5' => Invoke275X(code, p, args), 
			'4' => Invoke274X(code, p, args), 
			'7' => Invoke277X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke270X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke271X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke274X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}
}
