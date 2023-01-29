using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComaparable_and_IComparer_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            { Sid = 101, Name = "Nitin", ClassName = "12th", Marks = 80.5, };
            Student s2 = new Student()
            { Sid = 102, Name = "Aaryan", ClassName = "12th", Marks = 70 };
            Student s3 = new Student()
            { Sid = 103, Name = "Gaurav", ClassName = "12th", Marks = 90 };
            Student s4 = new Student()
            { Sid = 104, Name = "Sidhu", ClassName = "12th", Marks = 89.6 };

            List<Student> students = new List<Student>() { s1, s2, s3, s4 };
            students.Sort();
            Console.WriteLine("Comparision based on SId");
            foreach (var s in students)
            {
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.ClassName + " " + s.Marks);
            }

            StudentCompare obj = new StudentCompare();

            students.Sort(obj);
            students.Reverse();
            Console.WriteLine("\nComparision based on Marks");

            foreach (var s in students)
            {
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.ClassName + " " + s.Marks);
            }
            Console.ReadKey();
        }
    }
}
