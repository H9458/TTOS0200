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

namespace WPFLabra10T2
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

        private void btnHae_Click(object sender, RoutedEventArgs e)
        {
            dgPelaajat.ItemsSource = Joukkoe.HaePelaajat();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dgPelaajat.ItemsSource = "";
        }
    }

    public static class Joukkoe
    {
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> lista = new List<Pelaaja>();

            lista.Add(new Pelaaja("ANTTONI", "HONKA", "R", 3));
            lista.Add(new Pelaaja("JUUSO", "VAINIO", "R", 5));
            lista.Add(new Pelaaja("MIKKO", "KALTEVA", "L", 7));
            lista.Add(new Pelaaja("JAAKKO", "JOKINEN", "L", 16));
            lista.Add(new Pelaaja("ALEX", "LINDROOS", "L", 34));
            lista.Add(new Pelaaja("PEKKA", "PERJANTAI", "R", 66));
            lista.Add(new Pelaaja("PELAAJA1", "TÄYTTÖ1", "R", 11));
            lista.Add(new Pelaaja("PELAAJA2", "TÄYTTÖ2", "L", 22));
            lista.Add(new Pelaaja("PELAAJA3", "TÄYTTÖ3", "R", 33));

            return lista;
        }
    }
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Kätisyys { get; set; }
        public int Numero { get; set; }
        public Pelaaja(string etunimi, string sukunimi, string kätisyys, int numero)
        {

            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Kätisyys = kätisyys;
            Numero = numero;
        }
    }
}
