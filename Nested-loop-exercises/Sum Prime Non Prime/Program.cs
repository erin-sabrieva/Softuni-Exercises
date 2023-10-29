using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int prostiSum = 0;
            int neprostiSum = 0;
            while (input != "stop")
            {
                int chislo = int.Parse(input);
                bool isPrime = true;
                if (chislo < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                
                else
                {
                    for (int i = 2; i < chislo -1; i++)
                    {
                        if (chislo % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        
                    }
                    if (isPrime)
                    {
                        prostiSum += chislo;
                    }
                    else
                    {
                        neprostiSum += chislo;
                    }
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {prostiSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {neprostiSum}");
        }
    }
}
