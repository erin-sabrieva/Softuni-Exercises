using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Декорът за филма е на стойност 10 % от бюджета.
            //При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            double budjet = double.Parse(Console.ReadLine());//9587,88
            int statist = int.Parse(Console.ReadLine());//222
            double clothing = double.Parse(Console.ReadLine());//55,68
            double decor = budjet * 10 / 100.0;//958.788
            double clothingPrice = statist * clothing;//11124.864
            if (statist > 150)
            {
                clothingPrice = clothingPrice - (clothingPrice * 10 / 100.0);
            }
            double allPrice = decor + clothingPrice;//958.788 + 11124.864 = 12083.652
            if (allPrice > budjet)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budjet - allPrice):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budjet - allPrice):f2} leva left.");

            }



        }
    }
}
