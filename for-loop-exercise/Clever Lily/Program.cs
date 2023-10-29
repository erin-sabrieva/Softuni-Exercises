using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double spesteniPari = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                   spesteniPari += i * 5 - 1;
                }
                else
                {
                    spesteniPari += toyPrice;
                }
            }
            if (spesteniPari >= machine)
            {
                Console.WriteLine($"Yes! {(spesteniPari - machine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(machine - spesteniPari):f2}");
            }

        }
    }
}
