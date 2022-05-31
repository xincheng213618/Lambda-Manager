using Global.Extensions;
using Global.Hardware;
using Global.Mode.Config;
using Newtonsoft.Json;

namespace Global
{
    public partial class WindowData
    {

        private void Hardware_Initialized()
        {
            if (File.Exists(Global.HardwareDeviceInformationSheet))
            {
                string HardwareDeviceInformation = Utils.LoadResource(Global.HardwareDeviceInformationSheet);
                if (!string.IsNullOrEmpty(HardwareDeviceInformation))
                {
                    deviceInformation = JsonConvert.DeserializeObject<DeviceInformation>(HardwareDeviceInformation);
                    ObjectiveSettingList = deviceInformation.ObjectiveSettingList;
                }
            }
            else
            {
                List<string> strings = new List<string>();
                for (int i = 0; i < Global.expose.Count; i++)
                {
                    strings.Add($"1/{Global.expose[i]:0.######}");
                    Global.expose[i] = 1 / Global.expose[i];
                }
                Global.expose.AddRange(Global.expose1);
                strings.AddRange(Global.expose1.Select(x => x.ToString("0.######")).ToArray());

                deviceInformation = new DeviceInformation()
                {
                    ObjectiveSettingList = new() {
                        new ObjectiveSetting() { ID = 0, Name = "奥林巴斯", Magnitude = "4X", NA = 0.1, IsEnabled = false },
                        new ObjectiveSetting() { ID = 1, Name = "奥林巴斯", Magnitude = "10X", NA = 0.25, IsChecked = true },
                        new ObjectiveSetting() { ID = 2, Name = "奥林巴斯", Magnitude = "20X", NA = 0.4, IsEnabled = false },
                        new ObjectiveSetting() { ID = 3, Name = "奥林巴斯", Magnitude = "40X", NA = 0.65, IsEnabled = false },
                        new ObjectiveSetting() { ID = 4, Name = "奥林巴斯", Magnitude = "100X", NA = 0.65, IsEnabled = false },
                    },
                    CameraExpose = Global.expose,
                    CameraExposeShow = strings

                };
                deviceInformation.ToJsonFile(Global.HardwareDeviceInformationSheet);
                ObjectiveSettingList = deviceInformation.ObjectiveSettingList;
            }
        }

    }
}
