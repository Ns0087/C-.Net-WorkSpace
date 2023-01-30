using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Sid = 101, Name = "Nitin", ClassName = "12th", Marks=89.4 };
            var obj4 = new { Sid = 102, Name = "Nitin", ClassName = "12th", Marks=89.0 };
            
            //Nested Anonymous type
            var obj2 = new { Sid = 102, Name = "Aaryan", ClassName = "12th", Marks = 90, Address = new { Street = "abc", City = "Ghaziabad", Pincode = "201009" } };

            //obj.Sid = 103;   //read-only properties

            //Anonymous Arrays
            var obj3 = new[] { obj, obj4, new { Sid = 101, Name = "Nitin", ClassName = "12th", Marks = 89.4 } };
            
            foreach(var item in obj3)
            {
                Console.WriteLine(item.Sid + " " + item.Name + " " + item.ClassName + " " + item.Marks);
            }

            Console.WriteLine(obj.Sid + " " + obj.Name + " " + obj.ClassName + " " + obj.Marks);
            Console.WriteLine(obj2.Sid + " " + obj2.Name + " " + obj.ClassName + " " + obj2.Marks + " " + obj2.Address.Street + " " + obj2.Address.City + " " + obj2.Address.Pincode);
            Console.ReadKey();
        }
    }
}
