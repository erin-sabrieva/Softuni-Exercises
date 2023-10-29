using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            TopNumber(end);
            }

         static void TopNumber(int end)
        {
            
            for (int i = 17; i <=end; i++)
            {
                bool IsOdd = false;
                int sum = 0;
                int copy = i;
                while (copy!=0)
                {
                    sum += copy % 10;
                    if ((copy % 10) %2!=0)
                    {
                        IsOdd = true;
                    }
                    copy/= 10;
                }
                if (IsOdd && sum%8==0)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
    }

