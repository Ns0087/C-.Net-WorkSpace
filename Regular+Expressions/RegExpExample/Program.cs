using System;
using System.Text.RegularExpressions;

namespace RegExpExample
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex("^[A-Za-z ]*$");
            Console.WriteLine("Enter a name: ");
            string inputValue;
            bool result = false;

            do
            {
                inputValue = Console.ReadLine();
                result = regex.IsMatch(inputValue);
                Console.WriteLine(result);
                if (result == false)
                    Console.WriteLine("Please Enter a Valid Name!!!");

            } while (result != true);
            //if (result == true)
            //{
            //    Console.WriteLine("Valid name");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid name");
            //}
            Console.ReadKey();
        }
    }
}
