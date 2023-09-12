using System;

namespace Practice3263
{
    class Program

    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[8, 8];
            Random random = new Random();
           
            int MaxElem = int.MinValue;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(-50, 50);
                }
            }
            int count = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)

                    if (myArray[i, j] % 2 != 0 && myArray[i, j] > 0)
                    {
                        Console.Write(myArray[i, j] + "\t");
                        count++;
                        if (count % 5 ==0)
                        {
                            Console.WriteLine();
                        }
                            if (myArray[i, j] > MaxElem)
                            {
                                MaxElem = myArray[i, j];
                            }
                        }
                    }
            {
                Console.WriteLine("\nNumber of odd positive elements {0}", + count);
                Console.WriteLine("The maximum value of received elements {0}", MaxElem);
            }
        }
    }
}



