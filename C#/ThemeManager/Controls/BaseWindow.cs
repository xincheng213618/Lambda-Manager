using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shell;

namespace ThemeManager.Controls
{
    public partial class BaseWindow:Window
    {
        private static Style? GetDefautlStyle()
        {
            if (Application.Current.TryFindResource(typeof(BaseWindow))!=null)
            {
                return Application.Current.FindResource(typeof(BaseWindow)) as Style;
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
                else if (ThemeManagers.CurrentUITheme == Theme.White)
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
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (e.ButtonState == MouseButtonState.Pressed)
                DragMove();
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
            this.Close();
        }

        private void MaximizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
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
            var element = e.OriginalSource as FrameworkElement;
            if (element == null)
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
