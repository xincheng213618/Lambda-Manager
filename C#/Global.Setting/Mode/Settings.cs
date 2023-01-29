using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Setting.Mode
{
    public class Settings
    {
        public OtherMode otherMode { get; set; } = new OtherMode();
        
    }
    public class OtherMode
    {
        public int? SnapMode { get; set; } = 0;

        public int InkMode { get; set; } = 1;

        public int? Resolution { get; set; } = 0;

        public bool? DevelopMode { get; set; } = false;

    }
}
