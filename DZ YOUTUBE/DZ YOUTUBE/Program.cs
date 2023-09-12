using System;

namespace DZ_YOUTUBE
{
    class Program
    {
        static void Main(string[] args)
        {

            /*double value1;
            double value2;
            Console.WriteLine("Enter value 1");
            value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2");
            value2 = double.Parse(Console.ReadLine());
            double result = (value1 + value2) / 2;
            Console.WriteLine("Result: " + result);*/


            /*double value1;
            double value2;
            double value3;
            Console.WriteLine("Enter value 1");
            value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2");
            value2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 3");
            value3 = double.Parse(Console.ReadLine());
            double Sum = value1 + value2 + value3;
            double Mult= value1 * value2 * value3;
            Console.WriteLine("Sum result: " + Sum);
            Console.WriteLine("Mult result: " + Mult);*/

            double doll=40;
            double evro=30;
            double hrn;
            Console.WriteLine("Enter sum in hrn");
            hrn = double.Parse(Console.ReadLine());
            Console.WriteLine("doll= " + hrn/doll);
            Console.WriteLine("evro= " + hrn/evro);
            
        }
    }
}
