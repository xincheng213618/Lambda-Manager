using Lambda;
using LambdaManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaManager.Core
{
    public static class NativeInvoker
    {
        // 可选：把 List<object?> 转换为 object?[] 并做类型规范化
        private static object?[] NormalizeArgs(object?[] args, string code)
        {
            if (args.Length != code.Length)
            {
                throw new ArgumentException($"参数数量({args.Length})与签名长度({code.Length})不一致");
            }

            var normalized = new object?[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                var targetType = CodeCharToType(code[i]);
                normalized[i] = ConvertArg(args[i], targetType);
            }
            return normalized;
        }

        private static object ConvertArg(object? value, Type targetType)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), $"参数不应为 null（目标类型：{targetType}）");

            var vt = value.GetType();
            if (targetType.IsAssignableFrom(vt))
                return value;

            // 特殊处理 IntPtr
            if (targetType == typeof(IntPtr))
            {
                if (value is IntPtr ip) return ip;
                if (value is long l) return new IntPtr(l);
                if (value is int i) return new IntPtr(i);
                // 按需扩展：SafeHandle、UIntPtr、ulong等
                throw new InvalidCastException($"无法将 {vt} 转为 IntPtr");
            }

            // 数值转换（IConvertible）
            try
            {
                if (value is IConvertible)
                {
                    // Convert.ChangeType 支持大多数数值转换
                    return Convert.ChangeType(value, targetType);
                }
            }
            catch
            {
                // ignore, fallback below
            }

            // 直接尝试强制转换失败则报错
            throw new InvalidCastException($"无法将 {vt} 转为 {targetType}");
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

        public static int Exec(LambdaManager.DataType.Function function, List<object?>? args)
        {
            var entry = function.EntryPoint;
            if (entry == null)
            {
                Log.Report(new Message
                {
                    Severity = Severity.ERROR,
                    Text = "函数不存在"
                });
                return -1;
            }

            IntPtr fp = entry.FuncAddr;
            string code = entry.Code ?? string.Empty;

            var invoker = UnmanagedInvokerFactory.GetOrCreate(code);

            if (args == null || args.Count == 0)
            {
                // 无参：code 应该为 "" 或长度为 0
                if (code.Length != 0)
                {
                    Log.Report(new Message
                    {
                        Severity = Severity.ERROR,
                        Text = $"签名({code})与参数不匹配（无参）"
                    });
                    return -1;
                }
                return invoker(fp, Array.Empty<object?>());
            }

            try
            {
                // 先做一次参数规范化，避免 Unbox_Any 类型不匹配崩溃
                var normalized = NormalizeArgs(args.ToArray(), code);
                return invoker(fp, normalized);
            }
            catch (Exception ex)
            {
                Log.Report(new Message
                {
                    Severity = Severity.ERROR,
                    Text = $"调用失败: {ex.Message}"
                });
                return -1;
            }
        }
    }
}