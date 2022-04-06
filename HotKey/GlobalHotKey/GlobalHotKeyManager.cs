using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace HotKey.GlobalHotKey
{
    public class GlobalHotKeyManager
    {
        public IntPtr intPtr = IntPtr.Zero;
        private GlobalHotKeyManager(Window window)
        {
            intPtr = new WindowInteropHelper(window).EnsureHandle();
        }

        private static GlobalHotKeyManager instance;
        private static readonly object locker = new object();

        public static GlobalHotKeyManager GetInstance(Window window)
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回
                if (instance == null)
                {
                    instance = new GlobalHotKeyManager(window);
                }
            }
            return instance;
        }
        public bool Register(HotKeys hotKeys)
        {
            if (hotKeys == null) return false;
            if (hotKeys.Kinds == HotKeyKinds.Windows)
            {
                return GlobalHotKey.Register(intPtr, hotKeys.Hotkey.Modifiers, hotKeys.Hotkey.Key, hotKeys.hotKeyHandler);
            }
            return false;
        }

        public bool Register(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (hotkey == null) return false;
            return GlobalHotKey.Register(intPtr, hotkey.Modifiers, hotkey.Key, callBack);
        }
        public bool Register(ModifierKeys modifierKeys, Key key, HotKeyCallBackHanlder callBack)
        {
            return GlobalHotKey.Register(intPtr, modifierKeys, key, callBack);
        }

        public void UnRegister(HotKeys hotKeys)
        {
            GlobalHotKey.UnRegister(intPtr, hotKeys.hotKeyHandler);
        }
        public void UnRegister(HotKeyCallBackHanlder callBack)
        {
            GlobalHotKey.UnRegister(intPtr, callBack);
        }

        public void ModifiedHotkey(HotKeys hotkeys)
        {
            GlobalHotKey.UnRegister(intPtr, hotkeys.hotKeyHandler);
            if (hotkeys.Hotkey != null)
            {
                GlobalHotKey.Register(intPtr, hotkeys.Hotkey.Modifiers, hotkeys.Hotkey.Key, hotkeys.hotKeyHandler);
            }
        }

        public void ModifiedHotkey(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (callBack == null) return;
            GlobalHotKey.UnRegister(intPtr, callBack);
            if (hotkey != null) GlobalHotKey.Register(intPtr, hotkey.Modifiers, hotkey.Key, callBack);

        }
    }
    

}
