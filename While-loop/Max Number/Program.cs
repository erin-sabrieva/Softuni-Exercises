using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//10
            int maxNumber = int.MinValue;
            while (input != "Stop")
            {
                int number = int.Parse(input);//10-10
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
