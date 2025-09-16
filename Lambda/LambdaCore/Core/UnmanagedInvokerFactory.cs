using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LambdaManager.Core
{
    // 和你现有映射保持一致（可按需调整）
    // '0' => byte, '1' => short, '2' => int, '3' => long, 
    // '4' => decimal, '5' => double, '6' => float, '7' => IntPtr
    public enum ArgCode 
    {
        U8 = '0',
        I16 = '1',
        I32 = '2',
        I64 = '3',
        Decimal = '4',
        F64 = '5',
        F32 = '6',
        Ptr = '7'
    }

    public static class UnmanagedInvokerFactory
    {
        public delegate int Invoker(IntPtr fp, object?[] args);

        private static readonly ConcurrentDictionary<string, Invoker> Cache = new();

        public static Invoker GetOrCreate(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                // 支持“无参”函数：用空字符串表示
                code = string.Empty;
            }
            return Cache.GetOrAdd(code, BuildInvoker);
        }

        private static Invoker BuildInvoker(string code)
        {
            var paramTypes = ParseParamTypes(code);
            // 生成一个 DynamicMethod：签名为 int Invoke(IntPtr fp, object?[] args)
            var dm = new DynamicMethod(
                name: "Invoke_" + code,
                returnType: typeof(int),
                parameterTypes: new[] { typeof(IntPtr), typeof(object?[]) },
                restrictedSkipVisibility: true
            );

            var il = dm.GetILGenerator();

            // 将每个参数从 args 解包为对应的具体类型，压栈
            for (int i = 0; i < paramTypes.Length; i++)
            {
                il.Emit(OpCodes.Ldarg_1);         // object?[] args
                EmitLdc_I4(il, i);                // 索引 i
                il.Emit(OpCodes.Ldelem_Ref);      // 取出 args[i]

                var t = paramTypes[i];
                if (t.IsValueType)
                {
                    il.Emit(OpCodes.Unbox_Any, t); // 拆箱成值类型
                }
                else
                {
                    il.Emit(OpCodes.Castclass, t); // 引用类型转型
                }
            }

            // 压入函数指针
            il.Emit(OpCodes.Ldarg_0); // IntPtr fp

            // 发出 calli 指令（Cdecl 调用约定）
            il.EmitCalli(
                OpCodes.Calli,
                System.Runtime.InteropServices.CallingConvention.Cdecl,
                typeof(int),
                paramTypes
            );

            il.Emit(OpCodes.Ret);

            var del = (Invoker)dm.CreateDelegate(typeof(Invoker));
            return del;
        }

        private static Type[] ParseParamTypes(string code)
        {
            var list = new List<Type>(code.Length);
            for (int i = 0; i < code.Length; i++)
            {
                list.Add(CodeCharToType(code[i]));
            }
            return list.ToArray();
        }

        private static Type CodeCharToType(char c) => c switch
        {
            (char)ArgCode.U8 => typeof(byte),
            (char)ArgCode.I16 => typeof(short),
            (char)ArgCode.I32 => typeof(int),
            (char)ArgCode.I64 => typeof(long),
            (char)ArgCode.Decimal => typeof(decimal),
            (char)ArgCode.F64 => typeof(double),
            (char)ArgCode.F32 => typeof(float),
            (char)ArgCode.Ptr => typeof(IntPtr),
            _ => throw new NotSupportedException($"未知的参数类型码: '{c}'")
        };

        private static void EmitLdc_I4(ILGenerator il, int value)
        {
            // 常见的小整数有专门的短指令，兼容通用形式
            switch (value)
            {
                case -1: il.Emit(OpCodes.Ldc_I4_M1); break;
                case 0: il.Emit(OpCodes.Ldc_I4_0); break;
                case 1: il.Emit(OpCodes.Ldc_I4_1); break;
                case 2: il.Emit(OpCodes.Ldc_I4_2); break;
                case 3: il.Emit(OpCodes.Ldc_I4_3); break;
                case 4: il.Emit(OpCodes.Ldc_I4_4); break;
                case 5: il.Emit(OpCodes.Ldc_I4_5); break;
                case 6: il.Emit(OpCodes.Ldc_I4_6); break;
                case 7: il.Emit(OpCodes.Ldc_I4_7); break;
                case 8: il.Emit(OpCodes.Ldc_I4_8); break;
                default:
                    if (value >= sbyte.MinValue && value <= sbyte.MaxValue)
                    {
                        il.Emit(OpCodes.Ldc_I4_S, (sbyte)value);
                    }
                    else
                    {
                        il.Emit(OpCodes.Ldc_I4, value);
                    }
                    break;
            }
        }
    }
}