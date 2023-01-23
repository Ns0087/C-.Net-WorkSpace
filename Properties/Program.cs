using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.CarBrand = "BMW";
            obj.NativePlace = "Ghaziabad";
            Console.WriteLine(obj.CarBrand);
            Console.WriteLine(obj.NativePlace);
            Console.WriteLine(Car.Seller);
            Console.ReadKey();
        }
    }

    class Car
    {
        private string carBrand;
        private static string seller = "Aaryan";


        public string CarBrand
        {
            get { return carBrand; }
            set
            {
                if(value.Length <= 20) {
                    this.carBrand = value;
                }else
                {
                    Console.WriteLine("Enter Brand Name less than 20 characters");
                }
            }
        }

        //ReadOnly Property
        public static string Seller {
            get { return seller; }
        }

        //Auto-Implemented Property
        public string NativePlace { get; set; }
    }
}
