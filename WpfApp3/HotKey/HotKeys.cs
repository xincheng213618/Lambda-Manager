using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKey
{
    [Serializable]
    public class HotKeys :INotifyPropertyChanged
    {
        public string FunctionName;
        public HotKeyCallBackHanlder hotKeyHandler;
        public Hotkey Hotkey;
        public HotKeyKinds Kinds;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool sucess= false;
        public bool Sucess
        {
            get => sucess;
            set
            {
                sucess = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sucess"));
            }
        }

    }
}
