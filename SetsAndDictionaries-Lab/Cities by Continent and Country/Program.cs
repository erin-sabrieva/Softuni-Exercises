using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dictionaryNeted = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continet = input[0];
                string country = input[1];
                string city = input[2];
                if (!dictionaryNeted.ContainsKey(continet))
                {
                    dictionaryNeted.Add(continet, new Dictionary<string, List<string>>());
                }
                if (!dictionaryNeted[continet].ContainsKey(country))
                {
                    dictionaryNeted[continet].Add(country,new List<string>());
                }
                dictionaryNeted[continet][country].Add(city);
            }
            foreach (var item in dictionaryNeted)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var count in item.Value)
                {
                    Console.WriteLine($"{count.Key} -> {string.Join(", ",count.Value)}");
                    
                }
            }
        }
    }
}
