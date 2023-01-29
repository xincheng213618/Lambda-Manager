using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.UI.Extension
{
    public class Controls
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }

        public Controls(int index,string type,string name)
        {
            Index = index;
            Type = type;
            Name = name;
           

        }
        public Controls(int index, string type)
        {
            Index = index;
            Type = type;
        }

    }

    public class UIElements
    {
        public static List<Controls> ControlList = new List<Controls>()
        {
          new Controls(1,"Grid"),
          new Controls(2,"Button"),
          new Controls(3,"Slider"),
          new Controls(4,"RadioButton"),
          new Controls(5,"RadioButton"),
          new Controls(6,"RadioButton"),
          new Controls(7,"RadioButton"),
          new Controls(8,"RadioButton"),
          new Controls(9,"Menu"),
          new Controls(10,"MenuItem","file"),
          new Controls(11,"MenuItem","help"),
          new Controls(12,"ComboBox","msgList"),
          new Controls(13,"Grid","stageConfig"),

        };

 

    }




}
