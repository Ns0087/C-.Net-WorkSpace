using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_Example
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection_Example.MyClass");

            Console.WriteLine("FullName : " + T.FullName);
            Console.WriteLine("ClassName : " + T.Name);
            Console.WriteLine("NameSpaceName : " + T.Namespace);

            //Properties
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Property Type : " + property.PropertyType.Name + ", Property Name : " + property.Name);
            }

            Console.WriteLine("==================================================================================================\n");

            //Methods and Parameters
            //PropertyInfo[] properties = T.GetProperties();
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method Signature : " + method.ToString());
                ParameterInfo[] parameters = method.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine("Parameter : " + parameter.ToString());
                }
            }


            Console.WriteLine("==================================================================================================\n");

            //Constructor
            //PropertyInfo[] properties = T.GetProperties();
            //MethodInfo[] methods = T.GetMethods();
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            Console.WriteLine("==================================================================================================\n");

            Console.ReadKey();

        }
    }
}
