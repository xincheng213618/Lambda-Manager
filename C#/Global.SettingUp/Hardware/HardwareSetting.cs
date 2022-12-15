using Global.Common;
using Global.Common.Extensions;
using Global.Common.Util;
using Global.SettingUp.PC;
using Lambda;

namespace Global.SettingUp.Hardware
{

    public class HardwareSetting : ViewModelBase
    {
        public static string RegPath = "Software\\Grid";

        public HardwareSetting()
        {
            LambdaSettingUp.HardwareSettingConnectionEvent += LambdaNotifyPropertyChanged;
            LambdaControl.Trigger("SeachHardwareSettingConnection", this, new Dictionary<string, object>());
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


        /// <summary>
        /// 是否初始化向导
        /// </summary>
        public bool IsIniWizard { get => _IsIniWizard; set { _IsIniWizard = value; NotifyPropertyChanged();  Reg.WriteValue(RegPath, nameof(IsIniWizard), IsIniWizard); } }
        private bool _IsIniWizard = Reg.ReadValue(RegPath, nameof(IsIniWizard), false);

        /// <summary>
        /// 相机状态
        /// </summary>
        public CameraStatus CameraStatus { get => _CameraStatus; set { _CameraStatus = value; NotifyPropertyChanged(); } }
        private CameraStatus _CameraStatus = CameraStatus.DisConnection;

        /// <summary>
        /// 相机连接情况
        /// </summary>
        public bool IsCameraConnection { get => _IsCameraConnection; set { _IsCameraConnection = value; NotifyPropertyChanged(); } }
        public bool _IsCameraConnection = false;

        /// <summary>
        /// 位移台状态
        /// </summary>
        public SerialPortStatus StageStatus { get => _StageStatus; set { _StageStatus = value; NotifyPropertyChanged(); } }
        private SerialPortStatus _StageStatus = SerialPortStatus.UnknownError;

        /// <summary>
        /// 位移台连接情况
        /// </summary>
        public bool IsStageConnection { get => _IsStageConnection; set { _IsStageConnection = value; NotifyPropertyChanged(); } }
        private bool _IsStageConnection = false;
        
        /// <summary>
        /// 光源状态
        /// </summary>
        public SerialPortStatus LightStatus { get => _LightStatus; set { _LightStatus = value; NotifyPropertyChanged(); } }
        private SerialPortStatus _LightStatus = SerialPortStatus.UnknownError;

        /// <summary>
        /// 光源连接情况
        /// </summary>
        public bool IsLightConnection { get => _IsLightConnection; set { _IsLightConnection = value; NotifyPropertyChanged(); } }
        private bool _IsLightConnection = false;

    }
}
