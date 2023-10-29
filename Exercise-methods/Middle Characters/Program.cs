using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            First(words);

        } static void First(string words)
        {
            if (words.Length%2==0)
            {
                Console.Write(words[words.Length/2-1]);
                Console.WriteLine(words[words.Length/2]);
            }
            else
            {
                Console.WriteLine(words[words.Length/2]);
            }
        }
    }
}
