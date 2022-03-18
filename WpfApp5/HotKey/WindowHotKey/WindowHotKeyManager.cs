using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotKey.WindowHotKey
{
    public class WindowHotKeyManager
    {
        public Window window;
        private static WindowHotKeyManager instance;
        private static readonly object locker = new object();

        private WindowHotKeyManager(Window window)
        {
            this.window = window;
        }

        public static WindowHotKeyManager GetInstance(Window window)
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回
                if (instance == null)
                {
                    instance = new WindowHotKeyManager(window);
                }
            }
            return instance;
        }
        static Dictionary<int, HotKeyCallBackHanlder> keymap = new Dictionary<int, HotKeyCallBackHanlder>();
        static Dictionary<Window, bool> WindowHook = new Dictionary<Window, bool>();


        public bool Register(HotKeys hotkeys)
        {
            WindowHotKey.Register(window, hotkeys.Hotkey, hotkeys.hotKeyHandler);
            return true;
        }

        public bool Register(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            WindowHotKey.Register(window,hotkey, callBack);
            return true;
        }

    }
}
