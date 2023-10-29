using System;

namespace Creating_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, min, max, i, k, p, t, x, y, z;
                Console.WriteLine("Въведете граници на интервала за проверка (естествени числа):");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                min = Math.Min(a, b);
                max = Math.Max(a, b);
                for (i = min; i <= max; i++)
                {
                    bool prime = true;
                    if (i % 2 == 0)
                    {
                        x = i - 3;
                        for (k = 2; k < x; k++)
                        {
                            if (x % k == 0)
                            {
                                prime = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0} = {1} + 3", i, x);
                                break;
                                
                            }

                        }

                        continue;
                        y = i / 2;
                        for (p = 2; p < y; p++)
                        {
                            if (y % p == 0)
                            {
                                prime = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0} = {1} + {1}", i, y);
                             
                            }
                        }
                    }
                    if (i % 2 == 1)
                    {
                        z = i - 2;
                        for (t = 2; t < z; t++)
                        {
                            if (z % t == 0)
                            {
                                prime = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0} = {1} + 2", i, z);
                                
                            }
                            break;
                        }

                    }
                    if (prime == false)
                    {
                        Console.WriteLine("Числото {0} не може да бъде представено като сбор от две прости числа, следователно хипотезата на Ойлер е невярна.", i);
                        Console.ReadKey();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Невалидни данни!");
                return;
            }
        }
    }
}
