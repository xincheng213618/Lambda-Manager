using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S47
{
	public static int Invoke7(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'0' => Invoke70XX(code, p, args), 
			'1' => Invoke71XX(code, p, args), 
			'2' => Invoke72XX(code, p, args), 
			'6' => Invoke76XX(code, p, args), 
			'3' => Invoke73XX(code, p, args), 
			'5' => Invoke75XX(code, p, args), 
			'4' => Invoke74XX(code, p, args), 
			'7' => Invoke77XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke70XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke700X(code, p, args), 
			'1' => Invoke701X(code, p, args), 
			'2' => Invoke702X(code, p, args), 
			'6' => Invoke706X(code, p, args), 
			'3' => Invoke703X(code, p, args), 
			'5' => Invoke705X(code, p, args), 
			'4' => Invoke704X(code, p, args), 
			'7' => Invoke707X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke700X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke701X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke702X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke706X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke703X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke705X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke704X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke707X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke71XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke710X(code, p, args), 
			'1' => Invoke711X(code, p, args), 
			'2' => Invoke712X(code, p, args), 
			'6' => Invoke716X(code, p, args), 
			'3' => Invoke713X(code, p, args), 
			'5' => Invoke715X(code, p, args), 
			'4' => Invoke714X(code, p, args), 
			'7' => Invoke717X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke710X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke711X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke712X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke716X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke713X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke715X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke714X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke717X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke72XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke720X(code, p, args), 
			'1' => Invoke721X(code, p, args), 
			'2' => Invoke722X(code, p, args), 
			'6' => Invoke726X(code, p, args), 
			'3' => Invoke723X(code, p, args), 
			'5' => Invoke725X(code, p, args), 
			'4' => Invoke724X(code, p, args), 
			'7' => Invoke727X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke720X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke721X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke724X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke76XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke760X(code, p, args), 
			'1' => Invoke761X(code, p, args), 
			'2' => Invoke762X(code, p, args), 
			'6' => Invoke766X(code, p, args), 
			'3' => Invoke763X(code, p, args), 
			'5' => Invoke765X(code, p, args), 
			'4' => Invoke764X(code, p, args), 
			'7' => Invoke767X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke760X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke761X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke764X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke73XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke730X(code, p, args), 
			'1' => Invoke731X(code, p, args), 
			'2' => Invoke732X(code, p, args), 
			'6' => Invoke736X(code, p, args), 
			'3' => Invoke733X(code, p, args), 
			'5' => Invoke735X(code, p, args), 
			'4' => Invoke734X(code, p, args), 
			'7' => Invoke737X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke730X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke731X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke734X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke75XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke750X(code, p, args), 
			'1' => Invoke751X(code, p, args), 
			'2' => Invoke752X(code, p, args), 
			'6' => Invoke756X(code, p, args), 
			'3' => Invoke753X(code, p, args), 
			'5' => Invoke755X(code, p, args), 
			'4' => Invoke754X(code, p, args), 
			'7' => Invoke757X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke750X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke751X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke754X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke74XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke740X(code, p, args), 
			'1' => Invoke741X(code, p, args), 
			'2' => Invoke742X(code, p, args), 
			'6' => Invoke746X(code, p, args), 
			'3' => Invoke743X(code, p, args), 
			'5' => Invoke745X(code, p, args), 
			'4' => Invoke744X(code, p, args), 
			'7' => Invoke747X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke740X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke741X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke742X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke746X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke743X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke745X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke744X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke747X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private static int Invoke77XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'0' => Invoke770X(code, p, args), 
			'1' => Invoke771X(code, p, args), 
			'2' => Invoke772X(code, p, args), 
			'6' => Invoke776X(code, p, args), 
			'3' => Invoke773X(code, p, args), 
			'5' => Invoke775X(code, p, args), 
			'4' => Invoke774X(code, p, args), 
			'7' => Invoke777X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke770X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke771X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke774X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (byte)args![3]), 
			'1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (short)args![3]), 
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3]), 
			'4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (decimal)args![3]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3]), 
			_ => -1, 
		};
	}
}
