using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    internal class LnCommand : ICommand
    {
        private Calculatorr calculator;
        string prevNum = "";
        public LnCommand(Calculatorr calculator)
        {
            this.calculator = calculator;
        }
        public void Execute()
        {
            prevNum = calculator.Text;
            calculator.PressLn();
        }

        public void UnExecute()
        {
            calculator.Text = prevNum;
            calculator.WaitingText = "";
        }

    }
}
