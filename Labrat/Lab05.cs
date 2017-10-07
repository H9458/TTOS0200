using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Tyre
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
    }

    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Model: " + Model;
        }

    }
}
