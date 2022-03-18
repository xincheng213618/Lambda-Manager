using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Windows.Interop;

namespace HotKey.GlobalHotKey
{

    /// <summary>
    /// 热键管理器
    /// </summary>
    public static class GlobalHotKey
    {
        /// <summary>
        /// 热键消息
        /// </summary>
        public const int WM_HOTKEY = 0x312;

        /// <summary>
        /// 注册热键
        /// </summary>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, ModifierKeys fsModifuers, uint vk);

        /// <summary>
        /// 注销热键
        /// </summary>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// 向原子表中添加全局原子
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern short GlobalAddAtom(string lpString);

        /// <summary>
        /// 在表中搜索全局原子
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern short GlobalFindAtom(string lpString);

        /// <summary>
        /// 在表中删除全局原子
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern short GlobalDeleteAtom(short nAtom);



        static Dictionary<int, HotKeyCallBackHanlder> keymap = new Dictionary<int, HotKeyCallBackHanlder>();
        static Dictionary<HwndSource, bool> HwndHock = new Dictionary<HwndSource, bool>();
        static int keyid = 0;

        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="window">持有快捷键窗口</param>
        /// <param name="fsModifiers">组合键</param>
        /// <param name="key">快捷键</param>
        /// <param name="callBack">回调函数</param>
        public static bool Regist(IntPtr hwnd, ModifierKeys fsModifiers, Key key, HotKeyCallBackHanlder callBack)
        {
            HwndSource _hwndSource = HwndSource.FromHwnd(hwnd);
            if (HwndHock.TryGetValue(_hwndSource ,out bool bool1))
            {
                if (!bool1)
                    _hwndSource.AddHook(WndProc);
            }
            else
            {
                _hwndSource.AddHook(WndProc);
                HwndHock.Add(_hwndSource, true);
            }
            int id = keyid++;
            int vk = KeyInterop.VirtualKeyFromKey(key);

            if (!RegisterHotKey(hwnd, id, fsModifiers, (uint)vk))
            {
                return false;
            }
            else
            {
                keymap[id] = callBack;
                return true;
            }
        }

        /// <summary>
        /// 可以自定义id
        /// </summary>
        public static bool Regist(IntPtr hwnd, int id , ModifierKeys fsModifiers, Key key, HotKeyCallBackHanlder callBack)
        {
            HwndSource _hwndSource = HwndSource.FromHwnd(hwnd);
            if (HwndHock.TryGetValue(_hwndSource, out bool bool1))
            {
                if (!bool1)
                    _hwndSource.AddHook(WndProc);
            }
            else
            {
                _hwndSource.AddHook(WndProc);
                HwndHock.Add(_hwndSource, true);
            }
            int vk = KeyInterop.VirtualKeyFromKey(key);
            if (!RegisterHotKey(hwnd, id, fsModifiers, (uint)vk))
            {
                UnregisterHotKey(hwnd, id);
                return false;
            }
            else
            {
                keymap[id] = callBack;
                return true;
            }
        }

        /// <summary>
        /// 快捷键消息处理
        /// </summary>
        static IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            //https://wiki.winehq.org/List_Of_Windows_Messages
            if (msg == WM_HOTKEY)
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
                    UnregisterHotKey(hWnd, var.Key);
            }
        }

    }
}
