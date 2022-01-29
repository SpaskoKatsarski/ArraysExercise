using System;
using System.Linq;

namespace T08._Magic_Sum_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());
            // 1 7 6 2 19 23
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
            }
        }
    }
}
