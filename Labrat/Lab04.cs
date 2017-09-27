using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Employee
    {
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
            return "Nimi:" +FirstName + " " + LastName + " " + "\nProfession:" + Profession + " " + "\nSalary:" + Salary;
        }
    }
    class Boss : Employee
    {
        public string Car { get; set; }
        public string Bonus { get; set; }

        public Boss(string firstName, string lastName, string car, string bonus) 
            : base(firstName,lastName)
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

}
