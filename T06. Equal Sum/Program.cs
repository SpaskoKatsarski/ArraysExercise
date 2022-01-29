using System;
using System.Linq;

namespace T06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make the array
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int biggestNumber = int.MinValue;
            int indexOfBiggestNum = 0;

            // get the biggest number
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggestNumber)
                {
                    biggestNumber = arr[i];
                    indexOfBiggestNum = i;
                }
            }


            // get the values of the elements in its right and its left side
            int sumOfLeftSide = 0;
            int sumOfRightSide = 0;
            for (int i = 0; i < indexOfBiggestNum; i++)
            {
                sumOfLeftSide += arr[i];
            }

            for (int i = arr.Length - 1; i > indexOfBiggestNum; i--)
            {
                sumOfRightSide += arr[i];
            }

            // if the sum is equal print the index of the number
            if (sumOfLeftSide == sumOfRightSide)
            {
                Console.WriteLine(indexOfBiggestNum);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
