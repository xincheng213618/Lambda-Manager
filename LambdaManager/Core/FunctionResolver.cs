using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Lambda;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaManager.Properties;

namespace LambdaManager.Core;

internal class FunctionResolver
{
	private readonly Lib? lib;

	private List<string>? argTypes;

	internal List<TypeInfo?>? TypeInfos { get; set; }

	internal List<object?>? DefaultValues { get; set; }

	internal FunctionResolver(Lib? lib)
	{
		this.lib = lib;
	}

	internal IntPtr GetAddress(LambdaManager.DataType.Action action, Component component)
	{
		Parse(action);
		string name = action.Name;
		if (name == null || lib == null)
		{
			return IntPtr.Zero;
		}
		try
		{
			return NativeLibrary.GetExport(lib!.Addr, name);
		}
		catch (EntryPointNotFoundException)
		{
			App.Report(Severity.FATAL_ERROR, Resources.Lib, component.Lib, Resources.Action, action.Name, Resources.NotExist);
			return IntPtr.Zero;
		}
	}

	internal string GetSignatureCodes()
	{
		return TypesInterop.GetCodes(argTypes);
	}

	internal void Parse(LambdaManager.DataType.Action action)
	{
		TypeInfos = new List<TypeInfo>();
		argTypes = new List<string>();
		DefaultValues = new List<object>();
		List<Input> inputs = action.Inputs;
		if (inputs != null)
		{
			foreach (Input item3 in inputs)
			{
				string text = item3.Type ?? "string";
				if (text == "action")
				{
					argTypes!.Add("pointer");
					TypeInfos!.Add(TypesInterop.GetTypeInfo("pointer"));
					DefaultValues!.Add(IntPtr.Zero);
				}
				else
				{
					argTypes!.Add(text);
					TypeInfos!.Add(TypesInterop.GetTypeInfo(text));
					object item = Parse(text, item3.Value);
					DefaultValues!.Add(item);
				}
			}
		}
		List<Output> outputs = action.Outputs;
		if (outputs != null)
		{
			foreach (Output item4 in outputs)
			{
				string text2 = item4.Type ?? "string";
				argTypes!.Add(text2);
				TypeInfos!.Add(TypesInterop.GetTypeInfo(text2));
				object item2 = Parse(text2, item4.Value);
				DefaultValues!.Add(item2);
			}
		}
		if (TypeInfos!.Count == 0)
		{
			TypeInfos = null;
		}
		if (argTypes!.Count == 0)
		{
			argTypes = null;
		}
		if (DefaultValues!.Count == 0)
		{
			DefaultValues = null;
		}
	}

	private static object? Parse(string? type, string? value)
	{
		if (value == null)
		{
			return null;
		}
		if (type == null)
		{
			type = "string";
		}
		TypeInfo typeInfo = TypesInterop.GetTypeInfo(type);
		if (typeInfo == null)
		{
			return value;
		}
		return T70.Parse(typeInfo, value, type);
	}

	internal static ArgumentType? GetEventArgType(LambdaManager.DataType.Action? action)
	{
		if (action == null)
		{
			return null;
		}
		int argsCount = action!.GetArgsCount();
		List<Input> inputs = action!.Inputs;
		if (argsCount == 0 || inputs == null)
		{
			return ArgumentType.NO_ARGS;
		}
		foreach (Input item in inputs)
		{
			string type = item.Type;
			if (type != null && item.Value == null)
			{
				if (type == "json*")
				{
					return ArgumentType.JSON_OBJECT;
				}
				if (type == "string")
				{
					return ArgumentType.JSON_STRING;
				}
				if (type.StartsWith("map"))
				{
					return ArgumentType.STL_MAP;
				}
			}
		}
		return null;
	}

	internal static string GetFullName(Component? component, Procedure procedure, string? actionName)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
		defaultInterpolatedStringHandler.AppendFormatted(component?.Name);
		defaultInterpolatedStringHandler.AppendLiteral("::");
		defaultInterpolatedStringHandler.AppendFormatted(procedure.Name);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(actionName);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	internal static List<CastType> ResolveLinkCastType(string? targetName, string? targetType, string? sourceName, string? sourceType)
	{
		if (targetName != sourceName)
		{
			return new List<CastType> { CastType.NAME_NOT_MATCH };
		}
		return ResolveLinkCastType(targetType, sourceType);
	}

