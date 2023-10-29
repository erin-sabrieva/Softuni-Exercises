using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int globa = 0;
            for (int i = 1; i <= n; i++)
            {
                string syte = Console.ReadLine();
                switch (syte)
                {
                    case "Facebook":
                        globa += 150;
                        break;
                    case "Instagram":
                        globa += 100;
                        break;
                    case "Reddit":
                        globa += 50;
                        break;
                }
                if (globa >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (globa < salary)
            {
                Console.WriteLine($"{salary - globa}");
            }
        }
    }
}
