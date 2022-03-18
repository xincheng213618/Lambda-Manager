using GlobalHotKey;
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

        public void Register(ModifierKeys fsModifiers, Key key, HotKeyManager.HotKeyCallBackHanlder callBack)
        {
            //HotKeyManager.Regist(intPtr, fsModifiers, key, callBack);
        }


        public void UnRegister(HotKeyManager.HotKeyCallBackHanlder callBack)
        {
            HotKeyManager.UnRegist(intPtr, callBack);
        }
        /// <summary>
        /// 修改快捷键时
        /// </summary>
        /// <param name="fsModifiers"></param>
        /// <param name="key"></param>
        /// <param name="callBack"></param>
        public void ReRegister(ModifierKeys fsModifiers, Key key, HotKeyManager.HotKeyCallBackHanlder callBack)
        {
            HotKeyManager.UnRegist(intPtr, callBack);
            HotKeyManager.Regist(intPtr, fsModifiers, key, callBack);
        }
    }



    public class HotKeyModel
    {
        /// <summary>
        /// 设置项名称
        /// </summary>
        public string Name { get; set; }

        public ModifierKeys modifierKeys { get; set; }

        /// <summary>
        /// 选中的按键
        /// </summary>
        public Key Key { get; set; }

    }


}
