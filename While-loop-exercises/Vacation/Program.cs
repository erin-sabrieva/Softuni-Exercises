using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());//500
            double moneyNalichni = double.Parse(Console.ReadLine());//400
            int counter = 0;
            string input = "";
            double money = 0;
            int spendCount = 0;
            while (moneyNalichni < needMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                if (input == "save")
                {
                    moneyNalichni += money;
                    spendCount = 0;
                    counter++;
                }
                else if (input == "spend")
                {
                    moneyNalichni -= money;
                    counter++;
                    spendCount++;
                    if (moneyNalichni < 0 )
                    {
                        moneyNalichni = 0;
                    }
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{counter}");
                        break;

                    }
                }
            }
            
            if (moneyNalichni >= needMoney)
            {
                Console.WriteLine($"You saved the money for {counter} days.");
            }
        }
    }
}
