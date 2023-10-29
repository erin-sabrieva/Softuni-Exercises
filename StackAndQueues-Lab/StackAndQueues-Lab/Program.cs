using System;
using System.Collections.Generic;

namespace StackAndQueues_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                stack.Push(symbol);
            }
            foreach (char item in stack)
            {
                Console.Write
                    (item);
            }
        }
    }
}
