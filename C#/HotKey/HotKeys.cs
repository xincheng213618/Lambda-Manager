using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HotKey
{
    [Serializable]
    public class HotKeys :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        public string FunctionName { get; set; }
        public HotKeyCallBackHanlder hotKeyHandler;
        public Hotkey Hotkey;
        public HotKeyKinds Kinds;



        /// <summary>
        /// 是否绑定成功
        /// </summary>
        public bool IsRegistered { get => _IsRegistered; set { _IsRegistered = value; NotifyPropertyChanged(); } }
        private bool _IsRegistered = false;

    }
}
