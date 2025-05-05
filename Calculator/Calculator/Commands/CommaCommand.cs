using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    class CommaCommand : ICommand
    {
        Calculatorr calculator;
        public void Execute() => calculator.PressComma();

        public void UnExecute() => calculator.PressBackspace();

        public CommaCommand(Calculatorr calculator) => this.calculator = calculator;
        
    }
}
