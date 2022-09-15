using System.Collections.Generic;
using System.Linq;

namespace LambdaManager.Utils
{

    public static class StringUtils
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
                return text.Substring(1, text.Length - 1 - 1);
            }
            return text;
        }

        public static List<string> Copy(this List<string> list)
        {
            List<string> copy = new List<string>();
            foreach (string item in list)
            {
                copy.Add(item);
            }
            return copy;
        }
    }

}
