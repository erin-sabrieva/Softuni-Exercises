using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> dictionary = new Dictionary<string, Dictionary<string,int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
                if (!dictionary.ContainsKey(input[0]))
                {
                    dictionary[input[0]]=new Dictionary<string,int>();
                }
                for (int j = 1; j < input.Length; j++)
                {
                    if (!dictionary[input[0]].ContainsKey(input[j]))
                    {
                        dictionary[input[0]].Add(input[j],0);
                    }
                    dictionary[input[0]][input[j]]++;
                }
            }
            string[] findParams = Console.ReadLine().Split();
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var it in item.Value)
                {
                    if (item.Key==findParams[0]&& it.Key==findParams[1])
                    {
                        Console.WriteLine($"* {it.Key} - {it.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {it.Key} - {it.Value}");
                    }
                }
            }
            
        }
    }
}
