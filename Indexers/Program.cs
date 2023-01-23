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
        }
    }

    class Car
    {
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };

        public string this[int index]
        {
            get { return _brands[index]; }
            set { this._brands[index] = value; }
        }
    }
}
