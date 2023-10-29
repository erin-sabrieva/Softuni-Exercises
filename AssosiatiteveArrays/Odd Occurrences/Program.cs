using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 0);
                }
                wordsCount[word]++;
            }
            string[] result = wordsCount.Where(x => x.Value % 2 != 0).Select(g => g.Key).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
