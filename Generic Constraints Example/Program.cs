using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Constraints_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
            mp.stu = new GraduateStudent() { Marks = 80 };
            mp.PrintMarks();

            Console.ReadKey();
        }
    }

    class MarksPrinter<T> where T : Student
    {
        public T stu;
        public void PrintMarks()
        {
            Student temp = (Student)stu;
            Console.WriteLine(temp.Marks);
        }
    }

    public abstract class Student
    {
        public abstract int Marks { get; set; }
    }

    public class GraduateStudent : Student
    {
        public override int Marks { get; set; }
    }

    public class PostGraduateStudent : Student
    {
        public override int Marks { get; set; }

    }
}
