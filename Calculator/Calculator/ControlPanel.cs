using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Commands;

namespace CalculatorTask
{
    class ControlPanel
    {
        ICommand command;
        ICommand lastCommand;

        Stack<ICommand> commandHistory = new Stack<ICommand>();
        public void SetCommand(ICommand command) => this.command = command;
        public void RunCommand()
        {
            if (command != null)
            {
                commandHistory.Push(command);
                command.Execute();
                lastCommand = command;
            }
        }
    }
}
