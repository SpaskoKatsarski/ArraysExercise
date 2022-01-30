using System;
using System.Linq;

namespace T10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            // 0 1
            int[] initialIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            // Length - 3
            int[] filledArray = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] < fieldSize)
                {
                    filledArray[initialIndexes[i]] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                int currentIndex = 0;

                string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int ladybugIndex = int.Parse(commandArr[0]);
                string direction = commandArr[1];
                int flyLength = int.Parse(commandArr[2]);

                if (flyLength < 0 && direction == "left")
                {
                    direction = "right";
                    flyLength = Math.Abs(flyLength);
                }

                if (ladybugIndex < 0 || ladybugIndex >= filledArray.Length)
                {
                    continue;
                }

                if (filledArray[ladybugIndex] == 1)
                {
                    filledArray[ladybugIndex] = 0;
                }
                else
                {
                    continue;
                }

                if (direction == "right")
                {
                    if (ladybugIndex + flyLength < 0 || ladybugIndex + flyLength >= fieldSize)
                    {
                        filledArray[ladybugIndex] = 0;
                        continue;
                    }
                    else
                    {
                        currentIndex = ladybugIndex + flyLength;

                        if (filledArray[currentIndex] == 1)
                        {
                            currentIndex += flyLength;
                        }
                    }
                }
                else
                {
                    if (ladybugIndex - flyLength < 0 || ladybugIndex - flyLength >= fieldSize)
                    {
                        filledArray[ladybugIndex] = 0;
                        continue;
                    }
                    else
                    {
                        currentIndex = ladybugIndex - flyLength;

                        if (filledArray[currentIndex] == 1)
                        {
                            currentIndex -= flyLength;
                        }
                    }
                }

                if (currentIndex < 0 || currentIndex >= filledArray.Length)
                {
                    continue;
                }

                filledArray[currentIndex] = 1;
            }

            Console.WriteLine(string.Join(" ", filledArray));
        }
    }
}
