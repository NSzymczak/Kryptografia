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
    /// Logika interakcji dla klasy WindowCalc.xaml
    /// </summary>
    public partial class WindowCalc : Window
    {
        public WindowCalc()
        {
            InitializeComponent();
        }

        private void btnModulo_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(txtBoxX1.Text);
            int m = Convert.ToInt32(txtBoxMod1.Text);
            txtBoxModWynik.Text = x % m + " ";
        }

        private void btnInvModulo_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(txtBoxX2.Text);
            int m = Convert.ToInt32(txtBoxMod2.Text);
            txtBoxInvModWynik.Text = modInverse(x,m)+" ";
        }
        int modInverse(int a, int n)
        {
            int i = n, v = 0, d = 1;
            while (a > 0)
            {
                int t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }
    }
}
