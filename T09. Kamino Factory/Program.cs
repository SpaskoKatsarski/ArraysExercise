using System;
using System.Linq;

namespace T09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int longestSubsequence = 0;
            int currentSubsequence = 1;
            int bestDnaSampleNumber = 0;

            int currentNumberOfDnaSample = 0;

            int[] dnaArray = new int[length];

            int[] bestDna = new int[length];

            int currentSum = 0;
            int bestSum = 0;

            string input;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                // 1!1!0!0
                // 1!1!0!1
                dnaArray = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                currentNumberOfDnaSample++;

                for (int i = 0; i < length - 1; i++)
                {
                    if (dnaArray[i] == dnaArray[i + 1] && dnaArray[i] == 1)
                    {
                        currentSubsequence++;
                    }
                }

                if (currentSubsequence > longestSubsequence)
                {
                    longestSubsequence = currentSubsequence;
                    bestDnaSampleNumber = currentNumberOfDnaSample;
                    
                    currentSum = dnaArray.Sum();
                    bestSum = bestDna.Sum();
                }
                if (currentSubsequence == longestSubsequence && currentSum > bestSum)
                {
                    bestSum = currentSum;
                }

                for (int j = 0; j < dnaArray.Length; j++)
                {
                    bestDna[j] = dnaArray[j];
                }
            }

            Console.WriteLine($"Best DNA sample {bestDnaSampleNumber} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestDna));
        }
    }
}
