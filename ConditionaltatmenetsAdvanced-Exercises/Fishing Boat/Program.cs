using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int broiRibari = int.Parse(Console.ReadLine());
            double priceOfNaem = 0.0;
//•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
//•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
//•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.

            switch (season)
            {
                case "Spring":
                    priceOfNaem = 3000;
                    if (broiRibari <= 6)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 10 / 100.0);
                        
                    }
                    else if (broiRibari > 7 && broiRibari <= 11)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 15 / 100.0);
                    }
                    else if (broiRibari > 12)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 25 / 100.0);
                    }
                    break;
                case "Summer":
                case "Autumn":
                    priceOfNaem = 4200;
                    if (broiRibari <= 6)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 10 / 100.0);
                    }
                    else if (broiRibari > 7 && broiRibari <= 11)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 15 / 100.0);
                    }
                    else if (broiRibari > 12)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 25 / 100.0);
                    }
                    break;
                case "Winter":
                    priceOfNaem = 2600;
                    if (broiRibari <= 6)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 10 / 100.0);
                    }
                    else if (broiRibari > 7 && broiRibari <= 11)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 15 / 100.0);
                    }
                    else if (broiRibari > 12)
                    {
                        priceOfNaem = priceOfNaem - (priceOfNaem * 25 / 100.0);
                    }
                    break;
            }
            if (season != "Autumn")
            {
                if (broiRibari % 2 ==0)
                {
                    priceOfNaem = priceOfNaem - (priceOfNaem * 5 / 100.0);
                }
                
            }
            if (budjet >= priceOfNaem)
            {
                Console.WriteLine($"Yes! You have {(budjet - priceOfNaem):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(priceOfNaem - budjet):f2} leva.");
            }

        }
    }
}
