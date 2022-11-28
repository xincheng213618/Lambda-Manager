using System.Collections.Generic;
using LambdaManager.Utils;

namespace LambdaManager.DataType
{
    public class Function
    {
        public static Function PLACEHOLDER = new Function();

        public bool Async;

        public Routine? Routine { get; set; }

        public EntryPoint? EntryPoint { get; set; }

        public int Times { get; set; } = 1;


        public List<object?>? Values { get; set; }

        public List<object?>? DefaultValues { get; set; }

        public bool IsReferred { get; set; }

        public Dictionary<Location, LocationConverter>? Exports { get; set; }

        public Dictionary<int, int>? Imports { get; set; }

        public List<Event>? Raise { get; set; }

        public bool IsVariable(object? value)
        {
            return value == this;
        }

        public void MarkVariable(int index)
        {
            if (Values == null)
            {
                Values = new List<object>();
            }
            object oldValue = Values.Insert1(index, this);
            if (oldValue != null)
            {
                DefaultValues ??= new List<object>();
                DefaultValues.Insert1(index, oldValue);
            }
        }

        public void AddValue(object? value)
        {
            if (Values == null)
            {
                Values = new List<object>();
            }
            Values!.Add(value);
        }
    }

}

