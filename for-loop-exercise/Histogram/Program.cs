﻿using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 = p1 + 1;
                }
                else if ( num < 400)
                {
                    p2 = p2 + 1;
                }
                else if (num < 600)
                {
                    p3 = p3 + 1;
                }
                else if (num < 800)
                {
                    p4 = p4 + 1;
                }
                else if (num >= 800)
                {
                    p5 = p5 + 1;
                }
            }
            p1 = p1 / n * 100.0;
            p2 = p2 / n * 100.0;
            p3 = p3 / n * 100.0;
            p4 = p4 / n * 100.0;
            p5 = p5 / n * 100.0;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
