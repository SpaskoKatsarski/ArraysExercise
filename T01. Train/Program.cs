using System;
using System.Linq;

namespace T01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] people = new int[n];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(people.Sum());
        }
    }
}
