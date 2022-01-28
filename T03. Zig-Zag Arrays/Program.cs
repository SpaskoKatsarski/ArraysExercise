using System;
using System.Linq;

namespace T03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = inputArray[0];
                    secondArr[i] = inputArray[1];
                }
                else
                {
                    firstArr[i] = inputArray[1];
                    secondArr[i] = inputArray[0];
                }
            }

            Console.WriteLine(String.Join(" ", firstArr));
            Console.WriteLine(String.Join(" ", secondArr));
        }
    }
}
