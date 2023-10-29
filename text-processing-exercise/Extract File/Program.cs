using System;
using System.Text;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Split("\");
            Console.WriteLine($"File name: {input[3]}");
            Console.WriteLine($"File extension: {input[4]}");
           


        }
    }
}
