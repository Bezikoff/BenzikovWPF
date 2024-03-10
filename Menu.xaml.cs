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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PR5(object sender, RoutedEventArgs e)
        {
            Window1 wiw = new Window1();
            wiw.Show();
            Close();
        }

        private void PR6(object sender, RoutedEventArgs e)
        {
            Window2 wiw = new Window2();
            wiw.Show();
            Close();
        }

        private void PR7(object sender, RoutedEventArgs e)
        {
            PR7 wiw = new PR7();
            wiw.Show();
            Close();
        }
    }
}
