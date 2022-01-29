using System;
using System.Linq;

namespace T06.EqualSumRetake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int sumOne = 0;
                int sumTwo = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    sumOne += arr[j];
                }

                for (int j = i; j >= 0; j--)
                {
                    sumTwo += arr[j];
                }

                if (sumOne == sumTwo)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
