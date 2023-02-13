using HotKey;
using HotKey.GlobalHotKey;
using HotKey.WindowHotKey;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HotKey
{

    public static partial class HotKeysExtension
    {
        public static bool AddHotKeys(this Window This, HotKeys hotKeys)
        {
            HotKeyHelper.GetInstance().AddHotKeys(This, hotKeys);
            hotKeys.IsRegistered = hotKeys.Kinds == HotKeyKinds.Global ? GlobalHotKeyManager.GetInstance(This).Register(hotKeys) : WindowHotKeyManager.GetInstance(This).Register(hotKeys);
            return hotKeys.IsRegistered;
        }

        public static bool AddHotKeys(this Control This, HotKeys hotKeys) => hotKeys.Kinds != HotKeyKinds.Global && WindowHotKeyManager.GetInstance(This).Register(hotKeys);

        public static bool AddHotKeys(this Window This, Hotkey hotKey, HotKeyCallBackHanlder hotKeyHandler, HotKeyKinds hotKeyKinds = HotKeyKinds.Windows) => hotKeyKinds == HotKeyKinds.Global ? GlobalHotKeyManager.GetInstance(This).Register(hotKey, hotKeyHandler) : WindowHotKeyManager.GetInstance(This).Register(hotKey, hotKeyHandler);
        public static bool AddHotKeysGlobal(this Window This, Hotkey hotKey, HotKeyCallBackHanlder hotKeyHandler) => AddHotKeys(This, hotKey, hotKeyHandler, HotKeyKinds.Global);


    }
    public class HotKeyHelper
    {
        private static HotKeyHelper instance;
        private static readonly object locker = new();
        public static HotKeyHelper GetInstance()
        {
            lock (locker) { return instance ??= new HotKeyHelper(); }
        }

        public static Dictionary<int, HotKeys> HotKeysList = new Dictionary<int, HotKeys>();
        static Dictionary<int, Window> WindowList = new Dictionary<int, Window>();

        int vk = 0;
        public void AddHotKeys(Window window, HotKeys hotKeys)
        {
            HotKeysList.Add(vk, hotKeys);
            WindowList.Add(vk, window);
            vk++;
        }

        public void RegisterHotKeysList()
        {
            foreach (var item in HotKeysList)
            {
                int vk = item.Key;
                HotKeys hotKeys = item.Value;
                Window window = WindowList[vk];
                if (hotKeys.Kinds == HotKeyKinds.Global)
                {
                    GlobalHotKeyManager.GetInstance(window).Register(hotKeys.Hotkey, hotKeys.HotKeyHandler);
                }
                else
                {
                    WindowHotKeyManager.GetInstance(window).Register(hotKeys.Hotkey, hotKeys.HotKeyHandler);
                }
            }
        }
        public void UnRegisterHotKeysList()
        {
            foreach (var item in HotKeysList)
            {
                int vk = item.Key;
                HotKeys hotKeys = item.Value;
                Window window = WindowList[vk];
                if (hotKeys.Kinds == HotKeyKinds.Global)
                {
                    GlobalHotKeyManager.GetInstance(window).UnRegister(hotKeys);
                }
                else
                {
                    WindowHotKeyManager.GetInstance(window).UnRegister(hotKeys);
                }
            }
        }


        public void UnRegisterHotKeys(int vk)
        {
            if (HotKeysList.TryGetValue(vk, out HotKeys hotKeys))
            {
                Window window = WindowList[vk];
                if (hotKeys.Kinds == HotKeyKinds.Global)
                {
                    hotKeys.IsRegistered = GlobalHotKeyManager.GetInstance(window).Register(hotKeys.Hotkey, hotKeys.HotKeyHandler);
                }
                else
                {
                    hotKeys.IsRegistered = WindowHotKeyManager.GetInstance(window).Register(hotKeys.Hotkey, hotKeys.HotKeyHandler);
                }
            }
        }


        public void ModifyHotKeys(int vk)
        {
            if (HotKeysList.TryGetValue(vk, out HotKeys hotKeys))
            {
                Window window = WindowList[vk];
                if (hotKeys.Kinds == HotKeyKinds.Global)
                {
                    GlobalHotKeyManager.GetInstance(window).ModifiedHotkey(hotKeys);
                }
                else
                {
                    WindowHotKeyManager.GetInstance(window).ModifiedHotkey(hotKeys);
                }
            }

        }





    }
}
