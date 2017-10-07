using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOdemot
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioID { get; set; }
        public Student()
        {

        }
        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + "ASIOID " + AsioID;
        }
    }
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students;
        //konstuktori
        public Group()
        {
            Students = new List<Student>();
            //luettaisiin esimerkiksi tietokannasta ne oppilaitten tiedot
            Students.Add(new Student("Pelle", "Peloton"));
            Students.Add(new Student("Aku", "Ankka"));
            Students.Add(new Student("Mikki", "Hiiri"));
        }
        //ylikirjoitetaan ToString
        public override string ToString()
        {
            string retval = "Luokka " + Name + " sisältää oppilaat\n";
            foreach (Student item in Students)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
        public static void main()
        {
            Student s = new Student();
            s.FirstName = "Esa";
            s.LastName = "Salmikangas";
            Student s2 = new Student("Pekka", "Perjantai");
            //luodaan kokoelma Student-olioita, käytetään List
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaltonen"));
            //näytetään oppilaat
            Console.WriteLine("Luokan oppilaat: ");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
            //testataan Group-luokka
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Aurinko"));
            Console.WriteLine(luokka.ToString());
        }
    }
}
