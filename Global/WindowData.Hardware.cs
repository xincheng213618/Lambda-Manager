using Global.Common.Extensions;
using Global.Hardware;
using Global.Mode.Config;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Global
{
    public partial class WindowData
    {

        private void Hardware_Initialized()
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < GlobalConst.expose.Count; i++)
            {
                strings.Add($"1/{GlobalConst.expose[i]:0.######}");
                GlobalConst.expose[i] = 1 / GlobalConst.expose[i];
            }
            GlobalConst.expose.AddRange(GlobalConst.expose1);
            strings.AddRange(GlobalConst.expose1.Select(x => x.ToString("0.######")).ToArray());

            deviceInformation = new DeviceInformation()
            {
                ObjectiveSettingList = new() {
                        new ObjectiveSetting() { ID = 0, Name = "奥林巴斯", Magnitude = "4X", NA = 0.1, IsEnabled = false },
                        new ObjectiveSetting() { ID = 1, Name = "奥林巴斯", Magnitude = "10X", NA = 0.25, IsChecked = true },
                        new ObjectiveSetting() { ID = 2, Name = "奥林巴斯", Magnitude = "20X", NA = 0.4, IsEnabled = false },
                        new ObjectiveSetting() { ID = 3, Name = "奥林巴斯", Magnitude = "40X", NA = 0.65, IsEnabled = false },
                        new ObjectiveSetting() { ID = 4, Name = "奥林巴斯", Magnitude = "100X", NA = 0.65, IsEnabled = false },
                    },
                CameraExpose = GlobalConst.expose,
                CameraExposeShow = strings,
                CameraResolution = GlobalConst.CameraResolution

            };
            ObjectiveSettingList = deviceInformation.ObjectiveSettingList;

        }

    }
}
