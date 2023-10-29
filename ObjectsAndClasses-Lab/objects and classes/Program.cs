using System;

namespace objects_and_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int newIndex = random.Next(0, words.Length);
                string currWord = words[i];
                words[i] = words[newIndex];
                words[newIndex] = currWord;
            
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
