using HotKey.GlobalHotKey;
using HotKey.WindowHotKey;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows;
using System.Collections.Generic;

namespace HotKey
{

    public static partial class HotKeysExtension
    {


    }


    [Serializable]
    public class HotKeys : INotifyPropertyChanged
    {
        public static readonly List<HotKeys> HotKeysList = new List<HotKeys>();

        public HotKeys()
        {
            HotKeysList.Add(this);
        }
        public Control Control { get; set; }

        public string Name { get => _Name; set { if (value == _Name) return; _Name = value; NotifyPropertyChanged(); } }
        private string _Name = string.Empty;


        public HotKeyCallBackHanlder HotKeyHandler;
        public Hotkey Hotkey
        {
            get => _Hotkey;  set  
            {
                if (value == _Hotkey) return; 
                _Hotkey = value;
                //如果已经注册，在修改方法的时候，检测是否注册成功
                if (Control!=null)
                    if (Kinds == HotKeyKinds.Global)
                    {
                        IsRegistered = GlobalHotKeyManager.GetInstance(Window.GetWindow(Control)).ModifiedHotkey(this);
                    }
                    else
                    {
                        IsRegistered = WindowHotKeyManager.GetInstance(Control).ModifiedHotkey(this);
                    }
                NotifyPropertyChanged(); 
            }
        }
        private Hotkey _Hotkey = Hotkey.None;


        public HotKeyKinds Kinds { get => _Kinds; set { if (value == _Kinds) return; _Kinds = value; NotifyPropertyChanged(); } }
        private HotKeyKinds _Kinds = HotKeyKinds.Windows;



        /// <summary>
        /// 不允许外部写入
        /// </summary>
        public bool IsRegistered { get => _IsRegistered; internal set { _IsRegistered = value; NotifyPropertyChanged(); } }
        private bool _IsRegistered = false;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
