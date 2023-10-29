using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] result = input.Where(f => f.Length % 2 == 0).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
