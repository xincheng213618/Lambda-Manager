using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ConfigObjective
{
    public partial class RheinbergPatternEditorWindow
    {
        #region 快捷键

        public static RoutedCommand WindowClose = new RoutedUICommand("WindowClose", "Full", typeof(RheinbergPatternEditorWindow), new InputGestureCollection(new InputGesture[] { new KeyGesture(Key.F4,ModifierKeys.Alt) }));
        public static RoutedCommand WindowMin = new RoutedUICommand("WindowMin", "Full", typeof(RheinbergPatternEditorWindow), new InputGestureCollection(new InputGesture[] { }));
        public static RoutedCommand WindowMax = new RoutedUICommand("WindowMax", "Full", typeof(RheinbergPatternEditorWindow), new InputGestureCollection(new InputGesture[] { }));
        public static RoutedCommand WindowRestore = new RoutedUICommand("WindowRestore", "Full", typeof(RheinbergPatternEditorWindow), new InputGestureCollection(new InputGesture[] { }));
        public static RoutedCommand WindowTopMost = new RoutedUICommand("WindowTopMost", "Full", typeof(RheinbergPatternEditorWindow), new InputGestureCollection(new InputGesture[] { }));
        #endregion

        public void Command_Initialized()
        {
            this.CommandBindings.Add(new CommandBinding(WindowClose ,this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowMin, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowMax, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowRestore, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(WindowTopMost, this.ExecutedCommand, this.CanExecuteCommand));

        }

        private void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }



        private void ExecutedCommand(object sender, ExecutedRoutedEventArgs e)
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
