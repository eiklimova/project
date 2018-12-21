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

namespace WPFKate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label1.Foreground = Brushes.Green;
            double a, b, c, d;
            try
            {
                a = Double.Parse(textbox1.Text);
                b = Double.Parse(textbox2.Text);
                c = Double.Parse(textbox3.Text);
            }
            catch (FormatException)
            {
                label1.Foreground = Brushes.Red;
                label1.Content = "Ошибка!\nНекорректные коэффициенты!";
                return;
            }
            catch (OverflowException ex)
            {
                label1.Foreground = Brushes.Red;
                label1.Content = "Ошибка! " + ex.Message;
                return;
            }

            if (a == 0)
            {
                label1.Foreground = Brushes.Red;
                label1.Foreground = Brushes.Red;
                label1.Content = "Ошибка!\nКоэффициент а не может быть 0!";
                return;
            }

            d = b * b - 4.0 * a * c;

            if (d == 0)
            {
                double x = (-b) / (2.0 * a);
                label1.Content = "Корни совпадают:\nx=" + x.ToString();
            }
            else if (d < 0)
            {
                label1.Content = "Нет корней";
            }
            else
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2.0 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2.0 * a);
                label1.Content = "Первый корень: x1 = " + x1.ToString() +
                    "\nВторой корень: x2 = " + x2.ToString();
            }
        }
    }
}
