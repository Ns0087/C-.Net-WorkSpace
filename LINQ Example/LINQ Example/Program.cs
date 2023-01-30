using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee{EmpID = 101, Name = "Nitin", Age= 24},
                new Employee{EmpID = 102, Name = "Aaryan", Age = 24},
                new Employee{EmpID = 103, Name = "Ankit", Age = 22},
                new Employee{EmpID = 104, Name = "Suraj", Age = 28}
            };

            //Where Method
            var result = list.Where(e => e.Age == 24).OrderBy(e => e.Name).ToList();

            foreach (Employee emp in result)
            {
                Console.WriteLine(emp.Name);
            }

            //Aggregation Methods
            var result1 = list.Count();
            var result2 = list.Sum(e => e.Age);
            var result3 = list.Average(e => e.Age);
            var result4 = list.Min(e => e.Age);
            var result5 = list.Max(e => e.Age);

            //Grouping Methods
            var result6 = list.GroupBy(e => e.Age);

            Console.WriteLine("\n====================================================");
            foreach (var emp in result6)
            {
                Console.WriteLine("Age Group : {0}", emp.Key);
                foreach(var e in emp)
                {
                    Console.WriteLine("Employee Name : {0}", e.Name);
                }
            }


            Console.ReadKey();
        }
    }
}
