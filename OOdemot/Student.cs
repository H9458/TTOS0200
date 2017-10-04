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
        public Student (string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + "ASIOID " + AsioID;
        }
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
    }
}
