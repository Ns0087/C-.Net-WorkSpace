using System;
class Program
{
    static void Main(string[] args)
    {
        User<int, int> user1 = new User<int, int>();
        User<bool, string> user2 = new User<bool, string>();

        user1.RegistrationStatus = 1234;
        user2.RegistrationStatus = false;

        user1.Age = 24;
        user2.Age = "35-40";

        Console.WriteLine(user1.RegistrationStatus);
        Console.WriteLine(user2.RegistrationStatus);
        Console.WriteLine(user1.Age);
        Console.WriteLine(user2.Age);
        Console.ReadKey();

    }
}
