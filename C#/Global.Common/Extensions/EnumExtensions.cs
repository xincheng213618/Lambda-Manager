using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Global.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum This)
        {
            return This?.GetType()
                .GetRuntimeField(This?.ToString())
                .GetCustomAttributes<System.ComponentModel.DescriptionAttribute>()
                .FirstOrDefault()?.Description ?? string.Empty;
        }
    }
}
