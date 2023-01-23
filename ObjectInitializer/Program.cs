using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    class Program
    {
        public int productID;
        public string productName;
        public double cost;

        static void Main(string[] args)
        {
            Program obj = new Program()
            {
                productID = 101,
                productName = "Iphone",
                cost = 1000.112
            };

            Console.WriteLine(obj.productID);
            Console.WriteLine(obj.productName);
            Console.WriteLine(obj.cost);
            Console.ReadKey();
        }
    }
}
