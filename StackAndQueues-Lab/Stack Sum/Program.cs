using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            string input = Console.ReadLine().ToLower();
            while (input!="end")
            {
                string[] command = input.Split(" ");
                if (command[0]=="add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else
                {
                    if (int.Parse(command[1])>stack.Count)
                    {
                        input = Console.ReadLine().ToLower();
                        continue;
                    }
                    for (int i = 0; i < int.Parse(command[1]); i++)

                    {
                        stack.Pop();
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
