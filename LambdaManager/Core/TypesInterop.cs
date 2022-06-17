using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LambdaManager.Core;

internal class TypesInterop
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private struct Empty
	{
	}

	private static readonly int size_ptr = Marshal.SizeOf(typeof(IntPtr));

    private static readonly Dictionary<string, TypeInfo> valueTypes = new Dictionary<string, TypeInfo>
    {
        {
            "#bool",
            new TypeInfo
            {
                Id = 10,
                Size = 1
            }
        },
        {
            "bool",
            new TypeInfo
            {
                Id = 11,
                Size = 1
            }
        },
        {
            "BOOL",
            new TypeInfo
            {
                Id = 12,
                Size = Marshal.SizeOf(typeof(bool))
            }
        },
        {
            "#byte",
            new TypeInfo
            {
                Id = 13,
                Size = 1
            }
        },
        {
            "BYTE",
            new TypeInfo
            {
                Id = 14,
                Size = Marshal.SizeOf(typeof(byte))
            }
        },
        {
            "#sbyte",
            new TypeInfo
            {
                Id = 17,
                Size = 1
            }
        },
        {
            "SBYTE",
            new TypeInfo
            {
                Id = 18,
                Size = Marshal.SizeOf(typeof(sbyte))
            }
        },
        {
            "#char",
            new TypeInfo
            {
                Id = 20,
                Size = 2
            }
        },
        {
            "char",
            new TypeInfo
            {
                Id = 21,
                Size = Marshal.SizeOf(typeof(char))
            }
        },
        {
            "unsigned char",
            new TypeInfo
            {
                Id = 22,
                Size = Marshal.SizeOf(typeof(char))
            }
        },
        {
            "#short",
            new TypeInfo
            {
                Id = 23,
                Size = 2
            }
        },
        {
            "SHORT",
            new TypeInfo
            {
                Id = 24,
                Size = Marshal.SizeOf(typeof(short))
            }
        },
        {
            "INT16",
            new TypeInfo
            {
                Id = 25,
                Size = 2
            }
        },
        {
            "#ushort",
            new TypeInfo
            {
                Id = 27,
                Size = 2
            }
        },
        {
            "USHORT",
            new TypeInfo
            {
                Id = 28,
                Size = Marshal.SizeOf(typeof(ushort))
            }
        },
        {
            "#int",
            new TypeInfo
            {
                Id = 30,
                Size = 4
            }
        },
        {
            "int",
            new TypeInfo
            {
                Id = 31,
                Size = Marshal.SizeOf(typeof(int))
            }
        },
        {
            "INT32",
            new TypeInfo
            {
                Id = 32,
                Size = 4
            }
        },
        {
            "size",
            new TypeInfo
            {
                Id = 33,
                Size = Marshal.SizeOf(typeof(int))
            }
        },
        {
            "#uint",
            new TypeInfo
            {
                Id = 35,
                Size = 4
            }
        },
        {
            "unsigned int",
            new TypeInfo
            {
                Id = 36,
                Size = Marshal.SizeOf(typeof(uint))
            }
        },
        {
            "#long",
            new TypeInfo
            {
                Id = 40,
                Size = 8
            }
        },
        {
            "long",
            new TypeInfo
            {
                Id = 41,
               Size = 8
            }
        },
        {
            "INT64",
            new TypeInfo
            {
                Id = 42,
                Size = 8
            }
        },
        {
            "#ulong",
            new TypeInfo
            {
                Id = 45,
                Size = 8
            }
        },
        {
            "unsigned long",
            new TypeInfo
            {
                Id = 46,
                Size = 8
            }
        },
        {
            "#float",
            new TypeInfo
            {
                Id = 50,
                Size = 4
            }
        },
        {
            "float",
            new TypeInfo
            {
                Id = 51,
                Size = Marshal.SizeOf(typeof(float))
            }
        },
        {
            "#double",
            new TypeInfo
            {
                Id = 55,
                Size = 8
            }
        },
        {
            "double",
            new TypeInfo
            {
                Id = 56,
                Size = Marshal.SizeOf(typeof(double))
            }
        },
        {
            "long int",
            new TypeInfo
            {
                Id = 60,
                 Size = 8
            }
        },
        {
            "long long",
            new TypeInfo
            {
                Id = 61,
                Size = Marshal.SizeOf(typeof(long))
            }
        },
        {
            "long double",
            new TypeInfo
            {
                Id = 62,
                Size = 8
            }
        },
        {
            "#decimal",
            new TypeInfo
            {
                Id = 65,
                Size = 16
            }
        },
        {
            "DECIMAL",
            new TypeInfo
            {
                Id = 66,
                Size = Marshal.SizeOf(typeof(decimal))
            }
        },
        {
            "INT128",
            new TypeInfo
            {
                Id = 67,
                Size = 16
            }
        }
    };

    private static readonly Dictionary<string, TypeInfo> referenceTypes = new Dictionary<string, TypeInfo>
    {
        {
            "#string",
            new TypeInfo
            {
                Id = 70,
                Size = size_ptr
            }
        },
        {
            "string",
            new TypeInfo
            {
                Id = 71,
                Size = size_ptr
            }
        },
        {
            "CString",
            new TypeInfo
            {
                Id = 72,
                Size = size_ptr
            }
        },
        {
            "LPSTR",
            new TypeInfo
            {
                Id = 73,
                Size = size_ptr
            }
        },
        {
            "LPCSTR",
            new TypeInfo
            {
                Id = 74,
                Size = size_ptr
            }
        },
        {
            "LPTSTR",
            new TypeInfo
            {
                Id = 75,
                Size = size_ptr
            }
        },
        {
            "LPCTSTR",
            new TypeInfo
            {
                Id = 76,
                Size = size_ptr
            }
        },
        {
            "LPWSTR",
            new TypeInfo
            {
                Id = 77,
                Size = size_ptr
            }
        },
        {
            "LPCWSTR",
            new TypeInfo
            {
                Id = 78,
                Size = size_ptr
            }
        },
        {
            "handle",
            new TypeInfo
            {
                Id = 80,
                Size = size_ptr
            }
        },
        {
            "HANDLE",
            new TypeInfo
            {
                Id = 81,
                Size = size_ptr
            }
        },
        {
            "pointer",
            new TypeInfo
            {
                Id = 82,
                Size = Marshal.SizeOf(typeof(IntPtr))
            }
        },
        {
            "POINTER",
            new TypeInfo
            {
                Id = 83,
                Size = Marshal.SizeOf(typeof(UIntPtr))
            }
        },
        {
            "array",
            new TypeInfo
            {
                Id = 86,
                Size = size_ptr
            }
        },
        {
            "ARRAY",
            new TypeInfo
            {
                Id = 87,
                Size = size_ptr
            }
        },
        {
            "empty pointer",
            new TypeInfo
            {
                Size = Marshal.SizeOf(typeof(Empty))
            }
        },
        {
            "EMPTY POINTER",
            new TypeInfo
            {
                Size = Marshal.SizeOf(typeof(Empty))
            }
        },
        {
            "#enum",
            new TypeInfo
            {
                Id = 90,
                Size = 4
            }
        },
        {
            "enum",
            new TypeInfo
            {
                Id = 91,
                Size = 4
            }
        },
        {
            "ENUM",
            new TypeInfo
            {
                Id = 92,
                Size = 4
            }
        }
    };
 
	internal static int GetPtrSize()
	{
		return size_ptr;
	}

	internal static TypeInfo GetPointerTypeInfo()
	{
		return referenceTypes["pointer"];
	}

	internal static void SetCppSize(string name, int size)
	{
		if (valueTypes.TryGetValue(name, out var typeInfo))
		{
			typeInfo.Size = size;
		}
	}

	internal static TypeInfo? GetRefTypeInfo(string name)
	{
		if (name.EndsWith("*") || name.EndsWith("&"))
		{
			name = "pointer";
		}
		else if (name.EndsWith("[]"))
		{
			name = "array";
		}
		if (name.StartsWith("struct"))
		{
			return null;
		}
		if (referenceTypes.TryGetValue(name, out var info))
		{
			return info;
		}
		return null;
	}

	internal static int GetRefTypeSize(string name)
	{
		return GetRefTypeInfo(name)?.Size ?? (-1);
	}

	internal static TypeInfo? GetValueTypeInfo(string name)
	{
		if (valueTypes.TryGetValue(name, out var info))
		{
			return info;
		}
		return null;
	}

	internal static int GetValueTypeSize(string name)
	{
		return GetValueTypeInfo(name)?.Size ?? (-1);
	}

	internal static TypeInfo? GetTypeInfo(string name)
	{
		TypeInfo info = GetValueTypeInfo(name);
		if (info == null)
		{
			info = GetRefTypeInfo(name);
		}
		return info;
	}

	internal static string GetCodes(List<string>? argTypes)
	{
		if (argTypes == null)
		{
			return "";
		}
		string code = "";
		foreach (string argType in argTypes!)
		{
			code += ToCode(argType);
		}
		return code;
	}

	internal static int ToCode(string type)
	{
		if (GetRefTypeSize(type) != -1)
		{
			return 7;
		}
		TypeInfo info = GetValueTypeInfo(type);
		if (info == null)
		{
			return 7;
		}
		//double
		if (info.Id == 55 || info.Id == 56  || info.Id == 62)
		{
			return 5;
		}
        //float
        if (info.Id == 50||info.Id == 51)
		{
			return 6;
		}

        return (int)Math.Log2(info.Size);
	}

	internal static string? ToType(int code)
	{
		return code switch
		{
			0 => "byte", 
			1 => "short", 
			2 => "int", 
			3 => "long", 
			4 => "decimal", 
			5 => "double", 
			6 => "float", 
			7 => "nint", 
			_ => null, 
		};
	}
}
