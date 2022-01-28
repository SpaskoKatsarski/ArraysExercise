using System;
using System.Linq;

namespace T04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startingArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] currentArray = new int[startingArr.Length];

            for (int i = 0; i < rotations; i++)
            {
                int counter = 0;

                foreach (var element in startingArr)
                {
                    currentArray[counter] = element;

                    counter++;

                    if (counter == startingArr.Length)
                    {
                        break;
                    }
                }

                int firstIndex = currentArray[0];

                for (int j = 0; j < startingArr.Length - 1; j++)
                {
                    startingArr[j] = currentArray[j + 1];
                }

                startingArr[startingArr.Length - 1] = firstIndex;
            }

            Console.WriteLine(String.Join(" ", startingArr));

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int rotations = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rotations; i++)
            //{
            //    int temp = arr[0];

            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //        arr[j] = arr[j + 1];
            //    }

            //    arr[arr.Length - 1] = temp;
            //}

            //Console.WriteLine(String.Join(" ", arr));
        }
    }
}
