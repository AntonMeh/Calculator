using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Calculator.Commands
{
    class NumKeyCommand : ICommand
    {
        Calculatorr calculator;
        string content;
        public NumKeyCommand(Calculatorr calculator, string content)
        {
            this.calculator = calculator;
            this.content = content;
        }

        public void Execute()
        {
            calculator.PressNumKey(content);
        }

        public void UnExecute()
        {
            calculator.PressBackspace();
        }
    }
}
