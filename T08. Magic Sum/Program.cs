using System;
using System.Linq;

namespace T08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            int[] usedPairs = new int[arr.Length];
            int counter = 0;

            int commonDoubles = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        commonDoubles++;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        if ((usedPairs.Contains(arr[i]) || usedPairs.Contains(arr[j]) || commonDoubles == 1))
                        { 
                            continue;
                        }

                        Console.WriteLine($"{arr[i]} {arr[j]}");

                        usedPairs[counter] = arr[i];
                        usedPairs[counter + 1] = arr[j];
                    }
                }
                counter++;
            }
        }
    }
}
