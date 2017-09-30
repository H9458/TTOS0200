using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Employee
    {
        //Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Salary { get; set; }



        // default constructor
        public Employee()
        {
        }

        // constructor takes person firstname and lastname as a parameter
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Nimi:" + FirstName + " " + LastName + " " + "\nProfession:" + Profession + " " + "\nSalary:" + Salary;
        }
    }
    class Boss : Employee
    {
        public string Car { get; set; }
        public string Bonus { get; set; }

        public Boss(string firstName, string lastName, string car, string bonus)
            : base(firstName, lastName)
        {
            Car = car;
            Bonus = Bonus;
        }
        public override string ToString()
        {
            return base.ToString() + "\nAuto:" + Car + " " + "\nBonus:" + Bonus;
        }

        public static void main()
        {
            // create a one Person object
            Employee person = new Employee();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Profession = "Teacher";
            person.Salary = "1200";
            Console.WriteLine(person.ToString());

            // create a one Teacher Object
            Boss boss = new Boss("Paavo", "Pomo", "Audi", "5000");
            boss.Profession = "Head of Institute";
            boss.Salary = "9000 ";
            boss.Car = "Audi";
            boss.Bonus = "5000";
            Console.WriteLine(boss.ToString());

        }

    }
    class Vehicle
    {
        //Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja. Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä. Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.
        public string Name { get; set; }
        public string Model { get; set; }
        public string YearModel { get; set; }
        public string Color { get; set; }

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
            return "Name:" + Name + " Model:" + Model + " Yearmodel:" + YearModel + " Color:" + Color;
        }
    }
    class Bike : Vehicle
    {
        public string GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike(string name, string model, string gearwheels, string gearname)
            : base(name, model)
        {
            GearWheels = gearwheels;
            GearName = gearname;
        }

        public override string ToString()
        {
            return base.ToString() + "Gearwheels:" + GearWheels + " " + "Gearname:" + GearName;
        }
    }
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public string SeatCount { get; set; }

        public Boat(string name, string model, string boattype, string seatcount)
            : base(name, model)
        {
            BoatType = boattype;
            SeatCount = seatcount;
        }

        public override string ToString()
        {
            return base.ToString() + "Boattype:" + BoatType + " " + "Seatcount:" + SeatCount + "\n";
        }

        public static void main()
        {
           
            Boat boat = new Boat("Yamaha", "Model 1200" , "Motorboat", "5");
            boat.YearModel= "1990";
            boat.Color = "White";
            Console.WriteLine(boat.ToString());

            
            Bike bike = new Bike("Jopo", "City", "False", "N/A");
            bike.YearModel = "2010";
            bike.Color = "Blue ";
            Console.WriteLine(bike.ToString());

        }
    }

}
