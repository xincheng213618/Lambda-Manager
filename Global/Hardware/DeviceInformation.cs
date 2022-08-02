using Global.Common;
using Global.Mode.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Hardware
{
    public class DeviceInformation: ViewModelBase
    {
        //Objectiv
        public List<ObjectiveSetting> ObjectiveSettingList;
        //相机曝光
        public List<double> CameraExpose;

        public List<string> CameraExposeShow;

        public List<string> CameraResolution;   

    }
}
