using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Labrat
{
    class Dice
    {
        public static void main()
        {
            try
            {
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filu = filupath + @"\nopanheitot.txt";
                System.IO.StreamWriter DiceFile = new System.IO.StreamWriter(filu);

                Random rnd = new Random();
                int summa = 0;
                int heitot;
                Console.Write("Anna heittojen lkm: ");
                heitot = int.Parse(Console.ReadLine());

                int yksi  = 0;
                int kaksi = 0;
                int kolme = 0;
                int neljä = 0;
                int viisi = 0;
                int kuusi = 0;

                for (int i = 0; i < heitot; i++)
                {
                    var roll = rnd.Next(1, 7);
                    //Console.WriteLine(roll.ToString());
                    DiceFile.WriteLine(roll);
                    summa += roll;
                }

                DiceFile.Close();
                int avg = summa / heitot;

                if (File.Exists(filu))
                {
                    Console.WriteLine("\nHeitot:");
                    Console.WriteLine("Keskiarvo on {0}", avg);
                    //string tulostus = File.ReadAllText(filu);
                    //Console.WriteLine(tulostus);

                    string[] lines = File.ReadAllLines(filu);
                    foreach (string line in lines)
                    {
                        //Console.WriteLine(line);
                        switch (line)
                        {
                            case "1":
                                yksi++;
                                break;
                            case "2":
                                kaksi++;
                                break;
                            case "3":
                                kolme++;
                                break;
                            case "4":
                                neljä++;
                                break;
                            case "5":
                                viisi++;
                                break;
                            case "6":
                                kuusi++;
                                break;
                        }
                    }
                    //int lkm = File.ReadAllLines(filupath + @"\nopanheitot.txt").Count();
                    //Console.WriteLine("Löytyi {0} riviä", lkm);
                    Console.WriteLine("Numero 1 tuli {0} kertaa", yksi);
                    Console.WriteLine("Numero 2 tuli {0} kertaa", kaksi);
                    Console.WriteLine("Numero 3 tuli {0} kertaa", kolme);
                    Console.WriteLine("Numero 4 tuli {0} kertaa", neljä);
                    Console.WriteLine("Numero 5 tuli {0} kertaa", viisi);
                    Console.WriteLine("Numero 6 tuli {0} kertaa\n", kuusi);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
 
    [Serializable]
    class Product
    {
        public string Nimi { get; set; }
        public float Hinta { get; set; }


        public static void main()
        {
            
            List<Product> tuote = new List<Product>();
            tuote.Add(new Product { Nimi= "Juusto", Hinta = 6.99F});
            tuote.Add(new Product { Nimi="Maito", Hinta = 1.2F});
            tuote.Add(new Product { Nimi="Banaani", Hinta = 1.3F });

            //Ctrl c + ctrl v "Olioiden kirjoittaminen/lukeminen tiedostoon"
            #region CopyRegion
            Stream writeMultipleStream = new FileStream("Tuotteet.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            // write persons array to disk, note: uses formatter in previous code
            formatter.Serialize(writeMultipleStream, tuote);
            // close file
            writeMultipleStream.Close();

            // create stream for reading persons
            Stream openStream = new FileStream("Tuotteet.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            // create a list and read persons into it from disk
            List<Product> tuotelista = (List<Product>)formatter.Deserialize(openStream);
            // close stream
            openStream.Close();

            // proof
            foreach (Product p in tuotelista)
            {
                Console.WriteLine("Tuote: {0} {1}e", p.Nimi, p.Hinta);
            }

            #endregion
        }
    }

}
