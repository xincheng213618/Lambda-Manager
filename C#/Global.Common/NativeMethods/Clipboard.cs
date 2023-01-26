using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace Global.Common.NativeMethods
{
    public static class Clipboard
    {
        [DllImport("User32")]
        public static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("User32")]
        public static extern bool CloseClipboard();

        [DllImport("User32")]
        public static extern bool EmptyClipboard();

        [DllImport("User32")]
        public static extern bool IsClipboardFormatAvailable(int format);

        [DllImport("User32")]
        public static extern IntPtr GetClipboardData(int uFormat);

        [DllImport("User32", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetClipboardData(int uFormat, IntPtr hMem);

        public static void SetText(string text)
        {
            if (!OpenClipboard(IntPtr.Zero))
            {
                System.Windows.Clipboard.SetText(text);
                MessageBox.Show("复制成功");
                return;
            }
            EmptyClipboard();
            SetClipboardData(13, Marshal.StringToHGlobalUni(text));
            CloseClipboard();
        }
    }

}
