using System;
using System.Collections.Generic;
using System.Linq;

namespace assosiatiteveArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> occurences = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var num in numbers)
            {
                if (occurences.ContainsKey(num))
                {
                    occurences[num] += 1;
                    
                }
                else
                {
                    occurences.Add(num, 1);
                }
            }
            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
