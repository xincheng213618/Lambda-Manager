

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThemeManager.NativeMethods
{
    public static class Dwmapi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Margins
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;

            public Margins(int cxLeftWidth, int cxRightWidth, int cyTopHeight, int cyBottomHeight)
            {
                this.cxLeftWidth = cxLeftWidth;
                this.cxRightWidth = cxRightWidth;
                this.cyTopHeight = cyTopHeight;
                this.cyBottomHeight = cyBottomHeight;
            }
        }

        public enum WindowAttribute
        {
            UseImmersiveDarkMode = 20,
            SystembackdropType = 38,
            MicaEffect = 1029
        }

        public enum SystembackdropType
        {
            Auto = 0,
            None = 1,
            MainWindow = 2,
            TransientWindow = 3,
            TabbedWindow = 4
        }

        [DllImport("DwmApi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref Margins pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, uint dwAttribute, ref int pvAttribute, int cbAttribute);
    }
}
