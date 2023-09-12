using System;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            Console.WriteLine("Enter a value");
            value = double.Parse(Console.ReadLine());
           
            if ((value%2)==0)
            {
                Console.WriteLine("The value is even number ");
            }

            else
            {
                Console.WriteLine("The value is odd number");
            }
        }
    }
}
