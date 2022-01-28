using System;
using System.Collections.Generic;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaManager.Utils;

namespace LambdaManager.Core;

internal class ExecInfo
{
	internal Routine Routine { get; set; } = LambdaManager.DataType.Routine.PLACEHOLDER;


	internal Function Function { get; set; } = LambdaManager.DataType.Function.PLACEHOLDER;


	internal Dictionary<Location, object?>? Variables { get; set; }

	internal List<object?>? RoutineArguments { get; set; }

	internal List<object?>? FunctionArguments { get; set; }

	internal List<object?>? Exports { get; set; }

	internal ExecInfo? Caller { get; set; }

	internal int Times { get; set; } = -1;


	internal int Group { get; set; }

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
		int num = FindReferring(key, out lc);
		if (num != -1 && lc != null)
		{
			Location location = lc!.Location;
			List<object> list = ((num != 1) ? RoutineArguments : callee?.RoutineArguments);
			object obj = ((!(list?.Count > location.Index) || location.Function != Function) ? GetVariable(location) : list[location.Index]);
			if (Times != -1)
			{
				if (obj is List<object> list2)
				{
					obj = list2[Times];
				}
				else if (obj is Array array)
				{
					obj = array.GetValue(Times);
				}
			}
			return obj;
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
		Dictionary<Location, LocationConverter> exports = Function.Exports;
		if (exports != null && FindReferring(exports, key, out lc))
		{
			return 1;
		}
		exports = Routine.Referring;
		if (exports != null && FindReferring(exports, key, out lc))
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
			int group = key.Group;
			key.Group = 0;
			if (referring.TryGetValue(key, out lc))
			{
				return true;
			}
			key.Group = group;
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
		foreach (KeyValuePair<int, int> item in imports)
		{
			AddVariable(new Location
			{
				Function = Function,
				Index = item.Value
			}, Exports![item.Key]);
		}
	}

	public void ExportVariables(ExecInfo callee)
	{
		List<object> functionArguments = callee.FunctionArguments;
		if (functionArguments == null)
		{
			return;
		}
		Function function = callee.Function;
		Dictionary<int, int> dictionary = function.EntryPoint?.Exports;
		if (dictionary == null)
		{
			return;
		}
		if (Exports == null)
		{
			Exports = new List<object>();
		}
		int times = Function.Times;
		int num = function.EntryPoint?.InputCount ?? 0;
		foreach (KeyValuePair<int, int> item in dictionary)
		{
			int key = item.Key;
			object obj = ((key >= num) ? functionArguments[key] : function.Values?[key]);
			if (obj == function)
			{
				obj = functionArguments[key];
			}
			if (times == 1)
			{
				CollectionUtils.Insert(Exports, item.Value, obj);
				continue;
			}
			if (Times == 0)
			{
				object[] array = new object[times];
				array[0] = obj;
				CollectionUtils.Insert(Exports, item.Value, array);
			}
			else if (Exports![item.Value] is object[] array2)
			{
				array2[Times] = obj;
			}
			if (Times == times - 1 && Exports![item.Value] is object[] value)
			{
				TypeInfo typeInfo = function.EntryPoint?.Paremeters?[key];
				if (typeInfo == null)
				{
					typeInfo = TypesInterop.GetPointerTypeInfo();
				}
				obj = T86.ToArrayPtr(typeInfo, value);
				CollectionUtils.Insert(Exports, item.Value, obj);
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

	internal ExecInfo Peek()
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
