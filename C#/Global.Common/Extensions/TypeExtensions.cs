
using System;

namespace Global.Common.Extensions
{
    public static class TypeExtensions
    {
        public static T CreateInstance<T>(this Type t, params object[] paramArray)
        {
            return (T)Activator.CreateInstance(t, paramArray);
        }
    }
}