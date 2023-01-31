using System;
using System.Text.RegularExpressions;

namespace RegExpExample
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,32}$");
            Console.WriteLine("Enter a password: ");
            string inputValue;
            bool result = false;

            do
            {
                inputValue = Console.ReadLine();
                result = regex.IsMatch(inputValue);
                Console.WriteLine(result);
                if (result == false)
                    Console.WriteLine("Password must contain Minimum 8 to 32 characters, at least one uppercase letter, one lowercase letter, one number and one special character!!!");

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
