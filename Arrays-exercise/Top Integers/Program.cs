using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int bestNum = numbers[i];
                for (int j = i; j < numbers.Length-1; j++)
                {
                   
                    if (bestNum <= numbers[j + 1])
                    {
                        break;
                    }
                    else
                    {
                        if (j==numbers.Length-2)
                        {
                            Console.Write($"{bestNum} ");
                        }
                        
                    }
                }
               
            }
           
        }
    }
}
