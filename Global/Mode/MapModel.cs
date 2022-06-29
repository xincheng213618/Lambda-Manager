using System;
using Global.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode
{
    public class MapModel:ViewModeBase
    {
        private double stageX = 150;

        public double StageX
        {
            get { return stageX; }
            set { stageX = value; NotifyPropertyChanged(); }
        }
        private double stageY=150;

        public double StageY 
        {
            get { return stageY; }
            set { stageY = value; NotifyPropertyChanged(); }
        }

    }
}
