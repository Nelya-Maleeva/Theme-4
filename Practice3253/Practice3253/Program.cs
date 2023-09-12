using System;

namespace Practice3253
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This calculator can perform such actions: \n 1 - addition \n 2 - subtraction " +
                "\n 3 - multiplication \n 4 - division \n 5 - exit from the calculator \n \nChoose the options:");
            double value1, value2;
            string choice;
            choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choice the first value");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Choice the second value");
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The result is: {value1 + value2}");
                    break;
                case "2":
                    Console.WriteLine("Choice the first value");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Choice the second value");
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The result is: {value1 - value2}");
                    break;
                case "3":
                    Console.WriteLine("Choice the first value");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Choice the second value");
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The result is: {value1 * value2}");
                    break;
                case "4":
                    Console.WriteLine("Choice the first value");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Choice the second value");
                    value2 = double.Parse(Console.ReadLine());
                    if (value2 == 0)
                    {
                        Console.WriteLine("Error! Can't divide by zero");
                    }
                    else
                    {
                        Console.WriteLine($"The result is: {value1 / value2}");
                    }
               break;
                case "5":
                        break;
                default:
                    Console.WriteLine("Error, action can't be done!");
                    break;
            }
        }
    }
}