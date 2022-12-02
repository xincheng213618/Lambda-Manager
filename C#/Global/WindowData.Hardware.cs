using Global.Hardware;
using Global.SettingUp;
using System.Collections.Generic;
using System.Linq;


namespace Global
{
    public partial class WindowData
    {

        private void Hardware_Initialized()
        {
            deviceInformation = new DeviceInformation()
            {
                ObjectiveSettings = new() {
                        new ObjectiveSetting() { ID = 0, Name = "奥林巴斯", Magnitude = "4X", NA = 0.1, IsEnabled = false },
                        new ObjectiveSetting() { ID = 1, Name = "奥林巴斯", Magnitude = "10X", NA = 0.25, IsChecked = true },
                        new ObjectiveSetting() { ID = 2, Name = "奥林巴斯", Magnitude = "20X", NA = 0.4, IsEnabled = true },
                        new ObjectiveSetting() { ID = 3, Name = "奥林巴斯", Magnitude = "40X", NA = 0.65, IsEnabled = false },
                        new ObjectiveSetting() { ID = 4, Name = "奥林巴斯", Magnitude = "100X", NA = 0.65, IsEnabled = false },
                    },
                CameraResolution = Const.CameraResolution
            };

            List<string> strings = new List<string>();
            for (int i = 0; i < Const.expose.Count; i++)
            {
                ExposureViewMode.ExposureInfos.Add(new ExposureInfo() { ExposureShow = $"1/{Const.expose[i]:0.######}",Exposure = 1 / Const.expose[i] });
            }
            foreach (var item in Const.expose1)
            {
                ExposureViewMode.ExposureInfos.Add(new ExposureInfo() { ExposureShow = item.ToString("0.######"), Exposure = item });
            }
        }

    }
}
