using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void FromFile(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream) {LS7.Items.Add(sr.ReadLine()); }
        }

        private void Rezy(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = LS7.SelectedIndex;
                string str = (string)LS7.Items[index];
                int len = str.Length;
                string cunt = "В строке есть числа:";
                int i = 0;
                int cont = 0;
                List<string> chs = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
                List<string> probel = new List<string> {" "};
                var ch2 = new List<int>();
                while (i < len - 1)
                {
                    if (probel.Contains(Convert.ToString(str[i]))) { cont++; }
                    i++;
                }
                foreach (char k in str) { if (chs.Contains(Convert.ToString(k))) { cunt += $" {k}"; } }
                eles6.Text = $"Кол-во пробелов: {cont}";
                MessageBox.Show(cunt);

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Menu wiw = new Menu();
            wiw.Show();
            Close();
        }
    }
}
