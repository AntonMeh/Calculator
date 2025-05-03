using CalculatorTask;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Calculator.Commands;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        readonly Button PI = new Button() { Content = "π", Visibility = Visibility.Collapsed };
        readonly Button exp = new Button() { Content = "e", Visibility = Visibility.Collapsed };
        readonly Button sqrt = new Button() { Content = "√", Visibility = Visibility.Collapsed };
        readonly Button power = new Button() { Content = "xⁿ", Visibility = Visibility.Collapsed };
        readonly Button ln = new Button() { Content = "ln", Visibility = Visibility.Collapsed };

        readonly static Calculatorr calculator = new Calculatorr();
        readonly ControlPanel controlPanel = new ControlPanel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = calculator;
            KeyDown += Window_KeyDown;

            Grid.SetColumn(PI, 5);
            Grid.SetRow(PI, 1);
            Grid.SetColumn(exp, 5);
            Grid.SetRow(exp, 2);
            Grid.SetColumn(sqrt, 5);
            Grid.SetRow(sqrt, 3);
            Grid.SetColumn(power, 5);
            Grid.SetRow(power, 4);
            Grid.SetColumn(ln, 5);
            Grid.SetRow(ln, 5);

            grid.Children.Add(PI);
            grid.Children.Add(exp);
            grid.Children.Add(sqrt);
            grid.Children.Add(power);
            grid.Children.Add(ln);

            sqrt.Click += Sqrt_Click;
            power.Click += Operation_Click;
            ln.Click += Ln_Click;
            PI.Click += Numpad_Click;
            exp.Click += Numpad_Click;
        }

        private void SandwichButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility visibility;

            if (grid.ColumnDefinitions.ElementAt(4).Width == GridLength.Auto)
            {
                grid.ColumnDefinitions.ElementAt(4).Width = new GridLength(1, GridUnitType.Star);
                SandwichButton.Content = "<";
                visibility = Visibility.Visible;
            }
            else
            {
                grid.ColumnDefinitions.ElementAt(4).Width = GridLength.Auto;
                SandwichButton.Content = "☰";
                visibility = Visibility.Collapsed;
            }

            PI.Visibility = visibility;
            exp.Visibility = visibility;
            sqrt.Visibility = visibility;
            power.Visibility = visibility;
            ln.Visibility = visibility;
        }

        private void Numpad_Click(object sender, RoutedEventArgs e)
        {
            controlPanel.SetCommand(new NumKeyCommand(calculator, (sender as Button)!.Content.ToString()!));
            controlPanel.RunCommand();
        }
        private void Comma_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Ln_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Undo(object sender, RoutedEventArgs e)
        {
        }
        private void Redo(object sender, RoutedEventArgs e)
        {
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}