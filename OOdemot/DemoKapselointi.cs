using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOdemot
{
    class Thing
    {
        //julkinen jäsenmuuttuja != ominaisuus
        //public string Name;
        //parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
        //public string Name { get; set; }
        //ToString -metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Constructors
        public Thing()
        {
            name = "nobody here";
        }
        public override string ToString()
        {
            return "nimeni on: " + Name;
        }
    }
    class Program
    {
        public static void main(string[] args)
        {
            Thing t = new Thing();
            t.Name = "jotakin";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ToString());
        }
    }
    
}
