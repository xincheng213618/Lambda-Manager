using Global.Common;
using Global.Common.Extensions;
using Global.Common.Util;
using Global.SettingUp.PC;
using Lambda;

namespace Global.SettingUp.Hardware
{

    public class HardwareSetting : ViewModelBase
    {
        public HardwareSetting()
        {
            LambdaControl.AddLambdaEventHandler("LambdaNotifyPropertyChanged", LambdaNotifyPropertyChanged, false);
            LambdaControl.Trigger("SeachHardwareSettingConnection ", this, new Dictionary<string, object>());
        }
        public bool LambdaNotifyPropertyChanged(object sender, EventArgs e)
        {
            Dictionary<string, object> eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            if (eventData.GetValue("IsCameraConnection") is bool value)
            {
                IsCameraConnection = value;
            }
            else if (eventData.GetValue("IsCameraConnection") is int CameraConnection)
            {
                CameraStatus = (CameraStatus)CameraConnection;
                IsCameraConnection = CameraStatus == CameraStatus.Ok;
            }
            if (eventData.GetValue("IsStageConnection") is bool value1)
            {
                IsStageConnection = value1;
            }
            else if (eventData.GetValue("IsStageConnection") is int StageConnection)
            {
                StageStatus = (StageStatus)StageConnection;
                IsStageConnection = StageStatus == StageStatus.Ok;
            }
            if (eventData.GetValue("IsLightConnection") is bool value2)
            {
                IsLightConnection = value2;
            }
            else if (eventData.GetValue("IsLightConnection") is int LightConnection)
            {
                LightStatus = (LightStatus)LightConnection;
                IsLightConnection = LightStatus == LightStatus.Ok;
            }
            return true;
        }

        public GPUInfo GPUInfo = new GPUInfo();

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

        private CameraStatus cameraStatus;
        public CameraStatus CameraStatus
        {
            get { return cameraStatus; }
            set
            {
                cameraStatus = value;
                NotifyPropertyChanged();
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

        private StageStatus stageStatus;
        public StageStatus StageStatus
        {
            get { return stageStatus; }
            set
            {
                stageStatus = value;
                NotifyPropertyChanged();
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

        private LightStatus lightStatus;
        public LightStatus LightStatus
        {
            get { return lightStatus; }
            set
            {
                lightStatus = value;
                NotifyPropertyChanged();
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
}
