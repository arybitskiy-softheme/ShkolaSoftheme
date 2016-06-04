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

namespace number
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int b = 0;
           try
            {
                int t = int.Parse(textBox.Text);
            }
            catch (Exception)
            {
                goto end;
            }

            b = int.Parse(textBox.Text);
            if (b > 10 && b < 1)
            {
                label1.Content = "Try again";
                textBox.Clear();
            }

            if (a == b)
            {
                label1.Content = "Correct";
            }
            else
            {
                label1.Content = a.ToString();
                textBox.Clear();
            }
        end:
            if (b == 0)
            {

            label1.Content = "Try again";
            textBox.Clear();
            }
        }
    }
}
