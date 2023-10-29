using System;

namespace text_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input!="end")
            {
                string result = "";
                for (int i = input.Length-1; i >=0; i--)
                {
                    result += input[i];
                }
                Console.WriteLine($"{input} = {result}");
                input = Console.ReadLine();
            }
        }
    }
}
