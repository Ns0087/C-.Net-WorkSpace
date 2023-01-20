using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_Field
{
    class Program
    {
        public int productID;
        public string productName;
        public readonly string dateOfPurchase;

        //Constructor
        public Program()
        {
            dateOfPurchase = System.DateTime.Now.ToLongDateString();
        }
        static void Main(string[] args)
        {
            Program obj1, obj2;
            obj1 = new Program();
            obj2 = new Program();

            obj1.productID = 101;
            obj1.productName = "IPhone";

            obj2.productID = 102;
            obj2.productName = "Laptop";

            Console.WriteLine(obj1.productID + " " + obj1.productName + " " + obj1.dateOfPurchase);
            Console.WriteLine(obj2.productID + " " + obj2.productName + " " + obj2.dateOfPurchase);

            Console.ReadKey();
        }
    }
}
