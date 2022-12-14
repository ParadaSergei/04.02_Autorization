using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAutorizationINFolder.Command
{
   public class DelegateCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canAxecute;

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canAxecute = canExecute;
        }
        public DelegateCommand(Action<object> execute) : this(execute, null) { }
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public bool CanExecute(object parameter)
        {
            if(_canAxecute != null)
            {
                return _canAxecute(parameter);
            }
            return true;
        }
        public void Execute (object parameter)
        {
            _execute?.Invoke(parameter);        
        }
    }
}
