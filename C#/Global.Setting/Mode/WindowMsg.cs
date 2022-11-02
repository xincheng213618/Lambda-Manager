using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global.Mode
{
    public class WindowMsg:ViewModelBase
    {
        private int viewNums = 0;
        public int ViewNums
        {
            get { return viewNums; }
            set { viewNums = value; NotifyPropertyChanged(); }
        }

        private int stageX = -1;

        public int StageX
        {
            get { return stageX; }
            set { stageX = value; NotifyPropertyChanged(); }
        }

        private int stageY = -1;

        public int StageY
        {
            get { return stageY; }
            set { stageY = value; NotifyPropertyChanged(); }
        }
        private int stageZ = -1;

        public int StageZ
        {
            get { return stageZ; }
            set { stageZ = value; NotifyPropertyChanged(); }
        }





    }
}
