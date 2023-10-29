using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length==1)
                {
                    Console.WriteLine();
                    return;
                }
            }
        }
    }
}
