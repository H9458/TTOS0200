﻿using System;
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
            else
            {
                if (luku != luku1 && luku != luku2 && luku != luku3) ;
                {
                    Console.WriteLine("Joku muu luku.");
                }
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
            Console.WriteLine("Lukujen summa on: "+ (luku1+luku2+luku3));
            Console.WriteLine("Lukujen keskiarvo on: "+(luku1+luku2+luku3)/3);

        }

        public static void Tehtava04()
        {
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
        

    }
    
}


        
    

