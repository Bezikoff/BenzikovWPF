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
using System.Windows.Shapes;

namespace BenzikovWPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double y = 0;
            double x = Convert.ToDouble(amX0.Text);
            double xk = Convert.ToDouble(amXk.Text);
            double dx = Convert.ToDouble(amDX.Text);
            double a = Convert.ToDouble(amA.Text);
            double b = Convert.ToDouble(amB.Text);
            LW.Items.Add("Работу выполнил компуктер");
            if (dx<0)
            {
                while (x >= xk)
                {
                    y = a * x * x * x + Math.Cos(x * x * x - b);
                    LW.Items.Add($"x={x}; y={y}");
                    x += dx;
                }
            }
            else
            {
                while (x <= xk)
                {
                    y = a * x * x * x + Math.Cos(x * x * x - b);
                    LW.Items.Add($"x={x}; y={y}");
                    x += dx;
                }
            }
        }

        private void PR6(object sender, RoutedEventArgs e)
        {
            Menu wiw = new Menu();
            wiw.Show();
            Close();
        }
    }
}
