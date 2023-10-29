using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            Elements(char1,char2);
        }
        static void Elements(int char1, int char2)
        {
            int start = Math.Min(char1, char2);
            int end = Math.Max(char1, char2);
            for (int i = start+1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
