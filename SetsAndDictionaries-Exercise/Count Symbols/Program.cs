using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (!dictionary.ContainsKey(ch))
                {
                    dictionary.Add(ch, 0);
                }
                dictionary[ch]++;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{ item.Key}: {item.Value} time/s");
            }
        }
    }
}
