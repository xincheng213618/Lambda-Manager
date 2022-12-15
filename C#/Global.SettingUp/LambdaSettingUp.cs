using Lambda;
using System.Windows;

namespace Global.SettingUp
{
    public class LambdaSettingUp
    {
        private static LambdaSettingUp _instance;
        private static readonly object _locker = new();
        public static LambdaSettingUp GetInstance() { lock (_locker) { return _instance ??= new LambdaSettingUp(); } }



        /// <summary>
        /// 硬件连接状态
        /// </summary>
        public static event LambdaHandler HardwareSettingConnectionEvent;

        public LambdaSettingUp()
        {
            LambdaControl.AddLambdaEventHandler("LambdaNotifyPropertyChanged", (s, e) =>
            {
                Application.Current.Dispatcher.Invoke(delegate
                {
                    HardwareSettingConnectionEvent(s, e);
                }); return true;
            }, false);

        }

        public static void LambdaNotifyPropertyChangedInvoke(object sender, EventArgs e)
        {
            HardwareSettingConnectionEvent?.Invoke(sender, e);
        }
    }
}
