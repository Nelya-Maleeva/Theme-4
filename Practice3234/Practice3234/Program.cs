using System;

namespace Practice3234
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            int length = name.Length;
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("What is your email?");
            string email = Console.ReadLine();
            Console.WriteLine("What is your password?");
            Console.Write("****\r\r\r\r");
            string password = Console.ReadLine();
            int password1 = Convert.ToInt32(password);
            Console.Clear();
            Console.Write("User information:");
            Console.Write("\n \t Name: " + name);
            Console.Write("\n \t Age: " + age);
            Console.Write("\n \t Email: " + email);
            Console.Write("\n \t Password: " + password);
            Console.Write("\n Name length is " + length);
        }
    }
}