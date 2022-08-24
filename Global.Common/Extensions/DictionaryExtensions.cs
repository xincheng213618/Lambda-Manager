using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Common.Extensions
{
    /// <summary>
    /// 对字典的扩展
    /// </summary>
    public static class DictionaryExtensions
    {
        public static string GetString(this Dictionary<string, object>? keyValuePairs, string key)
        {
            if (keyValuePairs.ContainsKey(key)&& keyValuePairs[key] is string value)
            {
                return value;
            }
            return string.Empty;
        }

        public static object GetValue(this Dictionary<string, object>? keyValuePairs, string key)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                return keyValuePairs[key];
            }
            return null;
        }
    }
}
