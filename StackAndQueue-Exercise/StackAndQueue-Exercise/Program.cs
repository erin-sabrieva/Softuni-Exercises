using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueue_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Stack<int> number = new Stack<int>(input2);
            int n =input[0];
            int s = input[1];
            int x =input[2];
            for (int i = 0; i < s; i++)
            {
                number.Pop();
            }
            if (number.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (number.Count==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(number.Min());
            }
            
        }
    }
}
