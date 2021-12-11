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
    /// Logika interakcji dla klasy WindowChinskie.xaml
    /// </summary>
    public partial class WindowChinskie : Window
    {
        public WindowChinskie()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtBoxX1.IsEnabled = false; txtBoxMod1.IsEnabled = false;
            txtBoxX2.IsEnabled = false; txtBoxMod2.IsEnabled = false;   
            txtBoxX3.IsEnabled = false; txtBoxMod3.IsEnabled = false;   
            txtBoxX4.IsEnabled = false; txtBoxMod4.IsEnabled = false;

        }
        static int wybor;
        int[] a=new int[wybor+1];
        int[] m = new int[wybor+1];
        int[] M = new int[wybor+1];
        int[] x = new int[wybor+1];
        int MM, xx;
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            wybor=Convert.ToInt32(txtBoxGiveX.Text);
            switch (wybor)
            {
                case 1:
                    {
                        txtBoxX1.IsEnabled = true; txtBoxMod1.IsEnabled = true;
                        break;
                    }
                case 2:
                    {
                        txtBoxX1.IsEnabled = true; txtBoxMod1.IsEnabled = true;
                        txtBoxX2.IsEnabled = true; txtBoxMod2.IsEnabled = true;
                        break;
                    }
                case 3:
                    {
                        txtBoxX1.IsEnabled = true; txtBoxMod1.IsEnabled = true;
                        txtBoxX2.IsEnabled = true; txtBoxMod2.IsEnabled = true;
                        txtBoxX3.IsEnabled = true; txtBoxMod3.IsEnabled = true;
                        break;
                    }
                case 4:
                    {
                        txtBoxX1.IsEnabled = true; txtBoxMod1.IsEnabled = true;
                        txtBoxX2.IsEnabled = true; txtBoxMod2.IsEnabled = true;
                        txtBoxX3.IsEnabled = true; txtBoxMod3.IsEnabled = true;
                        txtBoxX4.IsEnabled = true; txtBoxMod4.IsEnabled = true;
                        break;
                    }
            }        
        }

        private void zczytajDane()
        {
            switch (wybor)
            {
                case 1:
                    {
                        a[1] = Convert.ToInt32(txtBoxX1.Text); m[1] = Convert.ToInt32(txtBoxMod1.Text);
                        break;
                    }
                case 2:
                    {
                        a[1] = Convert.ToInt32(txtBoxX1.Text); m[1] = Convert.ToInt32(txtBoxMod1.Text);
                        a[2] = Convert.ToInt32(txtBoxX2.Text); m[2] = Convert.ToInt32(txtBoxMod2.Text);
                        break;
                    }
                case 3:
                    {
                        a[1] = Convert.ToInt32(txtBoxX1.Text); m[1] = Convert.ToInt32(txtBoxMod1.Text);
                        a[2] = Convert.ToInt32(txtBoxX2.Text); m[2] = Convert.ToInt32(txtBoxMod2.Text);
                        a[3] = Convert.ToInt32(txtBoxX3.Text); m[3] = Convert.ToInt32(txtBoxMod3.Text);
                        break;
                    }
                case 4:
                    {
                        a[1] = Convert.ToInt32(txtBoxX1.Text); m[1] = Convert.ToInt32(txtBoxMod1.Text);
                        a[2] = Convert.ToInt32(txtBoxX2.Text); m[2] = Convert.ToInt32(txtBoxMod2.Text);
                        a[3] = Convert.ToInt32(txtBoxX3.Text); m[3] = Convert.ToInt32(txtBoxMod3.Text);
                        a[4] = Convert.ToInt32(txtBoxX4.Text); m[4] = Convert.ToInt32(txtBoxMod4.Text);
                        break;
                    }
            }
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

        private void btnReady_Click(object sender, RoutedEventArgs e)
        {
            MM = 0; xx = 0;
            zczytajDane();
            for (int i = 1; i < m.Length; i++)
            {
                MM += m[i];
            }
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = MM / m[i];
            }
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = modInverse(M[i], m[i]);
            }
            for (int i = 0; i<x.Length; i++)
            {
                xx += a[i] * x[i] * M[i];
            }
            Odp.Text = "" + xx;
        }

    }
}
