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
    /// Interaction logic for WindowAfiniczny.xaml
    /// </summary>
    public partial class WindowAfiniczny : Window
    {
        public WindowAfiniczny()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a=Convert.ToInt32(txtA.Text);
            int b=Convert.ToInt32(txtB.Text);
            int[] tab=new int[26];
            int[] tabSZ=new int[26];
            for (int i = 0; i < 26; i++)
            {
                tab[i] = i;
            }
            for (int i = 0; i <26; i++)
            {
                tabSZ[i] = (a * tab[i] + b)%26;
            }
            Wyswietl(tab, tabSZ);
        }

        private void Wyswietl(int[] tab, int[] tabSZ)
        {
            for (int i = 0; i <26 ; i++)
            {
                Alfabet.Items.Add(Converter(tab[i])+" - "+tab[i]+" ------ "+ tabSZ[i] + " - " + Converter(tabSZ[i]));
            }
        }

        private string Converter(int a)
        {
            switch (a)
            {
                case 0: return "A";
                case 1: return "B";
                case 2: return "C";
                case 3: return "D";
                case 4: return "E";
                case 5: return "F";
                case 6: return "G";
                case 7: return "H";
                case 8: return "I";
                case 9: return "J";
                case 10: return "K";
                case 11: return "L";
                case 12: return "M";
                case 13: return "N";
                case 14: return "O";
                case 15: return "P";
                case 16: return "Q";
                case 17: return "R";
                case 18: return "S";
                case 19: return "T";
                case 20: return "U";
                case 21: return "V";
                case 22: return "W";
                case 23: return "X";
                case 24: return "Y";
                case 25: return "Z";

            }
            return " ";
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
