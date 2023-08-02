using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();
            //acButton.Click += acButton_Click;
            //negativeButton.Click += negativeButton_Click;

        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(),out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content=lastNumber.ToString();
            }
        }

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(),out lastNumber))
            {
                lastNumber=lastNumber/ 100;
                resultLabel.Content=lastNumber.ToString();
            }
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "/";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}/";
            }
        }
        private void numberSevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }

        private void numberEightButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}8";
            }
        }
        private void numberNineButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() == "0") {
                resultLabel.Content = "9";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}9";
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "*";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}*";
            }
        }

        private void numberFourButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "4";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}4";
            }
        }

        private void numberFiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "5";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}5";
            }
        }

        private void numberSixButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "6";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}6";
            }
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "-";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}-";
            }
        }

        private void numberOneButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "1";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}1";
            }
        }

        private void numberTwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "2";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}2";
            }
        }

        private void numberThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "3";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}3";
            }
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            //if (resultLabel.Content.ToString() == "0")
            //{
            //    resultLabel.Content = "+";
            //}
            //else
            //{
            //    resultLabel.Content = $"{resultLabel.Content}+";
            //}
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "0";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}0";
            }
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
                // Nothing happen
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
            /*//if(resultLabel.Content.ToString() == "0")
            //{
            //    resultLabel.Content = "0";
            //}
            //else
            //{
            //    resultLabel.Content = $"{resultLabel.Content}.";
            //}*/
        }

        private void equalToButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if(double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.addition:
                        result = SimpleMath.add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.substraction:
                        result = SimpleMath.sub(lastNumber, newNumber);
                        break;
                    case SelectedOperator.multiplication:
                        result = SimpleMath.mul(lastNumber, newNumber);
                        break;
                    case SelectedOperator.division:
                        result = SimpleMath.div(lastNumber, newNumber);
                        break;
                }
                resultLabel.Content = result.ToString();
            }
        }

        private void operation_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(),out lastNumber))
            {
                resultLabel.Content = "0";
            }
            if (sender == multiplyButton)
            {
                selectedOperator = SelectedOperator.multiplication;
            }
            if(sender == divideButton)
            {
                selectedOperator = SelectedOperator.division;
            }
            if (sender == plusButton)
            {
                selectedOperator = SelectedOperator.addition;
            }
            if (sender == minusButton)
            {
                selectedOperator = SelectedOperator.substraction;
            }
        }
    }
    public enum SelectedOperator
    {
        addition,
        substraction,
        multiplication,
        division
    }
    public class SimpleMath
    {
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }public static double mul(double a, double b)
        {
            return a * b;
        }public static double div(double a, double b)
        {
            return a / b;
        }
    }
}
