using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Example
{
    public class TupleExample
    {
        public Tuple<string, int> GetPersonDetails()
        {
            string Name = "Nitin";
            int age = 23;
            Tuple<string, int> tuple = new Tuple<string, int>(Name, age);
            return tuple;
        }

        //Value Tuple
        public (int custId, string custName, int age) GetCustomerDetails()
        {
            return (1001, "Aaryan", 24);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TupleExample example = new TupleExample();
            Tuple<string, int> person = example.GetPersonDetails();

            //Value Tuple
            var customer1 = example.GetCustomerDetails();

            Console.WriteLine(customer1.custId+ " " + customer1.custName+ " " + customer1.age);

            //Deconstructing
            (int cId, string cName, int age) = example.GetCustomerDetails();

            Console.WriteLine(cId);
            Console.WriteLine(cName);
            Console.WriteLine(age);

            //Discard
            (int custId, string custName, _) = example.GetCustomerDetails();

            Console.WriteLine(custId);
            Console.WriteLine(custName);

            //access value from tuple
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            Console.ReadKey();
        }
    }
}
