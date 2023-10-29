using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var item in words)
            {
                string replace = new string('*', item.Length);
                text = text.Replace(item, replace);
            }
            Console.WriteLine(text);
        }
    }
}
