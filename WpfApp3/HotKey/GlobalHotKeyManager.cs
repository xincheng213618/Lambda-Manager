using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace HotKey.GlobalHotKey
{
    public class GlobalHotKeyManager
    {
        public IntPtr intPtr = IntPtr.Zero;
        public GlobalHotKeyManager(Window window)
        {
            intPtr = new WindowInteropHelper(window).EnsureHandle();
        }

        public bool Register(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (hotkey == null) return false;
            return GlobalHotKey.Regist(intPtr, hotkey.Modifiers, hotkey.Key, callBack);
        }


        public void UnRegister(HotKeyCallBackHanlder callBack)
        {
            GlobalHotKey.UnRegist(intPtr, callBack);
        }
        /// <summary>
        /// 修改快捷键时
        /// </summary>
        /// <param name="fsModifiers"></param>
        /// <param name="key"></param>
        /// <param name="callBack"></param>
        public void ReRegister(Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            GlobalHotKey.UnRegist(intPtr, callBack);
            GlobalHotKey.Regist(intPtr, hotkey.Modifiers, hotkey.Key, callBack);
        }
    }
    

}
