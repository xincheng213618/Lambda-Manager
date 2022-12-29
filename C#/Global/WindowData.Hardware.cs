using Global.Hardware;
using Global.Setting;
using Global.SettingUp;
using System.Collections.Generic;
using System.Linq;


namespace Global
{
    public partial class WindowData
    {

        private void Hardware_Initialized(List<string> objectiveList)
        {
            deviceInformation = new DeviceInformation()
            {
                 CameraResolution = Const.CameraResolution  
            };
            if (objectiveList.Count == 1)
            {
                for (int i = 0; i < objectiveList.Count; i++)
                {
                    ObjectiveSetting objective = new ObjectiveSetting { ID = i, Name = "奥林巴斯", Magnitude = objectiveList[i], IsEnabled = false,IsChecked = true };
                    deviceInformation.ObjectiveSettings.Add(objective);
                }
            }
            else if (objectiveList.Count > 1)
            {
                for (int i = 0; i < objectiveList.Count; i++)
                {
                    ObjectiveSetting objective = new ObjectiveSetting { ID = i, Name = "奥林巴斯", Magnitude = objectiveList[i], IsEnabled = true };
                    deviceInformation.ObjectiveSettings.Add(objective);
                }
            }
           
            //ObjectiveSettings = new() {

            //            new ObjectiveSetting() { ID = 0, Name = "奥林巴斯", Magnitude = "10X", NA = 0.1, IsEnabled = true },
            //            new ObjectiveSetting() { ID = 1, Name = "奥林巴斯", Magnitude = "10PX", NA = 0.25, IsEnabled = true  },
            //            new ObjectiveSetting() { ID = 2, Name = "奥林巴斯", Magnitude = "20X", NA = 0.4, IsEnabled = true },
            //            new ObjectiveSetting() { ID = 3, Name = "奥林巴斯", Magnitude = "40X", NA = 0.65, IsEnabled = true },
            //            //new ObjectiveSetting() { ID = 4, Name = "奥林巴斯", Magnitude = "100X", NA = 0.65, IsEnabled = false },
            //        },
            //List<string> strings = new List<string>();
            for (int i = 0; i < Const.expose.Count; i++)
            {
                ExposureViewMode.ExposureInfos.Add(new ExposureInfo() { ExposureShow = $"1/{Const.expose[i]:0.######}",Exposure = 1 /Const.expose[i] });
            }
            foreach (var item in Const.expose1)
            {
                ExposureViewMode.ExposureInfos.Add(new ExposureInfo() { ExposureShow = item.ToString("0.######"), Exposure = item });
            }
        }

    }
}
