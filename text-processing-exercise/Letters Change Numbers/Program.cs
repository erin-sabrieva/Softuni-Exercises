using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                double number =double.Parse(item.Substring(1,item.Length-2));
               
           
                double result = 0;
                if (firstLetter>=65 && firstLetter<=90)
                    {
                    int poitionFirt = firstLetter - 64;
                    result = number / poitionFirt;
                    }
                else
                {
                    int poitionFirt = firstLetter - 96;
                    result = number * poitionFirt;
                }
                if (lastLetter>=65 && lastLetter<=90)
                {
                    int poitionLast = lastLetter - 64;
                    sum += result -poitionLast ;
                }
                else
                {
                    int poitionLast = lastLetter - 96;
                    sum += result + poitionLast;
                }
                
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
