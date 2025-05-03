using System.ComponentModel;
using System.Windows;

namespace Calculator
{
    class Calculatorr : INotifyPropertyChanged
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
                OnPropertyChanged(nameof(Text)); 
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
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void PressNumKey(string content)
        {
            if (Text == "π" || Text == "e") return; 

            if (content == "π" || content == "e") Text = content; 
            else Text += content; 
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
