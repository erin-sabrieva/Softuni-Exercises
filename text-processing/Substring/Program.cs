using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            while (input.Contains(word))
            {
                int startIndex = input.IndexOf(word);
                input=input.Remove(startIndex, word.Length);
            }
            Console.WriteLine(input);
        }
    }
}
