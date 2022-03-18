using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Windows.Interop;

namespace GlobalHotKey
{
    /// <summary>
    /// 热键管理器
    /// </summary>
    public class HotKeyManager
    {
        public delegate void HotKeyCallBackHanlder();

        static Dictionary<int, HotKeyCallBackHanlder> keymap = new Dictionary<int, HotKeyCallBackHanlder>();
        static int keyid = 0;

        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="window">持有快捷键窗口</param>
        /// <param name="fsModifiers">组合键</param>
        /// <param name="key">快捷键</param>
        /// <param name="callBack">回调函数</param>
        public static void Regist(IntPtr hwnd, ModifierKeys fsModifiers, Key key, HotKeyCallBackHanlder callBack)
        {
            HwndSource _hwndSource = HwndSource.FromHwnd(hwnd);
            _hwndSource.AddHook(WndProc);

            int id = keyid++;
            int vk = KeyInterop.VirtualKeyFromKey(key);
            if (!HotKey.RegisterHotKey(hwnd, id, fsModifiers, (uint)vk))
                throw new Exception("regist hotkey fail.");
            keymap[id] = callBack;
        }

        /// <summary>
        /// 可以自定义id
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="id"></param>
        /// <param name="fsModifiers"></param>
        /// <param name="key"></param>
        /// <param name="callBack"></param>
        public static void Regist(IntPtr hwnd, int id , ModifierKeys fsModifiers, Key key, HotKeyCallBackHanlder callBack)
        {
            HwndSource.FromHwnd(hwnd).AddHook(WndProc);
            int vk = KeyInterop.VirtualKeyFromKey(key);
            if (!HotKey.RegisterHotKey(hwnd, id, fsModifiers, (uint)vk))
                throw new Exception("regist hotkey fail.");
            keymap[id] = callBack;
        }


        /// <summary>
        /// 快捷键消息处理
        /// </summary>
        static IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            //https://wiki.winehq.org/List_Of_Windows_Messages
            if (msg == HotKey.WM_HOTKEY)
            {
                int id = wParam.ToInt32();
                if (keymap.TryGetValue(id, out var callback))
                {
                    callback();
                }
            }
            return IntPtr.Zero;
        }

        /// <summary>
        /// 注销快捷键
        /// </summary>
        /// <param name="hWnd">持有快捷键窗口的句柄</param>
        /// <param name="callBack">回调函数</param>
        public static void UnRegist(IntPtr hWnd, HotKeyCallBackHanlder callBack)
        {
            foreach (KeyValuePair<int, HotKeyCallBackHanlder> var in keymap)
            {
                if (var.Value == callBack)
                    HotKey.UnregisterHotKey(hWnd, var.Key);
            }
        }

    }
}
