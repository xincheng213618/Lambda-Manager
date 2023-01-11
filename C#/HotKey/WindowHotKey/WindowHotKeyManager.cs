using HotKey.GlobalHotKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

        private static readonly object locker = new object();

        public Window window;

        private WindowHotKeyManager(Window window)
        {
            this.window = window;
            Instance.Add(window, this);
            HotKeysList = new List<HotKeys>();
        }

        private static WindowHotKeyManager instance;

        public static WindowHotKeyManager GetInstance(Window window)
        {
            lock (locker)
            {
                if (Instance.ContainsKey(window))
                {
                    return Instance[window];
                }
                else
                {
                    instance = new WindowHotKeyManager(window);
                }
            }
            return instance;
        }




        public List<HotKeys> HotKeysList;


        public bool Register(HotKeys hotkeys)
        {
            hotkeys.IsRegistered = WindowHotKey.Register(window, hotkeys.Hotkey, hotkeys.hotKeyHandler);
            HotKeysList.Add(hotkeys);
            return true;
        }

        public bool Register(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (!WindowHotKey.Register(window, hotkey, callBack))
                return false;
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
