using System;
using System.Windows.Input;

namespace Global.Common
{
    /// <summary>
    ///  Implements the <see cref="ICommand"/> interface
    /// </summary>
    public sealed class RelayCommand : ICommand
    {
        public readonly Action<object> Execute;
        public readonly Predicate<object> CanExecute;

        //Func<object,bool> =>Predicate<object> ss
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            this.Execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.CanExecute = canExecute;
        }

        bool ICommand.CanExecute(object? parameter) => CanExecute is null || CanExecute(parameter);

        event EventHandler? ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

         void ICommand.Execute(object? parameter) => Execute(parameter);
    }
}
