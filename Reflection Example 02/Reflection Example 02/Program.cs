using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_Example_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load the current executing assembly as the MyClass class is present in it.
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Load the MyClass class for which we want to create an instance dynamically
            Type myClassType = assembly.GetType("Reflection_Example_02.MyClass");

            // Create the instance of the MyClass type using Activator class 
            object myClassInstance = Activator.CreateInstance(myClassType);

            // Get the method information using the myClassType and GetMethod()
            MethodInfo GetFullNameMethod = myClassType.GetMethod("GetFullName");

            // Create the parameter array and populate first and last names
            object[] parameters = { "Nitin", "Saraswat", 101 };

            // Invoke the method passing in myClassInstance and parameters array
            var fullname = (string)GetFullNameMethod.Invoke(myClassInstance, parameters);

            Console.WriteLine(fullname);
            Console.ReadKey();
        }
    }

    public class MyClass
    {

        public string GetFullName(string FirstName, string LastName, int id)
        {
            return FirstName + " " +LastName + " "+ id;
        }
    }
}
