using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            for (int k = 1; k <=9; k++)
            {
                for (int l = 1; l <= 9; l++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (chislo%i == 0 && chislo %j==0 && chislo % l == 0 && chislo % k ==0)
                            {
                                Console.Write($"{k}{l}{j}{i} ");
                            }
                        }
                    }
                }
            }
           
        }
    }
}
