using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Lambda;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaManager.DataType.SigTable;
using LambdaManager.Properties;
using Swifter.Json;

namespace LambdaManager.Core;

internal static class FunctionExecutor
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
		using (List<Function>.Enumerator enumerator = functions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Function function = (info.Function = enumerator.Current);
				info.FunctionArguments = null;
				info.Times = -1;
				int num;
				if (function.Routine != null)
				{
					num = InvokeRoutine(info);
				}
				else
				{
					if (function.Async)
					{
						InvokeFunctionAsync(info);
						continue;
					}
					num = InvokeFunction(info);
				}
				if (num != 0 && num < 0)
				{
					return num;
				}
			}
		}
		if (info.Caller != null && functions.Count == 1)
		{
			info.Caller!.FunctionArguments = info.FunctionArguments;
		}
		Dictionary<Location, object> variables = info.Variables;
		if (variables != null && variables.TryGetValue(RotineScope, out var value))
		{
			T0.ClearAddress(value);
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
		int num = -1;
		int times = info.Function.Times;
		if (times == 1)
		{
			num = ExecuteFunction(info);
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
				num = ExecuteFunction(info);
			}
		}
		AddReferredToVariable(info);
		info.Caller?.ExportVariables(info);
		List<Event> raise = info.Function.Raise;
		if (raise != null)
		{
			RaiseEvents(raise, info.FunctionArguments, info.Function.EntryPoint);
		}
		if (num == -1)
		{
			string text = Resources.Execute + Resources.Action + Resources.Error;
			App.Report(new Message
			{
				Severity = Severity.ERROR,
				Text = text
			});
		}
		return num;
	}

	private static int ExecuteFunction(ExecInfo info)
	{
		List<object> args = (info.FunctionArguments = PrepareArguments(info));
		int result = -1;
		try
		{
			result = Exec(info.Function, args);
			return result;
		}
		catch (Exception ex)
		{
			App.Report(new Message
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
		List<object> values = function.Values;
		if (values == null)
		{
			return null;
		}
		List<object> defaultValues = function.DefaultValues;
		List<object> list = new List<object>();
		for (int i = 0; i < values.Count; i++)
		{
			EntryPoint entryPoint = function.EntryPoint;
			if (i < entryPoint?.InputCount)
			{
				object obj = values[i];
				if (function.IsVariable(obj) || (obj == null && info.RoutineArguments != null))
				{
					Location location = new Location
					{
						Function = function,
						Index = i,
						Group = info.Group
					};
					obj = ResolveVariableValue(info, location);
				}
				if (obj == null && i < defaultValues?.Count)
				{
					obj = defaultValues[i];
				}
				obj = Rereinterpret(entryPoint, obj, i, list);
				list.Add(obj);
			}
			else
			{
				IntPtr intPtr = Marshal.AllocHGlobal(TypesInterop.GetPtrSize());
				object obj2 = info.GetVariable(OutputAlloc);
				if (obj2 == null)
				{
					obj2 = new List<IntPtr>();
					info.SetVariable(OutputAlloc, obj2);
				}
				((List<IntPtr>)obj2).Add(intPtr);
				list.Add(intPtr);
			}
		}
		return list;
	}

	private static object? ResolveVariableValue(ExecInfo info, Location location)
	{
		LocationConverter lc;
		object obj = info.FindVariable(location, out lc, null);
		if (obj != null && lc != null)
		{
			if (lc == null)
			{
				return obj;
			}
			Converter converter = lc.Converter;
			if (converter != null)
			{
				obj = converter(obj);
				if (obj != null && lc.IsGetAddress)
				{
					RegisterNewAddress(info, obj);
				}
			}
			return obj;
		}
		return null;
	}

	private static void RegisterNewAddress(ExecInfo info, object value)
	{
		object obj = info.GetVariable(InputAlloc);
		if (obj == null)
		{
			obj = new List<IntPtr>();
			info.AddVariable(InputAlloc, obj);
		}
		((List<IntPtr>)obj).Add((IntPtr)value);
	}

	private static object? Rereinterpret(EntryPoint? entry, object? value, int index, List<object?>? arguments)
	{
		if (entry == null || value == null)
		{
			return value;
		}
		TypeInfo typeInfo = entry!.Paremeters?[index];
		if (typeInfo == null)
		{
			return value;
		}
		switch (typeInfo.Id)
		{
		case 10:
		case 11:
		{
			bool source6 = (bool)value;
			return Unsafe.As<bool, byte>(ref source6);
		}
		case 17:
		case 18:
		case 21:
		{
			sbyte source5 = (sbyte)value;
			return Unsafe.As<sbyte, byte>(ref source5);
		}
		case 20:
		{
			char source3 = (char)value;
			return Unsafe.As<char, short>(ref source3);
		}
		case 27:
		case 28:
		{
			ushort source4 = (ushort)value;
			return Unsafe.As<ushort, short>(ref source4);
		}
		case 33:
			return T0.GetArraySize(arguments?[index - 1]);
		case 35:
		case 36:
		{
			uint source = (uint)value;
			return Unsafe.As<uint, int>(ref source);
		}
		case 45:
		{
			ulong source2 = (ulong)value;
			return Unsafe.As<ulong, long>(ref source2);
		}
		case 46:
		{
			if (typeInfo.Size == 4)
			{
				uint source = (uint)value;
				return Unsafe.As<uint, int>(ref source);
			}
			ulong source2 = (ulong)value;
			return Unsafe.As<ulong, long>(ref source2);
		}
		case 86:
		case 87:
			return Marshal.UnsafeAddrOfPinnedArrayElement((Array)value, 0);
		default:
			return value;
		}
	}

	private static int Exec(Function function, List<object?>? args)
	{
		EntryPoint entryPoint = function.EntryPoint;
		if (entryPoint == null)
		{
			App.Report(new Message
			{
				Severity = Severity.ERROR,
				Text = Resources.Action + Resources.NotExist
			});
			return -1;
		}
		IntPtr funcAddr = entryPoint.FuncAddr;
		string code = entryPoint.Code;
		if (args == null || args!.Count == 0)
		{
			return S1.Invoke(funcAddr);
		}
		return args!.Count switch
		{
			1 => S1.Invoke(code, funcAddr, args), 
			2 => S2.Invoke(code, funcAddr, args), 
			3 => S3.Invoke(code, funcAddr, args), 
			4 => code[0] switch
			{
				'0' => S40.Invoke0(code, funcAddr, args), 
				'1' => S41.Invoke1(code, funcAddr, args), 
				'2' => S42.Invoke2(code, funcAddr, args), 
				'6' => S46.Invoke6(code, funcAddr, args), 
				'3' => S43.Invoke3(code, funcAddr, args), 
				'5' => S45.Invoke5(code, funcAddr, args), 
				'4' => S44.Invoke4(code, funcAddr, args), 
				'7' => S47.Invoke7(code, funcAddr, args), 
				_ => -1, 
			}, 
			5 => S5.Invoke(code, funcAddr, args), 
			6 => code[0] switch
			{
				'2' => S62.Invoke2(code, funcAddr, args), 
				'6' => S66.Invoke6(code, funcAddr, args), 
				'3' => S63.Invoke3(code, funcAddr, args), 
				'5' => S65.Invoke5(code, funcAddr, args), 
				'7' => S67.Invoke7(code, funcAddr, args), 
				_ => -1, 
			}, 
			_ => -1, 
		};
	}

	private static void AddReferredToVariable(ExecInfo info)
	{
		Function function = info.Function;
		Dictionary<Function, List<Location>> dictionary = (function.IsReferred ? info.Routine.Referred : null);
		if (dictionary == null || info.FunctionArguments == null || !dictionary.TryGetValue(function, out var value))
		{
			return;
		}
		List<object> functionArguments = info.FunctionArguments;
		int num = function.EntryPoint?.InputCount ?? 0;
		foreach (Location item in value)
		{
			int index = item.Index;
			object obj = ((index >= num) ? functionArguments[index] : function.Values?[index]);
			if (obj == function)
			{
				obj = functionArguments[index];
			}
			info.AddVariable(item, obj);
		}
	}

	private static void CleanWork(ExecInfo info, List<object?>? args)
	{
		Dictionary<Location, object> variables = info.Variables;
		if (variables == null)
		{
			return;
		}
		if (variables.Remove(InputAlloc, out var value))
		{
			if (info.Function.IsReferred && value != null)
			{
				variables.TryGetValue(RotineScope, out var value2);
				if (value2 == null)
				{
					value2 = new List<IntPtr>();
					variables[RotineScope] = value2;
				}
				((List<IntPtr>)value2).AddRange((List<IntPtr>)value);
			}
			else
			{
				T0.ClearAddress(value);
			}
		}
		if (variables.Remove(OutputAlloc, out var value3))
		{
			T0.ClearAddress(value3, args);
		}
	}

	private static void RaiseEvents(List<Event> Events, List<object?>? arguments, EntryPoint? entry)
	{
		int num = 0;
		foreach (Event Event in Events)
		{
			string type = Event.Type;
			if (type != null)
			{
				switch (Event.ArgType)
				{
				case ArgumentType.NO_ARGS:
					num = Common.CallEvent(type, IntPtr.Zero);
					break;
				case ArgumentType.JSON_STRING:
					num = ((Event.Data != null) ? Common.CallEvent(type, Event.Data, IntPtr.Zero) : Common.CallEvent(type, IntPtr.Zero));
					break;
				case ArgumentType.JSON_OBJECT:
				{
					string text = PrepareEventData(Event, arguments, entry);
					num = ((text != null) ? Common.CallEvent(type, text, IntPtr.Zero) : Common.CallEvent(type, IntPtr.Zero));
					break;
				}
				case ArgumentType.STL_MAP:
					App.Report(new Message
					{
						Severity = Severity.ERROR,
						Text = Resources.STLMapNotSupport
					});
					break;
				case ArgumentType.POINTER:
				case ArgumentType.POINTER2:
				case ArgumentType.POINTER4:
					num = Common.CallEvent(type, arguments, IntPtr.Zero);
					break;
				}
				if (num == -1)
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
		List<TypeInfo> paremeters = entry!.Paremeters;
		if (keys == null || arguments == null || paremeters == null)
		{
			return null;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		int inputCount = entry!.InputCount;
		foreach (KeyValuePair<string, int> item in keys)
		{
			int value = item.Value;
			object obj = arguments![value];
			TypeInfo typeInfo = paremeters[value];
			if (obj != null && typeInfo != null)
			{
				if (value >= inputCount)
				{
					obj = T0.ToValue(typeInfo, obj);
				}
				obj = LambdaManager.Conversion.JsonValue.From(typeInfo, obj);
				if (obj != null)
				{
					dictionary[item.Key] = obj;
				}
			}
		}
		return JsonFormatter.SerializeObject(dictionary);
	}
}
