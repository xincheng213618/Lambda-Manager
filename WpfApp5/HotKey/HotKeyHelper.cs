using HotKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotKey
{
    public class HotKeyHelper
    {
        private static HotKeyHelper instance;  
        private static readonly object locker = new object();

        public static HotKeyHelper GetInstance()
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回
                if (instance == null)
                {
                    instance = new HotKeyHelper();
                }
            }
            return instance;
        }

        public List<HotKeys> HotKeysList = new List<HotKeys>();

        public void SetHotKeys(Window window, HotKeys hotKeys)
        {
            foreach (var item in HotKeysList)
            {
                if (item.Kinds == HotKeyKinds.Global)
                {
                    GlobalHotKeyManager.GetInstance(window).ModifiedHotkey(hotKeys.Hotkey, hotKeys.hotKeyHandler);
                }
                else
                {
                    WindowHotKeyManager.GetInstance(window).Register(hotKeys.Hotkey,hotKeys.hotKeyHandler);
                }
            }       
        }

        



    }
}
