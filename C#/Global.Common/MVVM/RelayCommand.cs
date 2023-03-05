using System;
using System.Windows.Input;

namespace Global.Common
{
    /// <summary>
    ///  Implements the <see cref="ICommand"/> interface
    /// </summary>
    public sealed class RelayCommand : ICommand
    {
        public readonly Action<object> execute;
        public readonly Predicate<object> canExecute;

        //Func<object,bool> =>Predicate<object> ss
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        bool ICommand.CanExecute(object? parameter) => canExecute is null || canExecute(parameter);

        event EventHandler? ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

         void ICommand.Execute(object? parameter) => execute(parameter);
    }
}
