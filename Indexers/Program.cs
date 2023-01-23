using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj[2] = "Nisaan";
            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj["first"]);
            Console.ReadKey();
        }
    }

    class Car
    {
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };
        private string[] _names = new string[] { "first", "second", "third" };

        public string this[int index]
        {
            get { return _brands[index]; }
            set { this._brands[index] = value; }
        }

        //Indexer OverLoading
        public string this[string name]
        {
            get { return _brands[Array.IndexOf(_names, name)]; }
            set { this._brands[Array.IndexOf(_names, name)] = value; }
        }
    }
}
