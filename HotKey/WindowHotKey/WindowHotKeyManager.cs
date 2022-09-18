using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace HotKey.WindowHotKey
{



    public class WindowHotKeyManager
    {
        public static Dictionary<Window, WindowHotKeyManager> Instance = new Dictionary<Window, WindowHotKeyManager>(); 

        public Window window;

        public WindowHotKeyManager(Window window)
        {
            this.window = window;
            Instance.Add(window, this);
            HotKeysList = new List<HotKeys>();
        }

        public List<HotKeys> HotKeysList;


        public bool Register(HotKeys hotkeys)
        {
            WindowHotKey.Register(window, hotkeys.Hotkey, hotkeys.hotKeyHandler);
            HotKeysList.Add(hotkeys);
            return true;
        }

        public bool Register(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            WindowHotKey.Register(window,hotkey, callBack);
            HotKeysList.Add(new HotKeys() { Hotkey =hotkey,hotKeyHandler = callBack});
            return true;
        }

        public bool UnRegister(HotKeys hotkeys)
        {
            WindowHotKey.UnRegister(hotkeys.hotKeyHandler);
            HotKeysList.Remove(hotkeys);
            return true;
        }

        public bool UnRegister(HotKeyCallBackHanlder callBack)
        {
            WindowHotKey.UnRegister(callBack);
            foreach (var item in HotKeysList)
            {
                if (callBack == item.hotKeyHandler)
                {
                    HotKeysList.Remove(item);
                }
            }
            return true;
        }


        public void ModifiedHotkey(HotKeys hotkeys)
        {
            WindowHotKey.UnRegister(hotkeys.hotKeyHandler);
            WindowHotKey.Register(window, hotkeys.Hotkey, hotkeys.hotKeyHandler);

            foreach (var item in HotKeysList)
            {
                if (hotkeys.hotKeyHandler == item.hotKeyHandler)
                {
                    HotKeysList.Remove(item);
                }
            }
            HotKeysList.Add(hotkeys);

        }

        public void ModifiedHotkey(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            WindowHotKey.UnRegister(callBack);
            WindowHotKey.Register(window, hotkey, callBack);

            foreach (var item in HotKeysList)
            {
                if (callBack == item.hotKeyHandler)
                {
                    HotKeysList.Remove(item);
                }
            }
            HotKeysList.Add(new HotKeys() { Hotkey = hotkey, hotKeyHandler = callBack });
        }

    }
}
