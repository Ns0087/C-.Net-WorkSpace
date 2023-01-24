using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.ProductID = 101;
            p.Cost = 1000.00;
            p.CallGetTax();
            ReadKey();
        }
    }
}
