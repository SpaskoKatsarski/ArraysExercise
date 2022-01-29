using System;
using System.Linq;

namespace T07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int currentSequence = 1;
            int longestNumber = 0;
            
            int longestSequence = 0;

            // 2 1 1 2 3 3 2 2 2 1

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    longestNumber = arr[i];
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write($"{longestNumber} ");
            }
        }
    }
}
