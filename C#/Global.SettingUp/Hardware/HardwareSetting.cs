using Global.Common;
using Global.Common.Extensions;
using Global.Common.Util;
using Global.SettingUp.PC;
using Lambda;
using System.Windows;

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

            if (eventData.GetValue("IsCameraConnection") is int CameraConnection)
            {
                CameraStatus = (CameraStatus)CameraConnection;
                IsCameraConnection = CameraStatus == CameraStatus.Ok;
            }
            if (eventData.GetValue("IsStageConnection") is int StageConnection)
            {
                StageStatus = (SerialPortStatus)StageConnection;
                IsStageConnection = StageStatus == SerialPortStatus.NoError;
            }
            if (eventData.GetValue("IsLightConnection") is int LightConnection)
            {
                LightStatus = (SerialPortStatus)LightConnection;
                IsLightConnection = LightStatus == SerialPortStatus.NoError;
            }
            return true;
        }

        public GPUInfo GPUInfo = new GPUInfo();
        public PerformanceSetting PerformanceSetting = new PerformanceSetting();


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

        private CameraStatus cameraStatus = CameraStatus.DisConnection;
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

        private SerialPortStatus stageStatus = SerialPortStatus.UnknownError;
        public SerialPortStatus StageStatus
        {
            get { return stageStatus; }
            set
            {
                stageStatus = value;
                NotifyPropertyChanged();
            }
        }


        private bool isStageConnection = false;

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

        private SerialPortStatus lightStatus = SerialPortStatus.UnknownError;
        public SerialPortStatus LightStatus
        {
            get { return lightStatus; }
            set
            {
                lightStatus = value;
                NotifyPropertyChanged();
            }
        }


        private bool isLightConnection = false;

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
