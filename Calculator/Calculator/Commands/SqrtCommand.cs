using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    internal class SqrtCommand : ICommand
    {
        private Calculatorr calculator;
        string prevNum = "";
        public SqrtCommand(Calculatorr calculator)
        {
            this.calculator = calculator;
        }
        public void Execute()
        {
            prevNum = calculator.Text;
            calculator.PressSqrt();
        }

        public void UnExecute()
        {
            calculator.Text = prevNum;
            calculator.WaitingText = "";
        }
    }
}
