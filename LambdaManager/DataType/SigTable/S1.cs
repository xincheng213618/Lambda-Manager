using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LambdaManager.DataType.SigTable;

internal class S1
{
	public unsafe static int Invoke(IntPtr p)
	{
		return ((delegate* unmanaged[Cdecl]<int>)(void*)p)();
	}

	public unsafe static int Invoke(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[0] switch
		{
			'0' => ((delegate* unmanaged[Cdecl]<byte, int>)(void*)p)((byte)args![0]), 
			'1' => ((delegate* unmanaged[Cdecl]<short, int>)(void*)p)((short)args![0]), 
			'2' => ((delegate* unmanaged[Cdecl]<int, int>)(void*)p)((int)args![0]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int>)(void*)p)((float)args![0]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int>)(void*)p)((long)args![0]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int>)(void*)p)((double)args![0]), 
			'4' => ((delegate* unmanaged[Cdecl]<decimal, int>)(void*)p)((decimal)args![0]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int>)(void*)p)((IntPtr)args![0]), 
			_ => -1, 
		};
	}
}
