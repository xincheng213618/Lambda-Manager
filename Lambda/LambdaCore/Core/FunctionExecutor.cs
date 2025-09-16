using Lambda;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaManager.NativeInvokers;
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
            ExecInfo info2 = info;
            new Task(delegate
            {
                ExecuteRoutine(info2);
            }).Start();
        }

        public static int ExecuteRoutine(ExecInfo info)
        {
            List<Function> functions = info.Routine.Functions;
            if (functions == null)
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
                //返回 - 1 直接退出循环
                if (result != 0 && result < 0)
                {
                    return result;
                }
            }


            if (info.Caller != null && functions.Count == 1)
            {
                info.Caller!.FunctionArguments = info.FunctionArguments;
            }
            Dictionary<Location, object> variables = info.Variables;
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
            else
            {
                if (times <= 1)
                {
                    return -1;
                }
                ExecInfo info2 = info.Peek();
                for (int i = 0; i < times; i++)
                {
                    info.Times = i;
                    result = Evaluate(info2);
                }
            }
            AddReferredToVariable(info);
            info.ImportVariables();
            return result;
        }

        public static void InvokeFunctionAsync(ExecInfo info)
        {
            ExecInfo clone = info.Clone();
            new Task(delegate
            {
                InvokeFunction(clone);
            }).Start();
        }

        public static int InvokeFunction(ExecInfo info)
        {
            int result = -1;
            int times = info.Function.Times;
            if (times == 1)
            {
                result = ExecuteFunction(info);
            }
            else
            {
                if (times <= 1)
                {
                    return -1;
                }
                for (int i = 0; i < times; i++)
                {
                    info.Times = i;
                    result = ExecuteFunction(info);
                }
            }
            AddReferredToVariable(info);
            info.Caller?.ExportVariables(info);
            List<Event> raise = info.Function.Raise;
            if (raise != null)
            {
                RaiseEvents(raise, info.FunctionArguments, info.Function.EntryPoint);
            }
            if (result == -1)
            {
                string text = "执行函数错误";
                Log.Report(new Message
                {
                    Severity = Severity.ERROR,
                    Text = text
                });
            }
            return result;
        }

        private static int ExecuteFunction(ExecInfo info)
        {
            List<object> args = (info.FunctionArguments = PrepareArguments(info));
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

        private static List<object?>? PrepareArguments(ExecInfo info)
        {
            Function function = info.Function;
            List<object> defaultValues = function.Values;
            if (defaultValues == null)
            {
                return null;
            }
            List<object> initialValues = function.DefaultValues;
            List<object> arguments = new List<object>();
            for (int i = 0; i < defaultValues.Count; i++)
            {
                EntryPoint entry = function.EntryPoint;
                if (i < entry?.InputCount)
                {
                    object value = defaultValues[i];
                    if (function.IsVariable(value) || (value == null && info.RoutineArguments != null))
                    {
                        Location location = new Location
                        {
                            Function = function,
                            Index = i,
                            Group = info.Group
                        };
                        value = ResolveVariableValue(info, location);
                    }
                    if (value == null && i < initialValues?.Count)
                    {
                        value = initialValues[i];
                    }
                    value = Rereinterpret(entry, value, i, arguments);
                    arguments.Add(value);
                }
                else
                {
                    IntPtr p = Marshal.AllocHGlobal(TypesInterop.GetPtrSize());
                    object allocs = info.GetVariable(OutputAlloc);
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
            object value = info.FindVariable(location, out lc, null);
            if (value != null && lc != null)
            {
                if (lc == null)
                {
                    return value;
                }
                Converter converter = lc.Converter;
                if (converter != null)
                {
                    value = converter(value);
                    if (value != null && lc.IsGetAddress)
                    {
                        RegisterNewAddress(info, value);
                    }
                }
                return value;
            }
            return null;
        }

        private static void RegisterNewAddress(ExecInfo info, object value)
        {
            object allocs = info.GetVariable(InputAlloc);
            if (allocs == null)
            {
                allocs = new List<IntPtr>();
                info.AddVariable(InputAlloc, allocs);
            }
            ((List<IntPtr>)allocs).Add((IntPtr)value);
        }

        private static object? Rereinterpret(EntryPoint? entry, object? value, int index, List<object?>? arguments)
        {
            if (entry == null || value == null)
            {
                return value;
            }
            TypeInfo info = entry!.Paremeters?[index];
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
                    return T0.GetArraySize(arguments?[index - 1]);
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
            Function function = info.Function;
            Dictionary<Function, List<Location>> referred = (function.IsReferred ? info.Routine.Referred : null);
            if (referred == null || info.FunctionArguments == null || !referred.TryGetValue(function, out var locations))
            {
                return;
            }
            List<object> args = info.FunctionArguments;
            int offset = function.EntryPoint?.InputCount ?? 0;
            foreach (Location location in locations)
            {
                int index = location.Index;
                object value = ((index >= offset) ? args[index] : function.Values?[index]);
                if (value == function)
                {
                    value = args[index];
                }
                info.AddVariable(location, value);
            }
        }

        private static void CleanWork(ExecInfo info, List<object?>? args)
        {
            Dictionary<Location, object> variables = info.Variables;
            if (variables == null)
            {
                return;
            }
            if (variables.Remove(InputAlloc, out var inputAlloc))
            {
                if (info.Function.IsReferred && inputAlloc != null)
                {
                    variables.TryGetValue(RotineScope, out var allocs);
                    if (allocs == null)
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

        public static void RaiseEvents(List<Event> Events, List<object?>? arguments, EntryPoint? entry)
        {
            int result = 0;
            foreach (Event evt in Events)
            {
                string type = evt.Type;
                if (type != null)
                {
                    switch (evt.ArgType)
                    {
                        case ArgumentType.NO_ARGS:
                            result = Common.CallEvent(type, IntPtr.Zero);
                            break;
                        case ArgumentType.JSON_STRING:
                            result = ((evt.Data != null) ? Common.CallEvent(type, evt.Data, IntPtr.Zero) : Common.CallEvent(type, IntPtr.Zero));
                            break;
                        case ArgumentType.JSON_OBJECT:
                            {
                                string data = PrepareEventData(evt, arguments, entry);
                                result = ((data != null) ? Common.CallEvent(type, data, IntPtr.Zero) : Common.CallEvent(type, IntPtr.Zero));
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
        }

        private static string? PrepareEventData(Event evt, List<object?>? arguments, EntryPoint? entry)
        {
            if (entry == null)
            {
                return null;
            }
            Dictionary<string, int> keys = evt.Keys;
            List<TypeInfo> parameters = entry!.Paremeters;
            if (keys == null || arguments == null || parameters == null)
            {
                return null;
            }
            Dictionary<string, object> json = new Dictionary<string, object>();
            int inputCount = entry!.InputCount;
            foreach (KeyValuePair<string, int> pair in keys)
            {
                int index = pair.Value;
                object value = arguments![index];
                TypeInfo info = parameters[index];
                if (value != null && info != null)
                {
                    if (index >= inputCount)
                    {
                        value = T0.ToValue(info, value);
                    }
                    value = JsonValue.From(info, value);
                    if (value != null)
                    {
                        json[pair.Key] = value;
                    }
                }
            }
            return JSON.Stringify(json);
        }
    }

}

