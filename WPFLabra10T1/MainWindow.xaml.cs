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

namespace WPFLabra10T1
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

        private void BoxMilk_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BoxButter_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BoxBeer_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BoxChicken_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BoxLemonade_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            string msg = "";
            List<string> lista = new List<string>();

            if ((bool)BoxMilk.IsChecked)
            {
                lista.Add("Milk");
            }

            if ((bool)BoxButter.IsChecked)
            {
                lista.Add("Butter");
            }
  
            if ((bool)BoxBeer.IsChecked)
            {
                lista.Add("Beer");
            }
    
            if ((bool)BoxChicken.IsChecked)
            {
                lista.Add("Chicken");
            }
  
            if ((bool)BoxLemonade.IsChecked)
            {
                lista.Add("Lemonade");
            }
            foreach (string item in lista)
            {
                msg += item + " ";
            }
            txtBox.Text = msg;
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
