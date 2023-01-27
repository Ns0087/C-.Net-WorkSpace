using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation = int.Parse(Console.ReadLine());
            string result;

            result = operation switch
            {
                1 => "Customer",
                2 => "Employee",
                3 => "Supplier",
                4 => "Distributor",
                _ => "No Case Available"
            };

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
