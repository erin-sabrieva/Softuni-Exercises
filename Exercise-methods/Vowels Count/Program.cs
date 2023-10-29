using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            SearchForVowels(word);
        }

        static void SearchForVowels(string word)
        {
            int count = 0;
            foreach (char  vowel in word)
            {
                if ("aouie".Contains(vowel))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
