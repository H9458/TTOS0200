using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Tiedosto
    {

    }

    class Ohjelma2
    {
        public static void main()
        {
            //KÄYTTÄKÄÄ AINA TRY-CATCHIA!
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                string filu = filupath + @"\testi.txt";
                //kirjoitetaan käyttäjän antama rivit tiedostoon 
                //luodaan StreamWriter tyyppinen olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa):");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                    {
                        sw.WriteLine(nimi);
                    }
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine("\nTiedoston sisältö:");
                    Console.WriteLine(teksti);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }

    class Lukeminen
    {
        public static void main()
        {
            try
            {
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filu = filupath + @"\nimet.txt";

                int Pekka = 0;
                int Arttu = 0;
                int Liisa = 0;
                int Maija = 0;

                if (File.Exists(filu))
                {
                    string text = File.ReadAllText(filu);
                    string[] lines = File.ReadAllLines(filu);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                        switch (line)
                        {
                            case "Pekka":
                                Pekka++;
                                break;
                            case "Arttu":
                                Arttu++;
                                break;
                            case "Liisa":
                                Liisa++;
                                break;
                            case "Maija":
                                Maija++;
                                break;
                        }
                    }

                    int lkm = File.ReadAllLines(filupath + @"\nimet.txt").Count();
                    Console.WriteLine("\nLöytyi {0} riviä", lkm);
                    Console.WriteLine("Nimi Pekka esiintyy {0} kertaa", Pekka);
                    Console.WriteLine("Nimi Arttu esiintyy {0} kertaa", Arttu);
                    Console.WriteLine("Nimi Liisa esiintyy {0} kertaa", Liisa);
                    Console.WriteLine("Nimi Maija esiintyy {0} kertaa", Maija);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    class Luvut
    {
        public static void main()
        {
            try
            {
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filu1 = filupath + @"\koko.txt";
                string filu2 = filupath + @"\reali.txt";
                System.IO.StreamWriter KokoFile = new System.IO.StreamWriter(filu1);
                System.IO.StreamWriter RealiFile = new System.IO.StreamWriter(filu2);

                string luku;
                double d;
                int i;

                do
                {
                    Console.WriteLine("Syötä realiluku tai kokonaisluku (Enter tai kirjain lopettaa)");
                    Console.Write("Anna luku:");
                    luku = Console.ReadLine();

                    if (double.TryParse(luku, out d))
                    {
                        RealiFile.WriteLine(luku);
                        Console.WriteLine("-Realiluku tallennettu-\n");
                    }
                    else if (int.TryParse(luku, out i))
                    {
                        KokoFile.WriteLine(luku);
                        Console.WriteLine("-Kokonaisluku tallennettu-\n");
                    }

                }
                while (double.TryParse(luku, out d) || int.TryParse(luku, out i));

                KokoFile.Close();
                RealiFile.Close();

                if (File.Exists(filu1))
                {
                    string teksti1 = File.ReadAllText(filu1);
                    Console.WriteLine("\nKokonaisluvut:");
                    Console.WriteLine(teksti1);
                }
                if (File.Exists(filu2))
                {
                    string teksti2 = File.ReadAllText(filu2);
                    Console.WriteLine("\nRealiluvut:");
                    Console.WriteLine(teksti2);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }  
    } 
}