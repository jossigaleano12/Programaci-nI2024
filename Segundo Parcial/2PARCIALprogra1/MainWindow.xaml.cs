using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2PARCIALprogra1
{
    public partial class MainWindow : Window
    {
        private double number1;
        private double number2;
        private string operation;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();
            ResultTextBox.Text = number;
        }

        private void OperatorButton_Click(Object sender, RoutedEventArgs e) 
        {
            Button button = (Button)sender;
            operation = button.Content.ToString();
            number1 = double.Parse(ResultTextBox.Text);
            ResultTextBox.Text = "";
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            number2 = double.Parse(ResultTextBox.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "√":
                    result = Math.Sqrt(number1);
                    break;
                case "^":
                    result = Math.Pow(number1,number2);
                    break;
                    

            }
            ResultTextBox.Text = result.ToString();
        }
    }
}