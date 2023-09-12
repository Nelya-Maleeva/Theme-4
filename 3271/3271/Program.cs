using System;
using System.Linq;

namespace _3271
{
    class Program
    {
        static void ArrayInput(int[] UserArray)
        {
            for (int i = 0; i < UserArray.Length; i++)
            {
                Console.Write($"Enter {i + 1} element: ");
                UserArray[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void DisplayArray(int[] UserArray)
        {
            for (int i = 0; i < UserArray.Length; i++)
            {
                Console.Write(UserArray[i] + "\t");
            }
        }
        static void SortArray(int[] UserArray)
        {
            Array.Sort(UserArray);
            Array.Reverse(UserArray);
            for (int i = 0; i < UserArray.Length; i++)
            {
                Console.Write(UserArray[i] + "\t");
            }
        }
        static bool EqualArray(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)

            {
                return false;
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)

                {
                    if (array1[i] != array2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
            {
                int[] array1 = new int[5];
                int[] array2 = new int[5];
                Console.WriteLine("First array");
                ArrayInput(array1);
                Console.WriteLine("Second array");
                ArrayInput(array2);
                Console.WriteLine("\nFirst array: ");
                DisplayArray(array1);
                Console.WriteLine("\nSecond array: ");
                DisplayArray(array2);
                Console.WriteLine("\nSort first array: ");
                SortArray(array1);
                Console.WriteLine("\nSort second array: ");
                SortArray(array2);
                bool equivalence = EqualArray(array1, array2);
                { 
                    if (equivalence)
                    {
                        Console.WriteLine("\nThe arrays are equivalent");
                    }
                    else
                    {
                        Console.WriteLine("\nThe arrays are not equivalent");
                    }
                }
            }
        }
    }