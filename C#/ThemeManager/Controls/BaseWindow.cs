using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Shell;
using ThemeManager.Helpers;

namespace ThemeManager.Controls
{
    public class WindowNotifications
    {
        /// <summary>
        /// Sent to a window when its nonclient area needs to be changed to indicate an active or inactive state.
        /// </summary>
        public const int WM_NCACTIVATE = 0x0086;
        public const uint MF_BYCOMMAND = 0x00000000;
        public const uint MF_GRAYED = 0x00000001;
        public const uint MF_ENABLED = 0x00000000;
        public const uint SC_CLOSE = 0xF060;
        public const int WM_SHOWWINDOW = 0x00000018;
        public const int WM_CLOSE = 0x10;
    }


    public partial class BaseWindow:Window
    {
        private static Style? GetDefautlStyle()
        {
            if (Application.Current.TryFindResource(typeof(BaseWindow)) is Style style && style != null)
            {
                return style;
            }
            else
            {
                ResourceDictionary dictionary1 = Application.LoadComponent(new Uri("/ThemeManager;component/Controls/BaseWindow.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary1);
                if (ThemeManagers.CurrentUITheme == Theme.Dark)
                {
                    ResourceDictionary dictionary2 = Application.LoadComponent(new Uri("/ThemeManager;component/Themes/Dark/Theme.xaml", UriKind.Relative)) as ResourceDictionary;
                    Application.Current.Resources.MergedDictionaries.Add(dictionary2);
                }
                else if (ThemeManagers.CurrentUITheme == Theme.Light)
                {
                    ResourceDictionary dictionary2 = Application.LoadComponent(new Uri("/ThemeManager;component/Themes/White/Theme.xaml", UriKind.Relative)) as ResourceDictionary;
                    Application.Current.Resources.MergedDictionaries.Add(dictionary2);
                }

                return Application.Current.FindResource(typeof(BaseWindow)) as Style ?? null;
            }
        }



        static BaseWindow()
        {
            StyleProperty.OverrideMetadata(typeof(BaseWindow), new FrameworkPropertyMetadata(GetDefautlStyle()));
        }
        public BaseWindow()
        {
            Command_Initialized();

        }

        public static readonly bool IsWin11 = Environment.OSVersion.Version >= new Version(10, 0, 21996);
        public static readonly bool IsWin10 = !IsWin11 && Environment.OSVersion.Version >= new Version(10, 0);



        public bool IsWindowBlurEnabled
        {
            get { return (bool)GetValue(IsWindowBlurEnabledProperty); }
            set {
                SetValue(IsWindowBlurEnabledProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for IsWindowBlurEnabled.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsWindowBlurEnabledProperty =
            DependencyProperty.Register("IsWindowBlurEnabled", typeof(bool), typeof(BaseWindow), new PropertyMetadata(false));



        public bool IsDragMoveEnabled
        {
            get { return (bool)GetValue(IsDragMoveEnabledProperty); }
            set
            {
                SetValue(IsDragMoveEnabledProperty, value);
            }
        }

        public static readonly DependencyProperty IsDragMoveEnabledProperty =
            DependencyProperty.Register("IsDragMoveEnabled", typeof(bool), typeof(BaseWindow), new PropertyMetadata(false));

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (IsDragMoveEnabled &&e.ButtonState == MouseButtonState.Pressed)
                DragMove();
        }


        #region 快捷键
        public static RoutedCommand WindowTopMost = new RoutedUICommand("WindowTopMost", "Full", typeof(BaseWindow), new InputGestureCollection(new InputGesture[] { }));
        #endregion

        public virtual void Command_Initialized()
        {
            this.CommandBindings.Add(new CommandBinding(WindowTopMost, this.ExecutedCommand, this.CanExecuteCommand));

            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, CloseWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, MaximizeWindow, CanResizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, MinimizeWindow, CanMinimizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, RestoreWindow, CanResizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.ShowSystemMenuCommand, ShowSystemMenu));
        }
        // https://www.cnblogs.com/dino623/p/problems_of_WindowChrome.html
        //解决WindowsChrome在设置SizeToContent的时候
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            if ((SizeToContent == SizeToContent.WidthAndHeight) && WindowChrome.GetWindowChrome(this) != null)
            {
                InvalidateMeasure();
            }
            IntPtr handle = new WindowInteropHelper(this).Handle;
            HwndSource.FromHwnd(handle).AddHook(new HwndSourceHook(WndProc));
            if (IsWindowBlurEnabled)
            {
                if (IsWin11)
                {
                    if (Environment.OSVersion.Version >= new Version(10, 0, 22523))
                    {
                        WindowHelper.EnableBackdropMicaBlur(this, ThemeManagers.CurrentUITheme == Theme.Dark);
                    }
                    else
                    {
                        WindowHelper.EnableMicaBlur(this, ThemeManagers.CurrentUITheme == Theme.Dark);
                    }
                }
                if (IsWin10)
                    WindowHelper.EnableBlur(this);
            }

        }

        IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            //if (msg == WM_SHOWWINDOW)
            //{
            //    IntPtr hMenu = GetSystemMenu(hwnd, false);
            //    if (hMenu != IntPtr.Zero)
            //    {
            //        EnableMenuItem(hMenu, SC_CLOSE, MF_BYCOMMAND | MF_GRAYED);
            //    }
            //}
            if (msg == WindowNotifications.WM_CLOSE)
            {
                if (!BaseClosed)
                {
                    this.BaseClose();
                    handled = !BaseClosed;
                }

            }
            return IntPtr.Zero;
        }



        
        public virtual void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void CanResizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        private void CanMinimizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ResizeMode != ResizeMode.NoResize;
        }


        private void CloseWindow(object sender, ExecutedRoutedEventArgs e)
        {
            BaseClose();
        }

        public bool BaseClosed = false;
        /// <summary>
        /// 封装一层，允许在关闭窗口之前增加一些操作
        /// </summary>
        public virtual void BaseClose()
        {
            BaseClosed = true;
            this.Close();
        }



        private void MaximizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
            //WindowState = WindowState.Maximized;

        }

        private void MinimizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void RestoreWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }


        private void ShowSystemMenu(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.OriginalSource is not FrameworkElement element)
                return;

            var point = WindowState == WindowState.Maximized ? new Point(0, element.ActualHeight)
                : new Point(Left + BorderThickness.Left, element.ActualHeight + Top + BorderThickness.Top);
            point = element.TransformToAncestor(this).Transform(point);
            SystemCommands.ShowSystemMenu(this, point);
        }

        public virtual void ExecutedCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == WindowTopMost)
            {
                Topmost = !Topmost;
            }
        }
    }
}
