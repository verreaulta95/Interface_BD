using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lab3.ViewModel;
using Lab3.Modeles;

namespace Lab3.Commandes
{
    public class BaseCommand : ICommand
    {
        public Predicate<object> CanExecuteFunc
        {
            get;
            set;
        }

        public Action<object> ExecuteFunc
        {
            get;
            set;
        }

        public BaseCommand(Action<object> execute, Predicate<object> canExecute)
        {
            ExecuteFunc = execute;
            CanExecuteFunc = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteFunc(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteFunc(parameter);
        }
    }
}
