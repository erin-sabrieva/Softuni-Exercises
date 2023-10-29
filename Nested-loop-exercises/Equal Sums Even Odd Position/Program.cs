using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sum1;
            int sum2;
            for (int i = firstNum; i <=secondNum; i++)
            {
                sum1 = 0;
                sum2 = 0;
                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length ; j++)
                {
                    if (j % 2 == 0)
                    {
                        sum1 += currentNum[j];
                    }
                    else
                    {
                        sum2 += currentNum[j];
                    }
                    
                    
                }
                if (sum1 == sum2)
                {
                    Console.Write(currentNum + " ");
                }

            }
        }
    }
}
