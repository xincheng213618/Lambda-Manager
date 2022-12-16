using Global.Common.Util;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Global.Common
{
    /// <summary>
    /// 实例化一个Mode
    /// </summary>
    public abstract class ViewModelBase :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 消息通知事件
        /// </summary>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


    public abstract class ViewModelReg: ViewModelBase
    {
        public static string RegPath = "Software\\Grid";

        public static void WriteRegValue(object value, [CallerMemberName] string name = "") => Reg.WriteValue(RegPath, name, value);

        public static bool ReadRegValue(bool def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name, def);



        public static bool ReadRegValue([CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name);

        public static string ReadRegValue(string def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name,def);

        public static int ReadRegValue(int def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name, def);



    }
}
