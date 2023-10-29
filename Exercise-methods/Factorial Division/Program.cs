using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           double rezult1=  Factoriel1(num1);
            double result2 = Factoriel1(num2);
            Console.WriteLine($"{(rezult1 / result2):f2}");

        }
        static double Factoriel1(int number)
        {
            double result1 = 1;
            while (number!=1)
            {
                result1 *= number;
                number--;
            }
            return result1;
        }
        
    }
}
