using System;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string result = "";
            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);
        }
    }
}
