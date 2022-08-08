using System;
using System.Collections.Generic;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaManager.Utils;

namespace LambdaManager.Core
{
    public class ExecInfo
    {
        public Routine Routine { get; set; } = LambdaManager.DataType.Routine.PLACEHOLDER;


        public Function Function { get; set; } = LambdaManager.DataType.Function.PLACEHOLDER;


        public Dictionary<Location, object?>? Variables { get; set; }

        public List<object?>? RoutineArguments { get; set; }

        public List<object?>? FunctionArguments { get; set; }

        public List<object?>? Exports { get; set; }

        public ExecInfo? Caller { get; set; }

        public int Times { get; set; } = -1;


        public int Group { get; set; }

        public Routine GetFunctionRoutine()
        {
            return Function.Routine ?? LambdaManager.DataType.Routine.PLACEHOLDER;
        }

        public object? GetVariable(Location key)
        {
            if (Variables == null)
            {
                return null;
            }
            if (!Variables!.TryGetValue(key, out var value))
            {
                return null;
            }
            return value;
        }

        public void SetVariable(Location key, object? value)
        {
            if (Variables != null)
            {
                Variables![key] = value;
            }
        }

        public void AddVariable(Location key, object? value)
        {
            if (Variables == null)
            {
                Variables = new Dictionary<Location, object>();
            }
            Variables![key] = value;
        }

        public object? FindVariable(Location key, out LocationConverter? lc, ExecInfo? callee)
        {
            int type = FindReferring(key, out lc);
            if (type != -1 && lc != null)
            {
                Location location = lc!.Location;
                List<object> arguments = ((type != 1) ? RoutineArguments : callee?.RoutineArguments);
                object value = ((!(arguments?.Count > location.Index) || location.Function != Function) ? GetVariable(location) : arguments[location.Index]);
                if (Times != -1)
                {
                    if (value is List<object> values)
                    {
                        value = values[Times];
                    }
                    else if (value is Array array)
                    {
                        value = array.GetValue(Times);
                    }
                }
                return value;
            }
            if (Caller != null)
            {
                return Caller!.FindVariable(key, out lc, this);
            }
            lc = null;
            return null;
        }

        private int FindReferring(Location key, out LocationConverter? lc)
        {
            Dictionary<Location, LocationConverter> referring = Function.Exports;
            if (referring != null && FindReferring(referring, key, out lc))
            {
                return 1;
            }
            referring = Routine.Referring;
            if (referring != null && FindReferring(referring, key, out lc))
            {
                return 2;
            }
            lc = null;
            return -1;
        }

        private static bool FindReferring(Dictionary<Location, LocationConverter> referring, Location key, out LocationConverter? lc)
        {
            if (referring.TryGetValue(key, out lc))
            {
                return true;
            }
            if (key.Group > 0)
            {
                int temp = key.Group;
                key.Group = 0;
                if (referring.TryGetValue(key, out lc))
                {
                    return true;
                }
                key.Group = temp;
            }
            return false;
        }

        public void ImportVariables()
        {
            Dictionary<int, int> imports = Function.Imports;
            if (Exports == null || imports == null)
            {
                return;
            }
            foreach (KeyValuePair<int, int> import in imports)
            {
                AddVariable(new Location
                {
                    Function = Function,
                    Index = import.Value
                }, Exports![import.Key]);
            }
        }

        public void ExportVariables(ExecInfo callee)
        {
            List<object> args = callee.FunctionArguments;
            if (args == null)
            {
                return;
            }
            Function function = callee.Function;
            Dictionary<int, int> exportInfos = function.EntryPoint?.Exports;
            if (exportInfos == null)
            {
                return;
            }
            if (Exports == null)
            {
                Exports = new List<object>();
            }
            int times = Function.Times;
            int offset = function.EntryPoint?.InputCount ?? 0;
            foreach (KeyValuePair<int, int> export in exportInfos)
            {
                int index = export.Key;
                object value = ((index >= offset) ? args[index] : function.Values?[index]);
                if (value == function)
                {
                    value = args[index];
                }
                if (times == 1)
                {
                    CollectionUtils.Insert(Exports, export.Value, value);
                    continue;
                }
                if (Times == 0)
                {
                    object[] values = new object[times];
                    values[0] = value;
                    CollectionUtils.Insert(Exports, export.Value, values);
                }
                else if (Exports![export.Value] is object[] values2)
                {
                    values2[Times] = value;
                }
                if (Times == times - 1 && Exports![export.Value] is object[] values3)
                {
                    TypeInfo typeInfo = function.EntryPoint?.Paremeters?[index];
                    if (typeInfo == null)
                    {
                        typeInfo = TypesInterop.GetPointerTypeInfo();
                    }
                    value = T86.ToArrayPtr(typeInfo, values3);
                    CollectionUtils.Insert(Exports, export.Value, value);
                }
            }
        }

        public ExecInfo Clone()
        {
            return new ExecInfo
            {
                Routine = Routine,
                Function = Function,
                Variables = Variables,
                RoutineArguments = RoutineArguments,
                FunctionArguments = FunctionArguments,
                Exports = Exports,
                Caller = Caller,
                Times = Times,
                Group = Group
            };
        }

        public ExecInfo Peek()
        {
            return new ExecInfo
            {
                Routine = GetFunctionRoutine(),
                RoutineArguments = Function.Values,
                Group = Group,
                Caller = this
            };
        }
    }

}

