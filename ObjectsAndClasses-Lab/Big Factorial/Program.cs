using System;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger num = 1;
            
            for (int i = 2; i <= n; i++)
            {
                num *= i;      
            }
            Console.WriteLine(num);
        }
    }
    
}
