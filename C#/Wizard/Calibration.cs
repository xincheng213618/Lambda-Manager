using Lambda;
using System;
using System.Windows;

namespace Wizard
{
    public static class INIT
    {
        public static Calibration Calibration = Calibration.GetInstance();
    }

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
                    HardwareCalibrationStateEvent?.Invoke(s, e);
                }); return true;
            }, false);

            LambdaControl.AddLambdaEventHandler("SetHardwareCalibrationContent", (s, e) => {
                Application.Current.Dispatcher.Invoke(delegate {
                    GetHardwareCalibrationContentEvent?.Invoke(s, e);
                }); return true;
            }, false);
        }

    }

}
