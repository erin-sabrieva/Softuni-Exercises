using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < dimension[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < dimension[1]; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            first.IntersectWith(second);
            Console.WriteLine(string.Join(" ", first));
        }
    }
}
