using System;
using System.Linq;

namespace T05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;
                int currentNumber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNumber <= arr[j])
                    {
                        isTopInteger = false;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
