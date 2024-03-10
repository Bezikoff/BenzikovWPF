using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
    /// Логика взаимодействия для PR7.xaml
    /// </summary>
    public partial class PR7 : Window
    {
        public PR7()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Menu wiw = new Menu();
            wiw.Show();
            Close();
        }

        private void FromFile(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream) { LS7.Items.Add(sr.ReadLine()); }
        }

        private void Rezy(object sender, RoutedEventArgs e)
        {
            int index = LS7.SelectedIndex;
            string str = (string)LS7.Items[index];
            List<int> str1 = str.Split(' ').Select(int.Parse).ToList();
            int low = str1[0];
            int low1 = 0;
            int numba = -1;
            foreach (int i in str1)
            {
                numba++;
                if (i < low)
                {
                    low = i;
                    low1 = numba;
                }
            }
            int memo = str1[0];
            str1[0] = low;
            str1[low1] = memo;
            LS7.Items[index] = string.Join(" ", str1);
        }
    }
    


}
