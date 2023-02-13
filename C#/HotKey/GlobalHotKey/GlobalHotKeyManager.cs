using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;

namespace HotKey.GlobalHotKey
{
    public class GlobalHotKeyManager
    {
        public IntPtr intPtr = IntPtr.Zero;
        private GlobalHotKeyManager(IntPtr intPtr)
        {
            this.intPtr = intPtr;
        }
        private static readonly object locker = new object();

        public static GlobalHotKeyManager GetInstance(Window window)
        {
            IntPtr intPtr = new WindowInteropHelper(window).EnsureHandle();
            lock (locker) { return new GlobalHotKeyManager(intPtr); }
        }


        public bool Register(HotKeys hotKeys)
        {
            if (hotKeys == null) return false;
            if (hotKeys.Kinds == HotKeyKinds.Global)
            {
                return GlobalHotKey.Register(intPtr, hotKeys.Hotkey.Modifiers, hotKeys.Hotkey.Key, hotKeys.HotKeyHandler);
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
            GlobalHotKey.UnRegister(intPtr, hotKeys.HotKeyHandler);
        }
        public void UnRegister(HotKeyCallBackHanlder callBack)
        {
            GlobalHotKey.UnRegister(intPtr, callBack);
        }

        public bool ModifiedHotkey(HotKeys hotkeys)
        {
            GlobalHotKey.UnRegister(intPtr, hotkeys.HotKeyHandler);
            return hotkeys.Hotkey != null && hotkeys.Hotkey == Hotkey.None && GlobalHotKey.Register(intPtr, hotkeys.Hotkey.Modifiers, hotkeys.Hotkey.Key, hotkeys.HotKeyHandler);
        }

        public void ModifiedHotkey(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (callBack == null) return;
            GlobalHotKey.UnRegister(intPtr, callBack);
            if (hotkey != null) GlobalHotKey.Register(intPtr, hotkey.Modifiers, hotkey.Key, callBack);

        }
    }
    

}
