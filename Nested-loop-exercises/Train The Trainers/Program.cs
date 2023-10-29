using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double sum = 0;
            double sum2 = 0;
            int marks = 0;
            while (presentation != "Finish")
            {
                sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    sum += mark;
                    

                }
                sum2 += sum;
                marks += n;
                Console.WriteLine($"{presentation} - {(sum/n):f2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(sum2/marks):f2}.");
        }
    }
}
