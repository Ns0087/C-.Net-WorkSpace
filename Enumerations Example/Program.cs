using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PersonName = "Aaryan";
            person.Email = "nitinsaraswat.30@gmail.com";
            person.AgeGroup = AgeGroupEnmeration.Adult;

            string str1 = "Aaryan";
            string str2 = "Aaryan";

            //overloaded Equals method
            if (str2.Equals(str1))
            {
                Console.WriteLine("Equals");
            }

            if (Equals(str1, str2))
            {
                Console.WriteLine("Equals");
            }

            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Email);
            Console.WriteLine(person.AgeGroup);
            Console.WriteLine(person.GetType());
            Console.WriteLine(person.GetHashCode());
            Console.WriteLine(person.ToString());
            Console.ReadKey();
        }
    }
}
