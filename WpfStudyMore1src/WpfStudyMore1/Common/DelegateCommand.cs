using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfStudyMore1.Common
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object> ExecuteHandler { get; set; }
        public Func<object, bool> CanExecuteHandler { get; set; }

        public bool CanExecute(object parameter)
        {
            var d = CanExecuteHandler;
            return d == null ? true: d(parameter);
        }

        public void Execute(object parameter)
        {
            var d = ExecuteHandler;
            if (d != null)
            {
                d(parameter);
            }
        }

        public void RaiseCanExecuteChanged()
        {
            var d = CanExecuteChanged;
            if (d != null)
            {
                d(this, null);
            }
        }
    }
}
