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
using System.Text.RegularExpressions;

namespace RegularExpression
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input_Matching(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex(regexTxt.Text);
            Boolean isMatched = reg.IsMatch(inputTxt.Text);
            if (isMatched)
            {
                output.Text = "MATCHED :)";
                output.Foreground = new SolidColorBrush(Colors.Black);
                output.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                output.Text = "NOT MATCHED :(";
                output.Foreground = new SolidColorBrush(Colors.Black);
                output.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
