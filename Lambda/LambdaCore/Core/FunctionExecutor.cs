using Lambda;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaUtils;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace LambdaManager.Core
{
    public static class FunctionExecutor
    {
        private static readonly Location RotineScope = new Location();
        private static readonly Location InputAlloc = new Location();
        private static readonly Location OutputAlloc = new Location();

        public static Solution Solution { get; set; } = new Solution();

        public static int Evaluate(ExecInfo info)
        {
            if (info.Routine.Async)
            {
                ExecuteRoutineAsync(info);
                return 0;
            }
            return ExecuteRoutine(info);
        }

        public static void ExecuteRoutineAsync(ExecInfo info)
        {
            var infoCopy = info;
            Task.Run(() => ExecuteRoutine(infoCopy))
                .ContinueWith(t =>
                {
                    if (t.Exception != null)
                    {
                        Log.Report(new Message
                        {
                            Severity = Severity.ERROR,
                            Text = t.Exception.GetBaseException().Message
                        });
                    }
                }, TaskScheduler.Default);
        }

        public static int ExecuteRoutine(ExecInfo info)
        {
            var functions = info.Routine.Functions;
            if (functions == null || functions.Count == 0)
            {
                return 0;
            }

            foreach (var item in functions)
            {
                info.Function = item;
                info.FunctionArguments = null;
                info.Times = -1;

                int result;
                if (item.Routine != null)
                {
                    result = InvokeRoutine(info);
                }
                else
                {
                    if (item.Async)
                    {
                        InvokeFunctionAsync(info);
                        continue;
                    }
                    result = InvokeFunction(info);
                }

                // 负数直接退出循环
                if (result < 0)
                {
                    return result;
                }
            }

            if (info.Caller != null && functions.Count == 1)
            {
                info.Caller.FunctionArguments = info.FunctionArguments;
            }

            var variables = info.Variables;
            if (variables != null && variables.TryGetValue(RotineScope, out var allocs))
            {
                T0.ClearAddress(allocs);
            }
            return 0;
        }

        public static int InvokeRoutine(ExecInfo info)
        {
            int result = -1;
            int times = info.Function.Times;

            if (times == 1)
            {
                result = Evaluate(info.Peek());
            }
            else if (times > 1)
            {
                var peeked = info.Peek();
                for (int i = 0; i < times; i++)
                {
                    info.Times = i;
                    result = Evaluate(peeked);
                    // 如果需要短路退出，这里可加判断
                }
            }
            else
            {
                return -1;
            }

            AddReferredToVariable(info);
            info.ImportVariables();
            return result;
        }

        public static void InvokeFunctionAsync(ExecInfo info)
        {
            var clone = info.Clone();
            Task.Run(() => InvokeFunction(clone))
                .ContinueWith(t =>
                {
                    if (t.Exception != null)
                    {
                        Log.Report(new Message
                        {
                            Severity = Severity.ERROR,
                            Text = t.Exception.GetBaseException().Message
                        });
                    }
                }, TaskScheduler.Default);
        }

        public static int InvokeFunction(ExecInfo info)
        {
            int result = -1;
            int times = info.Function.Times;

            if (times == 1)
            {
                result = ExecuteFunction(info);
            }
            else if (times > 1)
            {
                for (int i = 0; i < times; i++)
                {
                    info.Times = i;
                    result = ExecuteFunction(info);
                    // 如果需要短路退出，这里可加判断
                }
            }
            else
            {
                return -1;
            }

            AddReferredToVariable(info);
            info.Caller?.ExportVariables(info);

            var raise = info.Function.Raise;
            if (raise != null && raise.Count > 0)
            {
                RaiseEvents(raise, info.FunctionArguments, info.Function.EntryPoint);
            }

            if (result == -1)
            {
                Log.Report(new Message
                {
                    Severity = Severity.ERROR,
                    Text = "执行函数错误"
                });
            }
            return result;
        }

        private static int ExecuteFunction(ExecInfo info)
        {
            var args = (info.FunctionArguments = PrepareArguments(info));
            int result = -1;
            try
            {
                result = NativeInvoker.Exec(info.Function, args);
                return result;
            }
            catch (Exception ex)
            {
                Log.Report(new Message
                {
                    Severity = Severity.ERROR,
                    Text = ex.Message
                });
                return result;
            }
            finally
            {
                CleanWork(info, args);
            }
        }

        // 统一返回 List<object>，避免上层赋值/接收时的泛型不匹配
        private static List<object>? PrepareArguments(ExecInfo info)
        {
            var function = info.Function;
            var defaultValues = function.Values;
            if (defaultValues == null)
            {
                return null;
            }

            var initialValues = function.DefaultValues;
            var entry = function.EntryPoint;
            var inputCount = entry?.InputCount ?? 0;

            var arguments = new List<object>(defaultValues.Count);

            for (int i = 0; i < defaultValues.Count; i++)
            {
                if (i < inputCount)
                {
                    object value = defaultValues[i];

                    if (function.IsVariable(value) || (value == null && info.RoutineArguments != null))
                    {
                        var location = new Location
                        {
                            Function = function,
                            Index = i,
                            Group = info.Group
                        };
                        value = ResolveVariableValue(info, location);
                    }

                    if (value == null && i < (initialValues?.Count ?? 0))
                    {
                        value = initialValues![i];
                    }

                    value = Rereinterpret(entry, value, i, arguments);
                    arguments.Add(value!);
                }
                else
                {
                    // 输出参数：分配指针并登记
                    IntPtr p = Marshal.AllocHGlobal(TypesInterop.GetPtrSize());
                    var allocs = info.GetVariable(OutputAlloc);
                    if (allocs == null)
                    {
                        allocs = new List<IntPtr>();
                        info.SetVariable(OutputAlloc, allocs);
                    }
                    ((List<IntPtr>)allocs).Add(p);
                    arguments.Add(p);
                }
            }

            return arguments;
        }

        private static object? ResolveVariableValue(ExecInfo info, Location location)
        {
            LocationConverter lc;
            var value = info.FindVariable(location, out lc, null);

            if (value == null)
            {
                return null;
            }

            if (lc != null)
            {
                var converter = lc.Converter;
                if (converter != null)
                {
                    value = converter(value);
                    if (value != null && lc.IsGetAddress)
                    {
                        RegisterNewAddress(info, value);
                    }
                }
            }

            return value;
        }

        private static void RegisterNewAddress(ExecInfo info, object value)
        {
            var allocs = info.GetVariable(InputAlloc);
            if (allocs == null)
            {
                allocs = new List<IntPtr>();
                info.AddVariable(InputAlloc, allocs);
            }
            ((List<IntPtr>)allocs).Add((IntPtr)value);
        }

        private static object? Rereinterpret(EntryPoint? entry, object? value, int index, List<object>? arguments)
        {
            if (entry == null || value == null)
            {
                return value;
            }

            var parameters = entry.Paremeters;
            if (parameters == null || index < 0 || index >= parameters.Count)
            {
                return value;
            }

            var info = parameters[index];
            if (info == null)
            {
                return value;
            }

            switch (info.Id)
            {
                case 10:
                case 11:
                    {
                        bool b = (bool)value;
                        return Unsafe.As<bool, byte>(ref b);
                    }
                case 17:
                case 18:
                case 21:
                    {
                        sbyte c = (sbyte)value;
                        return Unsafe.As<sbyte, byte>(ref c);
                    }
                case 20:
                    {
                        char c2 = (char)value;
                        return Unsafe.As<char, short>(ref c2);
                    }
                case 27:
                case 28:
                    {
                        ushort c3 = (ushort)value;
                        return Unsafe.As<ushort, short>(ref c3);
                    }
                case 33:
                    return (arguments != null && index - 1 >= 0) ? T0.GetArraySize(arguments[index - 1]) : null;
                case 35:
                case 36:
                    {
                        uint x = (uint)value;
                        return Unsafe.As<uint, int>(ref x);
                    }
                case 45:
                    {
                        ulong y = (ulong)value;
                        return Unsafe.As<ulong, long>(ref y);
                    }
                case 50:
                case 51:
                    return Convert.ToSingle(value);
                case 55:
                case 56:
                    return Convert.ToDouble(value);
                case 46:
                    {
                        if (info.Size == 4)
                        {
                            uint x = (uint)value;
                            return Unsafe.As<uint, int>(ref x);
                        }
                        ulong y = (ulong)value;
                        return Unsafe.As<ulong, long>(ref y);
                    }
                case 70:
                    return Marshal.StringToHGlobalAnsi((string)value);
                case 86:
                case 87:
                    return Marshal.UnsafeAddrOfPinnedArrayElement((Array)value, 0);
                default:
                    return value;
            }
        }

        private static void AddReferredToVariable(ExecInfo info)
        {
            var function = info.Function;
            var referred = function.IsReferred ? info.Routine.Referred : null;

            if (referred == null || info.FunctionArguments == null || !referred.TryGetValue(function, out var locations) || locations == null)
            {
                return;
            }

            var args = info.FunctionArguments;
            int offset = function.EntryPoint?.InputCount ?? 0;

            foreach (var location in locations)
            {
                int index = location.Index;
                object value = (index >= offset)
                    ? args[index]
                    : function.Values?[index];

                if (ReferenceEquals(value, function))
                {
                    value = args[index];
                }
                info.AddVariable(location, value);
            }
        }

        private static void CleanWork(ExecInfo info, List<object>? args)
        {
            var variables = info.Variables;
            if (variables == null)
            {
                return;
            }

            if (variables.Remove(InputAlloc, out var inputAlloc))
            {
                if (info.Function.IsReferred && inputAlloc != null)
                {
                    if (!variables.TryGetValue(RotineScope, out var allocs) || allocs == null)
                    {
                        allocs = new List<IntPtr>();
                        variables[RotineScope] = allocs;
                    }
                    ((List<IntPtr>)allocs).AddRange((List<IntPtr>)inputAlloc);
                }
                else
                {
                    T0.ClearAddress(inputAlloc);
                }
            }

            if (variables.Remove(OutputAlloc, out var outputAlloc))
            {
                T0.ClearAddress(outputAlloc, args);
            }
        }

        public static void RaiseEvents(List<Event> Events, List<object>? arguments, EntryPoint? entry)
        {
            int result = 0;
            foreach (var evt in Events)
            {
                var type = evt.Type;
                if (type == null)
                {
                    continue;
                }

                switch (evt.ArgType)
                {
                    case ArgumentType.NO_ARGS:
                        result = Common.CallEvent(type, IntPtr.Zero);
                        break;

                    case ArgumentType.JSON_STRING:
                        result = (evt.Data != null)
                            ? Common.CallEvent(type, evt.Data, IntPtr.Zero)
                            : Common.CallEvent(type, IntPtr.Zero);
                        break;

                    case ArgumentType.JSON_OBJECT:
                        {
                            var data = PrepareEventData(evt, arguments, entry);
                            result = (data != null)
                                ? Common.CallEvent(type, data, IntPtr.Zero)
                                : Common.CallEvent(type, IntPtr.Zero);
                            break;
                        }

                    case ArgumentType.STL_MAP:
                        Log.Report(new Message
                        {
                            Severity = Severity.ERROR,
                            Text = "事件对象不支持二进制类型数据传递"
                        });
                        break;

                    case ArgumentType.POINTER:
                    case ArgumentType.POINTER2:
                    case ArgumentType.POINTER4:
                        result = Common.CallEvent(type, arguments, IntPtr.Zero);
                        break;
                }

                if (result == -1)
                {
                    break;
                }
            }
        }

        private static string? PrepareEventData(Event evt, List<object>? arguments, EntryPoint? entry)
        {
            if (entry == null)
            {
                return null;
            }

            var keys = evt.Keys;
            var parameters = entry.Paremeters;
            if (keys == null || arguments == null || parameters == null)
            {
                return null;
            }

            var json = new Dictionary<string, object>();
            int inputCount = entry.InputCount;

            foreach (var pair in keys)
            {
                int index = pair.Value;
                if (index < 0 || index >= arguments.Count || index >= parameters.Count)
                {
                    continue;
                }

                object value = arguments[index];
                var info = parameters[index];
                if (value != null && info != null)
                {
                    if (index >= inputCount)
                    {
                        value = T0.ToValue(info, value);
                    }
                    var jv = JsonValue.From(info, value);
                    if (jv != null)
                    {
                        json[pair.Key] = jv;
                    }
                }
            }

            return JSON.Stringify(json);
        }
    }
}