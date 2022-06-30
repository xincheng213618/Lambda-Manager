using System;
using System.Runtime.InteropServices;
using LambdaManager.Core;
using LambdaManager.Utils;

namespace LambdaManager.Conversion;

internal class T70
{
	internal static object? Parse(TypeInfo info, string text, string type)
	{
		switch (info.Id)
		{
		case 10:
		case 11:
			return bool.Parse(text);
		case 12:
			return int.Parse(text);
		case 13:
		case 14:
		case 22:
			if (IsQuotedChar(text))
			{
				return Convert.ToByte(text[1]);
			}
			if (IsUnQuotedChar(text))
			{
				return Convert.ToByte(text[0]);
			}
			return byte.Parse(text);
		case 17:
		case 18:
		case 21:
			if (IsQuotedChar(text))
			{
				return Convert.ToSByte(text[1]);
			}
			if (IsUnQuotedChar(text))
			{
				return Convert.ToSByte(text[0]);
			}
			return sbyte.Parse(text);
		case 20:
			if (IsQuotedChar(text))
			{
				return Convert.ToChar(text[2]);
			}
			if (IsUnQuotedChar(text))
			{
				return Convert.ToChar(text[0]);
			}
			return char.Parse(text);
		case 23:
		case 24:
		case 25:
			return short.Parse(text);
		case 27:
		case 28:
			return ushort.Parse(text);
		case 30:
		case 31:
		case 32:
			return int.Parse(text);
		case 35:
		case 36:
			return uint.Parse(text);
		case 40:
		case 42:
		case 61:
			return long.Parse(text);
		case 41:
		case 60:
			if (info.Size == 4)
			{
				return int.Parse(text);
			}
			return long.Parse(text);
		case 45:
			return ulong.Parse(text);
		case 46:
			if (info.Size == 4)
			{
				return uint.Parse(text);
			}
			return ulong.Parse(text);
		case 50:
		case 51:
			return float.Parse(text);
		case 55:
		case 56:
			return double.Parse(text);
		case 62:
			if (info.Size == 8)
			{
				return double.Parse(text);
			}
			return decimal.Parse(text);
		case 65:
		case 66:
		case 67:
			return decimal.Parse(text);
		case 70:
			return StringUtils.UnWrapDoubleQuote(text);
		case 71:
			text = StringUtils.UnWrapDoubleQuote(text);
			return Marshal.StringToHGlobalUni(text);
		case 86:
		case 87:
			return ParseArray(type, text);
		default:
			return text;
		}
	}

	internal static Array? ParseArray(string type, string text)
	{
		type = type[0..^2].Trim();
		TypeInfo info = TypesInterop.GetTypeInfo(type);
		if (info == null)
		{
			return null;
		}
		string[] tokens = StringUtils.SplitWithQuoteEscaped(text[1..^1]);
		object[] array = new object[tokens.Length];
		for (int i = 0; i < tokens.Length; i++)
		{
			object value = (array[i] = Parse(info, tokens[i], type));
		}
		return T86.ToArrayPtr(info, array);
	}

	private static bool IsQuotedChar(string text)
	{
		if (text.Length == 3 && text[0] == '\'')
		{
			return text[2] == '\'';
		}
		return false;
	}

	private static bool IsUnQuotedChar(string text)
	{
		if (text.Length == 1)
		{
			if (text[0] >= '0')
			{
				return text[0] > '9';
			}
			return true;
		}
		return false;
	}
}
