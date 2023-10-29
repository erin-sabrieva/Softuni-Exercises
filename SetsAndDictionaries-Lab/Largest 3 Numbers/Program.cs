using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            number = number.OrderByDescending(c=>c).ToList();
            int count = number.Count;
            if (count>3)
            {
                count = 3;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{number[i]} ");
            }
        }
    }
}
