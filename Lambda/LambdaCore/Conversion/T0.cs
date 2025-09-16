using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LambdaManager.Core;

namespace LambdaManager.Conversion
{
    public static class T0
    {
        // 类型ID到读取函数的映射表
        private static readonly Dictionary<int, Func<TypeInfo, object, object>> TypeReaders = new()
        {
            [10] = (_, ptr) => Read<bool>(ptr),
            [11] = (_, ptr) => Read<bool>(ptr),
            [12] = (_, ptr) => Read<int>(ptr),
            [13] = (_, ptr) => Read<byte>(ptr),
            [14] = (_, ptr) => Read<byte>(ptr),
            [17] = (_, ptr) => Read<sbyte>(ptr),
            [18] = (_, ptr) => Read<sbyte>(ptr),
            [20] = (_, ptr) => Read<char>(ptr),
            [21] = (_, ptr) => Read<sbyte>(ptr),
            [22] = (_, ptr) => Read<byte>(ptr),
            [23] = (_, ptr) => Read<short>(ptr),
            [24] = (_, ptr) => Read<short>(ptr),
            [25] = (_, ptr) => Read<short>(ptr),
            [27] = (_, ptr) => Read<ushort>(ptr),
            [28] = (_, ptr) => Read<ushort>(ptr),
            [30] = (_, ptr) => Read<int>(ptr),
            [31] = (_, ptr) => Read<int>(ptr),
            [32] = (_, ptr) => Read<int>(ptr),
            [35] = (_, ptr) => Read<uint>(ptr),
            [36] = (_, ptr) => Read<uint>(ptr),
            [40] = (_, ptr) => Read<long>(ptr),
            [41] = (info, ptr) => info.Size == 4 ? Read<int>(ptr) : Read<long>(ptr),
            [42] = (_, ptr) => Read<long>(ptr),
            [45] = (_, ptr) => Read<ulong>(ptr),
            [46] = (info, ptr) => info.Size == 4 ? Read<uint>(ptr) : Read<ulong>(ptr),
            [50] = (_, ptr) => Read<float>(ptr),
            [51] = (_, ptr) => Read<float>(ptr),
            [55] = (_, ptr) => Read<double>(ptr),
            [56] = (_, ptr) => Read<double>(ptr),
            [60] = (info, ptr) => info.Size == 4 ? Read<int>(ptr) : Read<long>(ptr),
            [61] = (_, ptr) => Read<long>(ptr),
            [62] = (info, ptr) => info.Size == 8 ? Read<double>(ptr) : Read<decimal>(ptr),
            [65] = (_, ptr) => Read<decimal>(ptr),
            [66] = (_, ptr) => Read<decimal>(ptr),
            [67] = (_, ptr) => Read<decimal>(ptr),
            [71] = (_, ptr) => Read<IntPtr>(ptr),
            [73] = (_, ptr) => PtrToSByteString(ptr),
            [74] = (_, ptr) => PtrToSByteString(ptr),
            [75] = (_, ptr) => PtrToCharString(ptr),
            [76] = (_, ptr) => PtrToCharString(ptr),
            [77] = (_, ptr) => PtrToCharString(ptr),
            [78] = (_, ptr) => PtrToCharString(ptr),
            [91] = (_, ptr) => Read<int>(ptr),
            [92] = (_, ptr) => Read<int>(ptr),
        };

        public static nint ToAddress(TypeInfo? typeInfo, object value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            var size = Marshal.SizeOf(value);
            var p = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(value, p, fDeleteOld: true);
            return p;
        }

        public static void ClearAddress(object? allocations)
        {
            if (allocations is IEnumerable<IntPtr> ptrs)
            {
                foreach (var ptr in ptrs)
                {
                    Marshal.FreeHGlobal(ptr);
                }
            }
        }

        public unsafe static void ClearAddress(object? allocations, List<object?>? args)
        {
            if (allocations is List<IntPtr> list && args != null)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    IntPtr p = list[i];
                    args[args.Count - 1 - i] = *(IntPtr*)(void*)p;
                    Marshal.FreeHGlobal(p);
                }
            }
        }

        public unsafe static int GetArraySize(object? pointerOrArray)
        {
            if (pointerOrArray == null) return 0;
            IntPtr p =
                pointerOrArray is Array array
                ? Marshal.UnsafeAddrOfPinnedArrayElement(array, 0)
                : (IntPtr)pointerOrArray;
            // 警告：此偏移与实际分配器实现有关，仅适用于某些CLR实现
            return (int)(*(long*)((byte*)(void*)p - 8));
        }

        public static object ToValue(TypeInfo info, object address)
        {
            if (TypeReaders.TryGetValue(info.Id, out var reader))
                return reader(info, address);
            throw new Exception("error: get value of void pointer is not allowed");
        }

        // unsafe+泛型读取
        private unsafe static T Read<T>(object address) where T : unmanaged
        {
            return *(T*)(void*)(IntPtr)address;
        }

        // sbyte* 读字符串
        private unsafe static string PtrToSByteString(object address)
        {
            sbyte* c1 = (sbyte*)(void*)(IntPtr)address;
            return new string(c1);
        }

        // char* 读字符串
        private unsafe static string PtrToCharString(object address)
        {
            char* c2 = (char*)(void*)(IntPtr)address;
            return new string(c2);
        }
    }
}