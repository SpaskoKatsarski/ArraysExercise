using System;

namespace T02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            foreach (var itemOne in secondArr)
            {
                foreach (var itemTwo in firstArr)
                {
                    if (itemOne == itemTwo)
                    {
                        Console.Write(itemOne + " ");
                    }
                }
            }
        }
    }
}
