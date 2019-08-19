using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace lommeregner
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }         

        private void Addition_ButtonClicked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clicked +");
            Console.WriteLine(firstInput_TextBox.Text);
            Console.WriteLine(secondInput_TextBox.Text);
            /*
            int firstInput = int.Parse(firstInput_TextBox.Text);
            int secondInput = int.Parse(secondInput_TextBox.Text);

            int result = firstInput + secondInput;
            Console.WriteLine("Result is: " + result);
            */

        }

        
        private void Subtraction_buttonClicked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clicked -");

        }

        private void Multiplicion_buttonCliked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clicked *");
        }

        private void Division_buttonClicked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clicked /");
        }

        private void FirstInput_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}