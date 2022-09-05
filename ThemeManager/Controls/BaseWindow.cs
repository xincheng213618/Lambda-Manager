using System;
using System.Windows;
using System.Windows.Input;

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
                ResourceDictionary dictionary1 = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/Window.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary1);
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

        public static RoutedCommand WindowClose = new RoutedUICommand("WindowClose", "Full", typeof(BaseWindow), new InputGestureCollection(new InputGesture[] { new KeyGesture(Key.F4, ModifierKeys.Alt) }));
        public static RoutedCommand WindowMin = new RoutedUICommand("WindowMin", "Full", typeof(BaseWindow), new InputGestureCollection(new InputGesture[] { }));
        public static RoutedCommand WindowMax = new RoutedUICommand("WindowMax", "Full", typeof(BaseWindow), new InputGestureCollection(new InputGesture[] { }));
        public static RoutedCommand WindowRestore = new RoutedUICommand("WindowRestore", "Full", typeof(BaseWindow), new InputGestureCollection(new InputGesture[] { }));
        public static RoutedCommand WindowTopMost = new RoutedUICommand("WindowTopMost", "Full", typeof(BaseWindow), new InputGestureCollection(new InputGesture[] { }));
        #endregion

        public virtual void Command_Initialized()
        {
            this.CommandBindings.Add(new CommandBinding(WindowClose, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowMin, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowMax, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowRestore, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowTopMost, this.ExecutedCommand, this.CanExecuteCommand));

        }

        public virtual void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public virtual void ExecutedCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == WindowClose)
            {
                this.Close();
            }
            else if (e.Command == WindowMin)
            {
                WindowState = WindowState.Minimized;
            }
            else if (e.Command == WindowMax)
            {
                WindowState = WindowState.Maximized;
            }
            else if (e.Command == WindowRestore)
            {
                WindowState = WindowState.Normal;
            }
            else if (e.Command == WindowTopMost)
            {
                Topmost = !Topmost;
            }
        }
    }
}
