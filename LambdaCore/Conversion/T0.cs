using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LambdaManager.Core;

namespace LambdaManager.Conversion;

internal class T0
{
	public static nint ToAddress(TypeInfo? typeInfo, object value)
	{
		IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(value));
		Marshal.StructureToPtr(value, p, fDeleteOld: true);
		return p;
	}

	public static void ClearAddress(object? alloctions)
	{
		if (alloctions == null)
		{
			return;
		}
		foreach (IntPtr item in (List<IntPtr>)alloctions)
		{
			Marshal.FreeHGlobal(item);
		}
	}

	public unsafe static void ClearAddress(object? alloctions, List<object?>? args)
	{
		if (alloctions != null && args != null)
		{
			List<IntPtr> list = (List<IntPtr>)alloctions;
			for (int i = list.Count - 1; i >= 0; i--)
			{
				IntPtr p = list[i];
				args![args!.Count - 1 - i] = *(IntPtr*)(void*)p;
				Marshal.FreeHGlobal(p);
			}
		}
	}

	public unsafe static int GetArraySize(object? pointerOrArray)
	{
		if (pointerOrArray == null)
		{
			return 0;
		}
		IntPtr p = ((!(pointerOrArray is Array array)) ? ((IntPtr)pointerOrArray) : Marshal.UnsafeAddrOfPinnedArrayElement(array, 0));
		return (int)(*(long*)((byte*)(void*)p - 8));
	}

	public unsafe static object ToValue(TypeInfo info, object address)
	{
		void* ptr = (void*)(IntPtr)address;
		switch (info.Id)
		{
		case 10:
		case 11:
			return *(bool*)ptr;
		case 12:
			return *(int*)ptr;
		case 13:
		case 14:
		case 22:
			return *(byte*)ptr;
		case 17:
		case 18:
		case 21:
			return *(sbyte*)ptr;
		case 20:
			return *(char*)ptr;
		case 23:
		case 24:
		case 25:
			return *(short*)ptr;
		case 27:
		case 28:
			return *(ushort*)ptr;
		case 30:
		case 31:
		case 32:
			return *(int*)ptr;
		case 35:
		case 36:
			return *(uint*)ptr;
		case 40:
		case 42:
		case 61:
			return *(long*)ptr;
		case 41:
		case 60:
			if (info.Size == 4)
			{
				return *(int*)ptr;
			}
			return *(long*)ptr;
		case 45:
			return *(ulong*)ptr;
		case 46:
			if (info.Size == 4)
			{
				return *(uint*)ptr;
			}
			return *(ulong*)ptr;
		case 50:
		case 51:
			return *(float*)ptr;
		case 55:
		case 56:
			return *(double*)ptr;
		case 62:
			if (info.Size == 8)
			{
				return *(double*)ptr;
			}
			return *(decimal*)ptr;
		case 65:
		case 66:
		case 67:
			return *(decimal*)ptr;
		case 71:
			return *(IntPtr*)ptr;
		case 73:
		case 74:
		{
			sbyte* c1 = (sbyte*)ptr;
			return new string(c1);
		}
		case 75:
		case 76:
		{
			char* c2 = (char*)ptr;
			return new string(c2);
		}
		case 77:
		case 78:
		{
			char* c3 = (char*)ptr;
			return new string(c3);
		}
		case 91:
		case 92:
			return *(int*)ptr;
		default:
			throw new Exception("error: get value of void pointer is not allowed");
		}
	}
}
