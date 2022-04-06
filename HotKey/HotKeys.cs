using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HotKey
{
    [Serializable]
    public class HotKeys :INotifyPropertyChanged
    {
        public string FunctionName;
        public HotKeyCallBackHanlder hotKeyHandler;
        public Hotkey Hotkey;
        public HotKeyKinds Kinds;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyyName)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool sucess= false;
        public bool Sucess
        {
            get => sucess;
            set
            {
                sucess = value;
                NotifyPropertyChanged();
            }
        }

    }
}
