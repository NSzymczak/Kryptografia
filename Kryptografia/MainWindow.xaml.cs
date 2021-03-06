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

namespace Kryptografia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonNWD_Click(object sender, RoutedEventArgs e)
        {
            WindowNWD nwd = new WindowNWD();
            nwd.ShowDialog();
        }

        private void ButtonChinskie_Click(object sender, RoutedEventArgs e)
        {
            WindowChinskie windowChinskie = new WindowChinskie();
            windowChinskie.ShowDialog();
        }

        private void ButtonAfiniczny_Click(object sender, RoutedEventArgs e)
        {
            WindowAfiniczny windowAfiniczny=new WindowAfiniczny();
            windowAfiniczny.ShowDialog();
        }

        private void ButtonHill_Click(object sender, RoutedEventArgs e)
        {
            WindowHill windowHill = new WindowHill();
            windowHill.ShowDialog();
        }

        private void ButtonRSA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCalc_Click(object sender, RoutedEventArgs e)
        {
            WindowCalc win = new WindowCalc();
            win.ShowDialog(); 
        }


        private void ButtonGen_Click(object sender, RoutedEventArgs e)
        {
            WindowLog win = new WindowLog();
            win.ShowDialog();
        }
    }
}
