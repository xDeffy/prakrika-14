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

namespace WpfApp1
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

        private void kl(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(T1.Text);
            double a = x - 10 * Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
            T2.Text = Convert.ToString(a);
        }
    }
}
