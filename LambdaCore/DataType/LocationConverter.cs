using System;
using LambdaManager.Core;

namespace LambdaManager.DataType
{
    public class LocationConverter
    {
        public Location Location { get; set; } = new Location();


        public string? Key { get; set; }

        public Converter? Converter { get; set; } = new Converter(Convert.ToString);


        public bool IsGetAddress { get; set; }
    }
}


