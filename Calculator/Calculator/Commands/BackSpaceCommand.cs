using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands
{
    class BackSpaceCommand : ICommand
    {
        Calculatorr calculator;
        Stack<char> chars = new Stack<char>();
        public void Execute() {
            if (!string.IsNullOrEmpty(calculator.Text))
                chars.Push(calculator.Text[^1]);
           
            calculator.PressBackspace();
        }

        public void UnExecute()
        {
            if (chars.Count != 0)
                calculator.Text += chars.Pop();
        }

        public BackSpaceCommand(Calculatorr calculator)=> this.calculator = calculator;
        
    }
}
