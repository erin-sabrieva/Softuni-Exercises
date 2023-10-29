using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto = 100*double.Parse(Console.ReadLine());
            int counter = 0;
            while (resto > 0)
            {
                if (resto >= 200)
                {
                    resto -= 200;
                    counter++;
                }
                else if (resto >=100)
                {
                    resto -= 100;
                    counter++;
                }
                else if (resto >=50)
                {
                    resto -= 50;
                    counter++;
                }
                else if (resto >= 20)
                {
                    resto -= 20;
                    counter++;
                }
                else if (resto >= 10)
                {
                    resto -= 10;
                    counter++;
                }
                else if (resto >= 5)
                {
                    resto -= 5;
                    counter++;
                }
                else if (resto >= 2)
                {
                    resto -= 2;
                    counter++;
                }
                else if (resto >= 1)
                {
                    resto -= 1;
                    counter++;
                }
                else
                {
                    resto = 0;
                }


            }
            Console.WriteLine(counter);
            
        }
    }
}
