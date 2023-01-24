using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Example
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Country country = new Country();

            Console.WriteLine(Country.CountryName);
            Console.WriteLine(Country.NoOfStates);
            Console.WriteLine(Country.GetNoOfUnionTerritories());

            Console.ReadKey();
        }
    }
}
