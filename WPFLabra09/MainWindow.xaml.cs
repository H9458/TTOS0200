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

namespace WPFLabra09
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

        private void txbTruck_TextChanged(object sender, TextChangedEventArgs e)
        {
            int lkm = int.Parse(txbTruck.Text);
            txbTruck.Text = "" + lkm;
        }

        private void txbCar_TextChanged(object sender, TextChangedEventArgs e)
        {
            int lkm = int.Parse(txbCar.Text);
            txbCar.Text = "" + lkm;
        }

        private void BtnCar_Click(object sender, RoutedEventArgs e)
        {
            int lkm = int.Parse(txbCar.Text) + 1;
            txbCar.Text = "" + lkm;
        }

        private void BtnTruck_Click(object sender, RoutedEventArgs e)
        {
            int lkm = int.Parse(txbTruck.Text) + 1;
            txbTruck.Text = "" + lkm;
        }

    
    }
}
