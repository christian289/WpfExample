using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VM_GC_Test.Bases
{
    public class CommandBase : ICommand
    {
        private readonly Func<bool> canExecute;
        private readonly Action execute;

        public CommandBase(Action execute) : this(execute, null)
        {
        }

        public CommandBase(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// implement of icommand can execute method
        /// </summary>
        /// <param name="o">parameter by default of icommand interface</param>
        /// <returns>can execute or not</returns>
        public bool CanExecute(object o)
        {
            if (canExecute == null)
            {
                return true;
            }

            return canExecute();
        }

        public void Execute(object o)
        {
            execute();
        }
    }
}
