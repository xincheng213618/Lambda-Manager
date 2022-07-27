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
        public List<ObjectiveSetting> ObjectiveSettingList;
        public List<double> CameraExpose;
        public List<string> CameraExposeShow;
        public List<string> CameraResolution;
    }
}
