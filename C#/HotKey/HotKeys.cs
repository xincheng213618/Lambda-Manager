using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HotKey
{
    [Serializable]
    public class HotKeys :INotifyPropertyChanged
    {
        public string FunctionName { get; set; }
        public HotKeyCallBackHanlder hotKeyHandler;
        public Hotkey Hotkey;
        public HotKeyKinds Kinds;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// 是否绑定成功
        /// </summary>
        public bool Sucess { get => _Sucess; set { _Sucess = value; NotifyPropertyChanged(); } }
        private bool _Sucess = false;

    }
}
