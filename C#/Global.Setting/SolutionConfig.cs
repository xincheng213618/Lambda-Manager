using Global.Common.Extensions;
using Global.Common.Util;
using Lambda;

namespace Global.Common
{



    /// <summary>
    /// 先放这里后面再拆
    /// </summary>
    public static class SolutionConfig
    {
        public static SolutionSetting SolutionSetting = new SolutionSetting();
        public static HardwareSetting HardwareSetting = new HardwareSetting();   
    }



    public class HardwareSetting : ViewModelBase
    {
        public HardwareSetting()
        {
            LambdaControl.AddLambdaEventHandler("LambdaNotifyPropertyChanged", LambdaNotifyPropertyChanged, false);
            Lambda.LambdaControl.Trigger("SeachHardwareSettingConnection ", this, new Dictionary<string, object>());
        }
        public bool LambdaNotifyPropertyChanged(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            if (eventData.GetValue("IsCameraConnection") is bool value)
                IsCameraConnection = value;
            if (eventData.GetValue("IsStageConnection") is bool value1)
                IsStageConnection = value1;
            if (eventData.GetValue("IsLightConnection") is bool value2)
                IsLightConnection = value2;
            

            return true;
        }


        public static string RegPath = "Software\\Grid";

        private bool isIniWizard = Reg.ReadValue(RegPath, nameof(IsIniWizard), false);
        public bool IsIniWizard
        {
            get { return isIniWizard; }
            set
            {
                if (isIniWizard != value)
                {
                    isIniWizard = value;
                    Reg.WriteValue(RegPath, nameof(IsIniWizard), IsIniWizard);
                    NotifyPropertyChanged();
                }
            }
        }

        public bool isCameraConnection = false;

        public bool IsCameraConnection
        {
            get { return isCameraConnection; }
            set
            {
                if (isCameraConnection != value)
                {
                    isCameraConnection = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool isStageConnection = false;

        public bool IsStageConnection
        {
            get { return isStageConnection; }
            set
            {
                if (isStageConnection != value)
                {
                    isStageConnection = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool isLightConnection = false;

        public bool IsLightConnection
        {
            get { return isLightConnection; }
            set
            {
                if (isLightConnection != value)
                {
                    isLightConnection = value;
                    NotifyPropertyChanged();
                }
            }
        }



    }

    /// <summary>
    /// Solution环境
    /// </summary>
    public class SolutionSetting : ViewModelBase
    {

        private bool isSupportMultiProject = Reg.ReadValue("Software\\Grid", "isSupportMultiProject", false);
        public bool IsSupportMultiProject
        {
            get { return isSupportMultiProject; }
            set
            {
                if (isSupportMultiProject!=value) {
                    isSupportMultiProject = value;
                    Reg.WriteValue("Software\\Grid", "isSupportMultiProject", isSupportMultiProject);
                    NotifyPropertyChanged();
                }

            }
        }
    }
}
