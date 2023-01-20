using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterGetter
{
    class Program
    {
        public int productID;
        public string productName;
        public double cost;

        //setter
        public void setProductID(int value)
        {
            productID = value;
        }

        //getter
        public int getProductID()
        {
            return productID;
        }

        //setter
        public void setProductName(string value)
        {
            productName = value;
        }

        //getter
        public string getProductName()
        {
            return productName;
        }
        //setter
        public void setCost(double value)
        {
            cost = value;
        }

        //getter
        public double getCost()
        {
            return cost;
        }
        static void Main(string[] args)
        {
            Program obj1;
            obj1 = new Program();

            obj1.setProductID(101);
            obj1.setProductName("Iphone");
            obj1.setCost(1200000.0);

            Console.WriteLine(obj1.getProductID());
            Console.WriteLine(obj1.getProductName());
            Console.WriteLine(obj1.getCost());

            Console.ReadKey();
        }
    }
}
