using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    class ClearCommand : ICommand
    {
        Calculatorr calculator;
        string prevText = "";

        public ClearCommand(Calculatorr calculator) => this.calculator = calculator;

        public void Execute()
        {
            prevText = calculator.Text;
            calculator.PressClear();
        }
        public void UnExecute() => calculator.Text = prevText;
    }
}
