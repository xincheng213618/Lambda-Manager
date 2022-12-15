using Lambda;
using System;
using System.Windows;

namespace ConfigSetting
{
    public class Calibration
    {
        private static Calibration _instance;
        private static readonly object _locker = new();
        public static Calibration GetInstance() { lock (_locker) { return _instance ??= new Calibration(); } }


        /// <summary>
        /// 获取向导状态
        /// </summary>
        public static event LambdaHandler HardwareCalibrationStateEvent;
        /// <summary>
        /// 获取向导要执行的选项
        /// </summary>
        public static event LambdaHandler GetHardwareCalibrationContentEvent;

        public Calibration()
        {
            LambdaControl.AddLambdaEventHandler("HardwareCalibrationState", (s, e) => {
                Application.Current.Dispatcher.Invoke(delegate {
                    HardwareCalibrationStateInvoke(s, e);
                }); return true;
            }, false);

            LambdaControl.AddLambdaEventHandler("SetHardwareCalibrationContent", (s, e) => {
                Application.Current.Dispatcher.Invoke(delegate {
                    GetHardwareCalibrationContentInvoke(s, e);
                }); return true;
            }, false);
        }

        public static void HardwareCalibrationStateInvoke(object sender, EventArgs e)
        {
            HardwareCalibrationStateEvent?.Invoke(sender, e);
        }
        public static void GetHardwareCalibrationContentInvoke(object sender, EventArgs e)
        {
            GetHardwareCalibrationContentEvent?.Invoke(sender, e);
        }
    }

}
