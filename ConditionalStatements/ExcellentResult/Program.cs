using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            bool isExcellent = mark >= 5.50;
            if (isExcellent)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
