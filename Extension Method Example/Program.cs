using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension_Method_Library;

namespace Extension_Method_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductCost = 1000;
            product.DiscountPercentage = 10;
            Console.WriteLine(product.GetDiscount());
            Console.ReadKey();
        }
    }
}
