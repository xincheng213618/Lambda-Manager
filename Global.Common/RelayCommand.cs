using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Global.Common
{
    /// <summary>
    /// 中继命令
    /// </summary>
    public class RelayCommand : ICommand
    {
        
        private readonly Action<object> execute;

        private readonly Func<object,bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object,bool> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute != null)
            {
                return canExecute(parameter);
            }
            return true;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            execute(parameter);

        }
    }
}
