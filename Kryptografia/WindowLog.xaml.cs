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

namespace Kryptografia
{
    /// <summary>
    /// Logika interakcji dla klasy WindowLog.xaml
    /// </summary>
    public partial class WindowLog : Window
    {
        public WindowLog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List.Items.Clear();
            int m = Convert.ToInt32(txtmod.Text);
            int g=Convert.ToInt32(txtg.Text);
            for (int i = 1; i < m; i++)
            {
                List.Items.Add(g+"^"+i+" = "+Math.Pow(g, i) % m);
                if (Math.Pow(g, i) % m == 1) break;
            }
        }
    }
}
