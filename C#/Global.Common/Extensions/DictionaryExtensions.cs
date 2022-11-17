using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Common.Extensions
{
    /// <summary>
    /// 对字典的扩展(解决输出不规范的问题)
    /// </summary>
    public static class DictionaryExtensions
    {
        public static string GetString(this Dictionary<string, object>? This, string key)
        {
            if (This.ContainsKey(key)&& This[key] is string value)
            {
                return value;
            }
            return string.Empty;
        }

        public static object GetValue(this Dictionary<string, object>? This, string key)
        {
            if (This.ContainsKey(key))
            {
                return This[key];
            }
            return null;
        }
    }
}
