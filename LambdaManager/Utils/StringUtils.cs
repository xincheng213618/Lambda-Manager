using System.Collections.Generic;
using System.Linq;

namespace LambdaManager.Utils;

public class StringUtils
{
	public static string[] SplitWithQuoteEscaped(string str)
	{
		Stack<string> result = new Stack<string>();
		int start = 0;
		bool marker = false;
		int i;
		for (i = 0; i < str.Length; i++)
		{
			if (str[i] == '"')
			{
				marker = !marker;
			}
			if (str[i] == ',' && !marker)
			{
				result.Push(str.Substring(start, i - start));
				start = i + 1;
			}
		}
		if (start <= str.Length)
		{
			result.Push(str.Substring(start, i - start));
		}
		return result.Reverse().ToArray();
	}

	public static string UnWrapDoubleQuote(string text)
	{
		if (text.StartsWith('"') && text.EndsWith('"'))
		{
			return text[1..^1];
		}
		return text;
	}
}
