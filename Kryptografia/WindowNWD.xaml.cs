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
    /// Logika interakcji dla klasy WindowNWD.xaml
    /// </summary>
    public partial class WindowNWD : Window
    {
        public WindowNWD()
        {
            InitializeComponent();
        }

        private void ButtonNWD_Click(object sender, RoutedEventArgs e)
        {
            int nwda = Convert.ToInt32(liczba1.Text);
            int nwdb = Convert.ToInt32(liczba2.Text);
            int nwd;
            if (nwdb > nwda)
            {
                nwd = nwdb;
                nwdb= nwda;
                nwda= nwd;
            }
            int a = nwda;
            int b = nwdb;

            int q = a / b;
            int r = a - q / b;
            nwd = b;

            int x2, x1, y2, y1, x, y;

            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;
            x = 1;
            y = y2 - (q - 1) * y1;

            while (r != 0)
            {
                a = b;
                b = r;

                x = x2 - q * x1;
                x2 = x1;
                x1 = x;

                y = y2 - q * y1;
                y2 = y1;
                y1 = y;

                nwd = r;
                q = a / b;
                r = a - q * b;
            }
            nwdZ.Text = nwd+" ";
            nwdR.Text = nwd + " = " + x + " * " + nwda + " + " + y + " * " + nwdb;
        }
    }
}
