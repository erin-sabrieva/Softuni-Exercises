﻿using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);
            }
            foreach (var item in synonyms)
            {
                
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
           
        }
    }
}