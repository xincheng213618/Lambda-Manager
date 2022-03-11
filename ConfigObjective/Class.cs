using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigObjective
{
    public class Class
    {

    }
    public class ObjectiveSetting
    {
        public int ID { get; set; }    
        public string Name { get; set; }   
        public string Magnitude { get; set; }
        public double NA { get; set; }
        public bool IsEnabled { get; set; } = true;
        public bool IsChecked { get; set; } = false;


    }
}
