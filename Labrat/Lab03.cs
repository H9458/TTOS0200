using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public class Lab03
    //Tee luokka, jolla on seuraavat staattiset metodit:
    //bool OnkoLuku(string syote) ja bool OnkoPvm(string syote)
    //Metodi OnkoLuku tutkii annetun merkkijonon ja palauttaa true jos syöte on muunnettavissa luvuksi(kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä).
    {
        public static void OnkoLuku(string syote)
        {

        }
        public static void OnkoPvm(string syote)
        {

        }

        public static void main(string[] args)
        {
            Labrat.Lab03.OnkoLuku("ok");
        }
    }

    public class Hissi
    //Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.
    //Vahvistin alapuolella paremmin tehty
    {
        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                kerros = value;
                if (value < 1)
                {
                    Console.WriteLine("Liian pieni kerros");
                    kerros = 1;
                }
                if (value > 5)
                {
                    Console.WriteLine("Liian suuri kerros");
                    kerros = 5;
                }
            }
        }

        public static void main()
        {
            Hissi hissi = new Hissi();

            do
            {
                Console.WriteLine("Anna kerros (1-5): ");
                hissi.kerros = int.Parse(Console.ReadLine());
                Console.WriteLine("Nykyinen kerros on: {0}", hissi.kerros);
                Console.WriteLine(" ");
            }
            while (hissi.kerros < 6 && hissi.kerros > 0);



        }
    }

    public class Vahvistin
    //Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100. Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla. Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.
    {
        private const int minVolume = 0;
        private const int maxVolume = 100;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                
                if (value < minVolume)
                {
                 
                    Console.WriteLine("Äänettömällä, volume on nyt: "+ minVolume);
                    volume = minVolume;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Liian kovalla, volumme on nyt: "+ maxVolume);
                    volume = maxVolume;
                }
                else
                {
                    Console.WriteLine("Volume on: " + value);
                    volume = value;
                }
            }

        }

        public static void main()
        {
            Vahvistin vahvistin = new Vahvistin();
            bool result;
            do
            {
                Console.WriteLine("Anna volumi (1-100): ");
                String syote = Console.ReadLine();
                int volume;
                result = Int32.TryParse(syote, out volume);
               
                if (result)
                {
                    vahvistin.Volume = volume;
                }
            }
            while (result);



        }

    }
}
