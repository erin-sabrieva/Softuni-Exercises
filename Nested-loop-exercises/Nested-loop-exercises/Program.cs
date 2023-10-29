using System;

namespace Nested_loop_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNum+" ");
                    currentNum++;
                    if (currentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNum > n)
                {
                    break;
                }
                

            }
        }
    }
}
