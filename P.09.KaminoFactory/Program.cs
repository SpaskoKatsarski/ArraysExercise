using System;
using System.Linq;

namespace P._09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int length = int.Parse(Console.ReadLine());

            //int longestSequence = 0;
            //int[] bestArr = new int[length];

            //int currentIndex = 0;
            //int lowestIndex = int.MaxValue;

            //string command = Console.ReadLine();
            //while (command != "Clone them!")
            //{
            //    int[] currentDnaArray = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //    int currentSequence = 1;

            //    for (int i = 0; i < currentDnaArray.Length - 1; i++)
            //    {
            //        if (currentDnaArray[i] == currentDnaArray[i + 1])
            //        {
            //            currentSequence++;
            //            currentIndex = i;
            //        }
            //    }

            //    if (currentSequence >= longestSequence && currentIndex <= lowestIndex)
            //    {
            //        longestSequence = currentSequence;

            //        for (int i = 0; i < length; i++)
            //        {
            //            bestArr[i] = currentDnaArray[i];
            //        }

            //        lowestIndex = currentIndex;

            //        if (currentIndex == lowestIndex)
            //        {
            //            if (currentDnaArray.Sum() > bestArr.Sum())
            //            {
            //                for (int i = 0; i < length; i++)
            //                {
            //                    bestArr[i] = currentDnaArray[i];
            //                }
            //            }
            //        }
            //    }

            //    command = Console.ReadLine();
            //}

            //Console.WriteLine($"Best DNA sample {lowestIndex + 1} with sum: {bestArr.Sum()}.");
            //Console.WriteLine(String.Join(" ", bestArr));

            
                Console.ReadLine();
                string[] bestDna = null;
                int bestLen = -1;
                int startIndex = -1;
                int bestDnaSum = 0;
                int bestSampleIndex = 0;

                int currentSampleIndex = 0;

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "Clone them!")
                    {
                        break;
                    }

                    string[] currentDna = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
                    int currentLen = 0;
                    int currentBestLen = 0;
                    int currentEndIndex = 0;

                    for (int a = 0; a < currentDna.Length; a++)
                    {
                        if (currentDna[a] == "1")
                        {
                            currentLen++;
                            if (currentLen > currentBestLen)
                            {
                                currentEndIndex = a;
                                currentBestLen = currentLen;
                            }
                        }
                        else
                        {
                            currentLen = 0;
                        }
                    }

                    int currentStartIndex = currentEndIndex - currentBestLen + 1;

                    bool isCurrentDnaBetter = false;
                    int currentDnaSum = currentDna.Select(int.Parse).Sum();

                    if (currentBestLen > bestLen)
                    {
                        isCurrentDnaBetter = true;
                    }
                    else if (currentBestLen == bestLen)
                    {
                        if (currentStartIndex < startIndex)
                        {
                            isCurrentDnaBetter = true;
                        }
                        else if (currentStartIndex == startIndex)
                        {
                            if (currentDnaSum > bestDnaSum)
                            {
                                isCurrentDnaBetter = true;
                            }
                        }
                    }

                    currentSampleIndex++;

                    if (isCurrentDnaBetter)
                    {
                        bestDna = currentDna;
                        bestLen = currentBestLen;
                        startIndex = currentStartIndex;
                        bestDnaSum = currentDnaSum;
                        bestSampleIndex = currentSampleIndex;
                    }
                }

                Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
                Console.WriteLine(string.Join(' ', bestDna));
            }
        }
    }
