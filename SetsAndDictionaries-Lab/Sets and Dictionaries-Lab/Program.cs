using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> time = new Dictionary<double, int>();
            foreach (var item in number)
            {
                if (!time.ContainsKey(item))
                {
                    time.Add(item,0);
                }
                time[item]++;
            }
            foreach (var item in time)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
