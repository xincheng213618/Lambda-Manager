using Global.Hardware;
using Global.Setting;
using Global.SettingUp;
using System.Collections.Generic;
using System.Linq;


namespace Global
{
    public partial class WindowData
    {

        private void Hardware_Initialized(List<ObjectiveConfig> objectiveList,List<string> objList)
        {
            deviceInformation = new DeviceInformation()
            {
                 CameraResolution = Const.CameraResolution  
            };
            if (objectiveList.Count == 1)
            {
                for (int i = 0; i < objectiveList.Count; i++)
                {
                    ObjectiveSetting objective = new ObjectiveSetting { ID = i, Name = objList[i].ToString(), Magnitude = objectiveList[i].Magnitude, IsEnabled = false,IsChecked = true,NA= objectiveList[i].NA };
                    deviceInformation.ObjectiveSettings.Add(objective);
                }
            }
            else if (objectiveList.Count > 1)
            {
                for (int i = 0; i < objectiveList.Count; i++)
                {


                    ObjectiveSetting objective = new ObjectiveSetting { ID = i, Name = objList[i].ToString(), Magnitude = objectiveList[i].Magnitude, IsEnabled = true, NA = objectiveList[i].NA };
                    if (objectiveList[i] == CurrentObjective)
                    {
                        objective.IsChecked = true;
                    }

                    deviceInformation.ObjectiveSettings.Add(objective);
                }
            }
           
          
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
