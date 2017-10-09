using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Tyre: Vehicle
    {
        public string Size { get; set; }

      
        public Tyre(string name, string model, string size)
            :base(name, model)
        {
            Size = size;
        }
        public override string ToString()
        {
            return "Nimi: " + Name + "Model: " + Model + "Size: " + Size;
        }
    }

    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string NumTyres { get; set; }
      

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public override string ToString()
        {
            return "Name:" + Name + " Model:" + Model + " Tyres:" + NumTyres;
        }

        public static void main()
        {
            Vehicle Audi = new Vehicle("Audi","A6");
            Audi.NumTyres = "4";
            Console.WriteLine(Audi.ToString());

            Vehicle Suzuki = new Vehicle("Suzuki", "T1000");
            Suzuki.NumTyres = "2";
            Console.WriteLine(Suzuki.ToString());
        }
    }

    abstract class Nisakas
    {
        public int Ika = 0;
        
   
        public abstract void Liiku();
               
    }
    class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public Ihminen(string nimi, int paino, int pituus)
        {
            Nimi = nimi;
            Paino = paino;
            Pituus = pituus;
        }
        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }
        public override string ToString()
        {
            return "Nimi:" + Nimi + " Paino:" + Paino + " Pituus:" + Pituus;
        }
    }

    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(string nimi, int paino, int pituus, string auto)
            :base(nimi,paino,pituus)
        {
            Auto = auto;
        }
        public override void Liiku()
        {
            Console.WriteLine("Kävelee");
        }
        public override string ToString()
        {
            return "\nNimi:" + Nimi + " Paino:" + Paino + " Pituus:" + Pituus + " Auto:" + Auto;
        }
    }

    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string nimi, int paino, int pituus, string vaippa)
            :base(nimi,paino,pituus)
        {
            Vaippa = vaippa;
        }
        public override void Liiku()
        {
            Console.WriteLine("Konttaa");
        }
        public void Kasva()
        {
            Ika += 1;
        }
        public override string ToString()
        {
            return "\nNimi:" + Nimi + " Paino:" + Paino + " Pituus:" + Pituus + " Vaippa:" + Vaippa;
        }
    }
    class Ohjelma
    {
        public static void main()
        {
            Ihminen ihminen = new Ihminen("Pekka",100,180);
            Console.WriteLine(ihminen.ToString());
            ihminen.Liiku();

            Aikuinen aikuinen = new Aikuinen("Jere", 80, 175,"Mersu");
            Console.WriteLine(aikuinen.ToString());
            aikuinen.Liiku();

            Vauva vauva = new Vauva("Eetu",10,50,"Puhdas");
            Console.WriteLine(vauva.ToString());
            vauva.Liiku();
        }
    }
}
