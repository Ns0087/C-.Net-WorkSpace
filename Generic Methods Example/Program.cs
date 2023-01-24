using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<int> x = null;
            int? x = null;
            Sample sample = new Sample();
            Student student = new Student() { Marks=80};
            Employee employee = new Employee() { Salary = 1000.00 };

            sample.PrintData<Student>(student);
            sample.PrintData<Employee>(employee);
            Console.WriteLine(x.HasValue);
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public double Salary;

    }

    public class Student
    {
        public int Marks;
    }

    public class Sample
    {
        public void PrintData<T>(T obj)
        {
            if (obj.GetType() == typeof(Student))
            {
                Student temp = obj as Student;
                Console.WriteLine(temp.Marks);
            }
            else
            {
                Employee temp = obj as Employee;
                Console.WriteLine(temp.Salary);
            }
        }
    }
}
