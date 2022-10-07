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
        /// 触发消息通知事件
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //使用CallerMemberName可以在传参的时候，少些几行代码，还是比较方便的，但是这个名称好像不是很规范，可以在之后统一一下
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
