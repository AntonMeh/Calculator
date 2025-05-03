using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    class EqualsCommand : ICommand
    {
        Calculatorr calculator;
        private string prevNumber = "";
        public void Execute()
        {
            if (calculator.WaitingText.Length != 0)
                prevNumber = calculator.WaitingText[..^1];
            calculator.PressEquals();
        }

        public void UnExecute()
        {
            calculator.Text = prevNumber;
            calculator.WaitingText = "";
        }

        public EqualsCommand(Calculatorr calculator) => this.calculator = calculator;
    }
}
