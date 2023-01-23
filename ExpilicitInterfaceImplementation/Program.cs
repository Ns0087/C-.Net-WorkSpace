using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpilicitInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp;
            emp = new Employee
            {
                EmpID = 101, EmpName="Nitin", Location = "Noida", DOB = System.Convert.ToDateTime("1999-08-30")
            };

            Console.WriteLine(emp.GetAge());

            IPerson person;
            person = new Employee
            {
                EmpID = 101,
                EmpName = "Nitin",
                Location = "Noida",
                DOB = System.Convert.ToDateTime("1999-08-30")
            };

            Console.WriteLine(person.GetAge());

            Console.ReadKey();
        }
    }
}
