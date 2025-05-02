using System.ComponentModel;
using System.Windows;

namespace Calculator
{
    class Calculator 
    {
        private string text = "";
        private string waitingText = "";

        public string Text
        {
            get => text;
            set
            {
                text = value;
                if (text.Length > 17) text = text[..17];
                text = text.StartsWith("00") ? "0" : text.StartsWith("-00") ? "-0" : text; // prevent two or more zeros
            }
        }
        public string WaitingText
        {
            get => waitingText;
            set
            {
                waitingText = value;
            }
        }

        public void PressNumKey(string content)
        {

        }
        public void PressComma()
        {

        }
        public void PressBackspace()
        {

        }
        public void PressClear() => Text = "";
        public void PressOperation(string content)
        {
            

        }
        public void PressEquals()
        {
           
        }
        public void PressLn()
        {

        }
        public void PressSqrt()
        {

        }
    }
}
