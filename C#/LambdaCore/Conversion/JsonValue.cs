using System;
using System.Runtime.InteropServices;
using LambdaManager.Core;

namespace LambdaManager.Conversion
{
    public class JsonValue
    {
        public static object? From(TypeInfo info, object value)
        {
            if (info.Id == 71)
            {
                return Marshal.PtrToStringAuto((IntPtr)value);
            }
            return value;
        }
    }

}
