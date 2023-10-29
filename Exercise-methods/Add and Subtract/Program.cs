using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = FirstCalculation(num1,num2);
            SecondCalculations(result, num3);
        }
        static int FirstCalculation(int num1, int num2)
        {
           
            return num1 +num2;
        }
        static void SecondCalculations(int result, int num3) => Console.WriteLine(result - num3);
        
    }
}
