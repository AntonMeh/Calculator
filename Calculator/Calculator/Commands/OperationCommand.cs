using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    internal class OperationCommand : ICommand
    {
        private Calculatorr calculator;
        string content = "";

        public OperationCommand(Calculatorr calculator, string content)
        {
            this.calculator = calculator;
            this.content = content;
        }
        public void Execute()
        {
            calculator.PressOperation(content);
        }

        public void UnExecute()
        {
            if (!string.IsNullOrEmpty(calculator.WaitingText))
            {
                calculator.Text = calculator.WaitingText[..^1];
                calculator.WaitingText = "";
            }
        }
    }
}
