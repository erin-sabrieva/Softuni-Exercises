using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пъзел - 2.60 лв.
            //Говореща кукла -3 лв.
            //Плюшено мече -4.10 лв.
            //Миньон - 8.20 лв.
            //Камионче - 2 лв.
            double tripPrice = double.Parse(Console.ReadLine());
            int pusel = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minyon = int.Parse(Console.ReadLine());
            int car = int.Parse(Console.ReadLine());
            int allToys = pusel + doll + bear + minyon + car;
            double puselPrice = pusel * 2.60;
            double dollPrice = doll * 3.0;
            double bearPrice = bear * 4.10;
            double minyonPrice = minyon * 8.20;
            double carPrice = car * 2.0;
            
            double totalPrice = puselPrice + dollPrice + bearPrice + minyonPrice + carPrice;
            
            if (allToys >= 50)
            {  
                totalPrice = totalPrice - (totalPrice * 25 / 100.0);
            }
            
           totalPrice = totalPrice - (totalPrice * 10 / 100.0);
            

            if (totalPrice >= tripPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPrice:f2} lv needed.");
            }







        }
    }
}