	internal static List<CastType> ResolveLinkCastType(string? targetType, string? sourceType)
	{
		if (targetType == sourceType)
		{
			return new List<CastType> { CastType.NO_CAST };
		}
		if (sourceType == null)
		{
			sourceType = "string";
		}
		if (targetType == null)
		{
			targetType = "string";
		}
		bool flag = IsGetValue(sourceType, targetType);
		bool flag2 = IsGetAddress(sourceType, targetType);
		sourceType = GetCleanType(sourceType);
		targetType = GetCleanType(targetType);
		if (flag && sourceType == targetType)
		{
			return new List<CastType> { CastType.CAST_VALUE };
		}
		if (flag2 && sourceType == targetType)
		{
			return new List<CastType> { CastType.CAST_ADDRESS };
		}
		TypeInfo typeInfo = TypesInterop.GetTypeInfo(targetType);
		if (typeInfo == null)
		{
			return new List<CastType> { CastType.TYPE_NOT_MATCH };
		}
		List<CastType> list = new List<CastType>();
		switch (typeInfo.Id)
		{
		case 10:
		case 11:
			list.Add(CastType.CAST_BOOLEAN);
			break;
		case 12:
			list.Add(CastType.CAST_BOOL);
			break;
		case 13:
		case 14:
			list.Add(CastType.CAST_BYTE);
			break;
		case 17:
		case 18:
			list.Add(CastType.CAST_SBYTE);
			break;
		case 20:
			list.Add(CastType.CAST_CHAR);
			break;
		case 21:
			list.Add(CastType.CAST_SBYTE);
			break;
		case 22:
			list.Add(CastType.CAST_BYTE);
			break;
		case 23:
		case 24:
		case 25:
			list.Add(CastType.CAST_INT16);
			break;
		case 27:
		case 28:
			list.Add(CastType.CAST_UINT16);
			break;
		case 30:
		case 31:
		case 32:
			list.Add(CastType.CAST_INT32);
			break;
		case 35:
		case 36:
			list.Add(CastType.CAST_UINT32);
			break;
		case 40:
			list.Add(CastType.CAST_INT64);
			break;
		case 41:
			list.Add(CastType.CAST_INT64);
			break;
		case 42:
		case 61:
			list.Add(CastType.CAST_INT64);
			break;
		case 60:
			list.Add(CastType.CAST_INT64);
			break;
		case 45:
			list.Add(CastType.CAST_UINT64);
			break;
		case 46:
			list.Add(CastType.CAST_UINT64);
			break;
		case 50:
		case 51:
			list.Add(CastType.CAST_FLOAT);
			break;
		case 55:
		case 56:
			list.Add(CastType.CAST_DOUBLE);
			break;
		case 62:
			list.Add(CastType.CAST_DECIMAL);
			break;
		case 65:
		case 66:
		case 67:
			list.Add(CastType.CAST_DECIMAL);
			break;
		default:
			list.Add(CastType.TYPE_NOT_MATCH);
			break;
		}
		if (flag)
		{
			list.Add(CastType.CAST_VALUE);
		}
		if (flag2)
		{
			list.Add(CastType.CAST_ADDRESS);
		}
		return list;
	}

	private static bool IsGetValue(string sourceType, string targetType)
	{
		if (IsEndsWith(sourceType, "**") && IsEndsWith(targetType, "*"))
		{
			return true;
		}
		if (IsEndsWith(sourceType, "*") && IsCleanType(targetType))
		{
			return true;
		}
		if (IsCleanType(sourceType) && IsEndsWith(targetType, "&"))
		{
			return true;
		}
		if (IsEndsWith(sourceType, "&") && IsEndsWith(targetType, "&&"))
		{
			return true;
		}
		return false;
	}

	private static bool IsGetAddress(string sourceType, string targetType)
	{
		if (IsEndsWith(sourceType, "*") && IsEndsWith(targetType, "**"))
		{
			return true;
		}
		if (IsCleanType(sourceType) && IsEndsWith(targetType, "*"))
		{
			return true;
		}
		if (IsEndsWith(sourceType, "&") && IsCleanType(targetType))
		{
			return true;
		}
		if (IsEndsWith(sourceType, "&&") && IsEndsWith(targetType, "&"))
		{
			return true;
		}
		return false;
	}

	private static bool IsCleanType(string type)
	{
		if (IsEndsWith(type, "*") || IsEndsWith(type, "&"))
		{
			return false;
		}
		return true;
	}

	private static bool IsEndsWith(string type, string suffix)
	{
		if (type.Length == suffix.Length)
		{
			return false;
		}
		if (!type.EndsWith(suffix))
		{
			return false;
		}
		char value = type[type.Length - suffix.Length - 1];
		return !suffix.Contains(value);
	}

	internal static string GetCleanType(string type)
	{
		return new Regex("[\\*&\\[\\]]{1,2}$").Replace(type, "");
	}

	internal static string? CleanSuffix(string? type, string suffix)
	{
		if (type == null)
		{
			return null;
		}
		if (IsEndsWith(type, suffix))
		{
			return type![..^suffix.Length];
		}
		return type;
	}
}
