using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_2
{
    internal static class Program
    {
        static Tentity ExtensionMethods<Tmodel, Tentity>(this Tmodel class1)
        {
            Tentity class2 = (Tentity)Activator.CreateInstance(typeof(Tentity));

            PropertyInfo[] Class1properties = typeof(Tmodel).GetProperties();
            PropertyInfo[] Class2properties = typeof(Tentity).GetProperties();

            foreach(var property in Class2properties)
            {
                
                property.SetValue(class2, typeof(Tmodel).GetProperty(property.Name).GetValue(class1)) ;
            }

            return class2;
        }

        static void Main(string[] args)
        {
            Class1 class1 = new Class1()
            {
                MyProperty1= 1,
                MyProperty2= 2,
                MyProperty3= 3,
                MyProperty4= 4,
                MyProperty5= 5,
                MyProperty6= 6,
                MyProperty7= 7,
                MyProperty8= 8,
                MyProperty9= 9,
                MyProperty10= 10
            };


            Class2 class2 = class1.ExtensionMethods<Class1, Class2>();
            

            Console.WriteLine(class2.MyProperty1);
            Console.WriteLine(class2.MyProperty2);
            Console.WriteLine(class2.MyProperty3);
            Console.WriteLine(class2.MyProperty4);
            Console.WriteLine(class2.MyProperty5);

            Console.ReadKey();


        }
    }
}
