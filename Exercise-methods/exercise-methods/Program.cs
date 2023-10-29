using System;

namespace exercise_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallerNum(num1, num2, num3)); 
        }

      static int SmallerNum(int num1, int num2, int num3)
        {
            return Math.Min(num1,Math.Min(num2,num3)); 
        }
    
    }
}
