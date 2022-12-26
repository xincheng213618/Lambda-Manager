

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using ThemeManager.NativeMethods;

namespace ThemeManager.Helpers
{
    public static class WindowHelper
    {
        public enum WindowCompositionAttribute
        {
            WcaAccentPolicy = 19
        }

        public static void BringToFront(this Window window, bool keep)
        {
            var handle = new WindowInteropHelper(window).Handle;
            keep |= window.Topmost;

            User32.SetWindowPos(handle, User32.HWND_TOPMOST, 0, 0, 0, 0, User32.SWP_NOMOVE | User32.SWP_NOSIZE | User32.SWP_NOACTIVATE);

            if (!keep)
                User32.SetWindowPos(handle, User32.HWND_NOTOPMOST, 0, 0, 0, 0,  User32.SWP_NOMOVE | User32.SWP_NOSIZE | User32.SWP_NOACTIVATE);
        }

        public static void MoveWindow(this Window window,
            double pxLeft,
            double pxTop,
            double width,
            double height)
        {
            var handle = new WindowInteropHelper(window).EnsureHandle();

            // scale the size to the primary display
            TransformToPixels(window, width, height, out var pxWidth, out var pxHeight);

            // Use absolute location and relative size. WPF will scale the size to the target display
            User32.MoveWindow(handle, (int) Math.Round(pxLeft), (int) Math.Round(pxTop), pxWidth, pxHeight, true);
        }

        public static Rect GetWindowRectInPixel(this Window window)
        {
            var handle = new WindowInteropHelper(window).EnsureHandle();

            User32.GetWindowRect(handle, out User32.RECT nRect);

            return new Rect(new Point(nRect.Left, nRect.Top), new Point(nRect.Right, nRect.Bottom));
        }

        private static void TransformToPixels(this Visual visual, double unitX, double unitY, out int pixelX, out int pixelY)
        {
            Matrix matrix;
            var source = PresentationSource.FromVisual(visual);
            if (source != null)
                matrix = source.CompositionTarget.TransformToDevice;
            else
                using (var src = new HwndSource(new HwndSourceParameters()))
                {
                    matrix = src.CompositionTarget.TransformToDevice;
                }

            pixelX = (int) Math.Round(matrix.M11 * unitX);
            pixelY = (int) Math.Round(matrix.M22 * unitY);
        }

        public static bool IsForegroundWindowBelongToSelf()
        {
            var hwnd = User32.GetForegroundWindow();
            if (hwnd == IntPtr.Zero)
                return false;

            User32.GetWindowThreadProcessId(hwnd, out var procId);
            return procId == Process.GetCurrentProcess().Id;
        }

        public static void SetNoactivate(this Window window)
        {
            var hwnd = new WindowInteropHelper(window).Handle;
            User32.SetWindowLong(hwnd, User32.GWL_EXSTYLE,
                User32.GetWindowLong(hwnd, User32.GWL_EXSTYLE) |
                User32.WS_EX_NOACTIVATE);
        }
        public static void RemoveWindowControls(this Window window)
        {
            var hwnd = new WindowInteropHelper(window).Handle;
            User32.SetWindowLong(hwnd, User32.GWL_STYLE,
                User32.GetWindowLong(hwnd, User32.GWL_STYLE) &
                ~User32.WS_SYSMENU);
        }

        public static void EnableBlur(Window window)
        {
            var accent = new AccentPolicy();
            var accentStructSize = Marshal.SizeOf(accent);
            accent.AccentState = AccentState.AccentEnableBlurbehind;
            accent.AccentFlags = 2;
            accent.GradientColor = ThemeManagers.CurrentUITheme ==Theme.Dark? 0x99333333: 0x99FFFFFF;

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData
            {
                Attribute = WindowCompositionAttribute.WcaAccentPolicy,
                SizeOfData = accentStructSize,
                Data = accentPtr
            };

            User32.SetWindowCompositionAttribute(new WindowInteropHelper(window).EnsureHandle(), ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        private static void EnableDwmBlur(Window window, bool isDarkTheme, uint dwAttribute, int pvAttribute)
        {
            // Mica will handle the color
            window.Background = Brushes.Transparent;

            var hwnd = new WindowInteropHelper(window).EnsureHandle();

            var isDarkThemeInt = isDarkTheme ? 1 : 0;
            Dwmapi.DwmSetWindowAttribute(hwnd, (uint)Dwmapi.WindowAttribute.UseImmersiveDarkMode, ref isDarkThemeInt, Marshal.SizeOf(typeof(bool)));

            var margins = new Dwmapi.Margins(-1, -1, -1, -1);
            Dwmapi.DwmExtendFrameIntoClientArea(hwnd, ref margins);

            var val = pvAttribute;
            Dwmapi.DwmSetWindowAttribute(hwnd, dwAttribute, ref val, Marshal.SizeOf(typeof(int)));
        }

        public static void EnableMicaBlur(Window window, bool isDarkTheme)
        {
            EnableDwmBlur(window, isDarkTheme, (uint)Dwmapi.WindowAttribute.MicaEffect, 1);
        }

        public static void EnableBackdropMicaBlur(Window window, bool isDarkTheme)
        {
            EnableDwmBlur(window, isDarkTheme, (uint)Dwmapi.WindowAttribute.SystembackdropType, (int)Dwmapi.SystembackdropType.MainWindow);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        private enum AccentState
        {
            AccentDisabled = 0,
            AccentEnableGradient = 1,
            AccentEnableTransparentgradient = 2,
            AccentEnableBlurbehind = 3,
            AccentInvalidState = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public uint GradientColor;
            public readonly int AnimationId;
        }
    }
}