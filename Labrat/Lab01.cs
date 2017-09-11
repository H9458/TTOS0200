using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmonnin viikkotehtävät Labra1
//Lassi Markkola
namespace Labrat
{
    class Lab01
    {
        public static void Tehtava01()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua
            int luku;
            int luku1 = 1;
            int luku2 = 2;
            int luku3 = 3;
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Annoit luvun: " + luku);

            if (luku == luku1)
            {
                Console.WriteLine("Yksi ");
            }
            if (luku == luku2)
            {
                Console.WriteLine("Kaksi ");
            }
            if (luku == luku3)
            {
                Console.WriteLine("Kolme ");
            }
            if  (luku < 1 || luku > 3)
                {
                    Console.WriteLine("Joku muu luku.");
                }
        
        }


        public static void Tehtava02()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):

            int luku;
            Console.WriteLine("Anna pistemäärä: ");
            luku = int.Parse(Console.ReadLine());
            if (luku >= 0 && luku <= 1)
            {
                Console.WriteLine("Koulunumerosi on: " + 0);
            }
            else if (luku >= 2 && luku <= 3)
            {
                Console.WriteLine("Koulunumerosi on: " + 1);
            }
            else if (luku >= 4 && luku <= 5)
            {
                Console.WriteLine("Koulunumerosi on: " + 2);
            }
            else if (luku >= 6 && luku <= 7)
            {
                Console.WriteLine("Koulunumerosi on: " + 3);
            }
            else if (luku >= 8 && luku <= 9)
            {
                Console.WriteLine("Koulunumerosi on: " + 4);
            }
            else if (luku >= 10 && luku <= 12)
            {
                Console.WriteLine("Koulunumerosi on: " + 5);
            }
            else if (luku >= 13)
            {
                Console.WriteLine("Annoit liian suuren pistemäärän. Yritä uudelleen.");
            }


        }

        public static void Tehtava03()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
            int luku1;
            int luku2;
            int luku3;
            Console.WriteLine("Anna luku1: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku2: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku3: ");
            luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lukujen summa on: " + (luku1 + luku2 + luku3));
            Console.WriteLine("Lukujen keskiarvo on: " + (luku1 + luku2 + luku3) / 3);

        }

        public static void Tehtava04()
        {
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
            int luku;
            Console.WriteLine("Anna ikä: ");
            luku = int.Parse(Console.ReadLine());
            if (luku >= 0 && luku <= 17)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (luku >= 18 && luku <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else if (luku >= 66)
            {
                Console.WriteLine("Seniori");
            }


        }

        public static void Tehtava05()
        {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
            int sekunti;
            Console.WriteLine("Anna sekuntimäärä: ");
            sekunti = int.Parse(Console.ReadLine());
            TimeSpan span = new TimeSpan(0, 0, sekunti);

            Console.WriteLine("{0:0}h {1:00}m {2:00}s", span.Hours, span.Minutes, span.Seconds);
        }

        public static void Tehtava06()
        {
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
            double kulutus = 0.0702;
            int matka;
            Console.WriteLine("Anna matkan pituus (km): ");
            matka = int.Parse(Console.ReadLine());
            double litraa = kulutus * matka;
            double hinta = litraa * 1.595;
            Console.WriteLine("matkaan kuluu {0} litraa bensaa ja {1} euroa", litraa, hinta);
        }

        public static void Tehtava07()
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
            int vuosi;
            Console.WriteLine("Anna vuosiluku");
            vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 400 == 0)
                Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
            else if (vuosi % 100 == 0)
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
            else if (vuosi % 4 == 0)
                Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
            else
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
            Console.ReadKey();

        }

        public static void Tehtava08()
        {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            Console.WriteLine("Anna 3 numeroa: ");
            double luku1 = double.Parse(Console.ReadLine());
            double luku2 = double.Parse(Console.ReadLine());
            double luku3 = double.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on: " + luku1);
            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on: " + luku2);
            }
            else
            {
                Console.WriteLine("Suurin luku on: " + luku3);
            }

        }

        public static void Tehtava09()
        {
            //Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
            string x;
            double t, s = 0;
      

            Console.WriteLine("Numero 0 lopettaa ohjelman");
            Console.WriteLine("Anna numeroita: ");
            while ((x = Console.ReadLine()) != "0")
            {
                t = Convert.ToDouble(x);
                s += t;
               
            }
            Console.WriteLine("Numeroiden summa on: {0}", s);
           
        }

        public static void Tehtava10()
        {
            //Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
            int[] numero = new int[9];
            numero[0] = 1;
            numero[1] = 2;
            numero[2] = 33;
            numero[3] = 44;
            numero[4] = 55;
            numero[5] = 68;
            numero[6] = 77;
            numero[7] = 96;
            numero[8] = 100;
            foreach (int x in numero)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("{0} HEP!", x);
                }
                else if (x % 2 != 0)
                {
                    Console.WriteLine("{0}", x);
                }
            }
        }

        public static void Tehtava11()
        {
            //Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
            int x;
            Console.WriteLine("Anna rivimäärä: ");
            x = int.Parse(Console.ReadLine());
            for (int rivi = 1; rivi <= x; ++rivi)
            {
                for (int lkm = 1; lkm <= rivi; ++lkm)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            } 
        }

    }
}


        
    

