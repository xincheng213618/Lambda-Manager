using System.Collections.Generic;
using System.Linq;

namespace LambdaManager.Utils;

public class StringUtils
{
	public static string[] SplitWithQuoteEscaped(string str)
	{
		Stack<string> stack = new Stack<string>();
		int num = 0;
		bool flag = false;
		int i;
		for (i = 0; i < str.Length; i++)
		{
			if (str[i] == '"')
			{
				flag = !flag;
			}
			if (str[i] == ',' && !flag)
			{
				stack.Push(str.Substring(num, i - num));
				num = i + 1;
			}
		}
		if (num <= str.Length)
		{
			stack.Push(str.Substring(num, i - num));
		}
		return stack.Reverse().ToArray();
	}

	public static string UnWrapDoubleQuote(string text)
	{
		if (text.StartsWith('"') && text.EndsWith('"'))
		{
			return text[1..^1];
		}
		return text;
	}

	public static List<string> Copy(List<string> list)
	{
		List<string> list2 = new List<string>();
		foreach (string item in list)
		{
			list2.Add(item);
		}
		return list2;
	}
}
