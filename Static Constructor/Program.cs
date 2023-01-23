using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Program
    {
        private int productID;
        private string productName;
        public static string sellerName;

        //Paramaterised Constructor
        public Program(int productID, string productName)
        {
            this.productID = productID;
            this.productName = productName;
        }

        //static Constructor
        static Program()
        {
            sellerName = "Aaryan";
        }
        static void Main(string[] args)
        {
            Program obj = new Program(1001, "Iphone");

            Console.WriteLine(obj.productID);
            Console.WriteLine(obj.productName);
            Console.WriteLine(sellerName);
            Console.ReadKey();
        }
    }
}
