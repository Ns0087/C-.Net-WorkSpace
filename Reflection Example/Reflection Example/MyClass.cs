using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Example
{
    internal class MyClass
    {
        public int Id { get { return 10; } set { this.Id = 10; } }
        public string Name { get; set; }
        public string Course { get; set; }
        public DateTime DOB { get; set; }

        public int GetAge(DateTime DOB)
        {
            int days = (int)Math.Abs(DOB.Subtract(DateTime.Now).TotalDays);
            int age = days / 365;

            return age;
        }

        public void PrintID(int ID)
        {
            Console.WriteLine("Id is : " + ID);
        }

        public void PrintName(string Name)
        {
            Console.WriteLine("Name is : " + Name);
        }
    }
}
