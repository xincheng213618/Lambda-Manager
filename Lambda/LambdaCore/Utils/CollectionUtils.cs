using System.Collections.Generic;
using LambdaManager.DataType;

namespace LambdaManager.Utils
{
    public static class CollectionExtensions
    {
        public static object? Insert1<T>(this List<T?> This, int index, T? value)
        {
            object oldValue = null;
            if (index < This.Count)
            {
                oldValue = This[index];
                This[index] = value;
            }
            else
            {
                for (int i = This.Count; i < index; i++)
                {
                    This.Add(default);
                }
                This.Add(value);
            }
            return oldValue;
        }
    }

}

