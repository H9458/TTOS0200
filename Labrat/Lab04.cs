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

            Boat boat = new Boat("Yamaha", "Model 1200", "Motorboat", "5");
            boat.YearModel = "1990";
            boat.Color = "White ";
            Console.WriteLine(boat.ToString());


            Bike bike = new Bike("Jopo", "City", "False", "N/A\n");
            bike.YearModel = "2010";
            bike.Color = "Blue ";
            Console.WriteLine(bike.ToString());

        }
    }

    class Radio
    {
        //Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). Laadi luokka kannettavan radion toteutukseksi. Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla. Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.
        public int OnOff { set; get; }
        private const int MinVolume = 0;
        private const int MaxVolume = 9;
        private const float MinHz = 2000.0f;
        private const float MaxHz = 26000.0f;
        private int volume;
        private float hz;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < MinVolume)
                {
                    Console.WriteLine("Volume asetettu minimiin: {0}", MinVolume);
                    volume = MinVolume;
                }
                else if (value > MaxVolume)
                {
                    Console.WriteLine("Volume asetettu maksimiin: {0}", MaxVolume);
                    volume = MaxVolume;
                }
                else
                {
                    Console.WriteLine("Volume on: {0}", value);
                    volume = value;
                }
            }
        }

        public float Hz
        {
            get
            {
                return hz;
            }
            set
            {
                if (value < MinHz)
                {
                    Console.WriteLine("Taajuus asetettu minimiin: {0}", MinHz);
                    hz = MinHz;
                }
                else if (value > MaxHz)
                {
                    Console.WriteLine("Taajuus asetettu maksimiin: {0} ", MaxHz);
                    hz = MaxHz;
                }
                else
                {
                    Console.WriteLine("Taajuus on: {0} ", value);
                    hz = value;
                }

            }

        }
        public static void SaadaVirta()
        {
            Radio radio = new Radio();
            int virta;

            Console.WriteLine("Aseta virta päälle/pois (1=päälle 0=pois): ");
            String syote = Console.ReadLine();

            virta = Int32.Parse(syote);

            if (virta == 1)
            {
                radio.OnOff = 1;
                Console.WriteLine("Virta on päällä");
            }
            else if (virta == 0)
            {
                Console.WriteLine("Virta on pois");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }

        }
        public static void SaadaVolumea()
        {
            Radio radio = new Radio();
            Console.WriteLine("Anna volume (0-9): ");
            String syote = Console.ReadLine();

            int i = int.Parse(syote);

            radio.Volume = i;
        }
        public static void SaadaTaajuus()
        {
            Radio radio = new Radio();
            Console.WriteLine("Anna taajuus (2000,0-26000,0 Hz): ");
            String syote = Console.ReadLine();

            float i = float.Parse(syote);

           radio.Hz = i;
        }
      public static void program()
        {
            Radio.SaadaVirta();
            Radio.SaadaVolumea();
            Radio.SaadaTaajuus();
        }
    }
}
