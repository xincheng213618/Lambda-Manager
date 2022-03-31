using System;
using System.Windows.Input;

namespace NLGSolution
{
    public class MyCommand : ICommand
    {
        private Action _action;
        private Func<bool> _func;

        public MyCommand(Action action, Func<bool> func)
        {
            _action = action;
            _func = func;
        }

        public bool CanExecute(object parameter)
        {
            if (_func != null)
                return _func();

            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
