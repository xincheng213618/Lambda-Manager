using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Global.Common
{
    /// <summary>
    /// 实例化一个Mode
    /// </summary>
    public class ViewModeBase :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 触发消息通知事件
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
