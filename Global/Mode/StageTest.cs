using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode
{
    public class StageTest:ViewModeBase
    {
        private double stageX;

        public double StageX
        {
            get { return stageX; }
            set { stageX = value;  NotifyPropertyChanged(); }
        }
        private double stageY;

        public double StageY
        {
            get { return stageY; }
            set { stageY = value; NotifyPropertyChanged(); }
        }

    }
}
