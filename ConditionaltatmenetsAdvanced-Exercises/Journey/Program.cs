using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0.0;
            string place = "";
            string placeSleep = "";
            if (budjet <= 100)
            {
                place = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        price = budjet * 30 / 100.0;
                        break;
                    case "winter":
                        price = budjet * 70 / 100.0;
                        break;
                }
                if (season == "summer")
                {
                    placeSleep = "Camp";
                }
                else
                {
                    placeSleep = "Hotel";
                }
            }
            else if (budjet <= 1000)
            {
                place = "Balkans";
                switch (season)
                {
                    case "summer":
                        price = budjet * 40 / 100.0;
                        break;
                    case "winter":
                        price = budjet * 80 / 100.0;
                        break;
                }
                if (season == "summer")
                {
                    placeSleep = "Camp";
                }
                else
                {
                    placeSleep = "Hotel";
                }
            }
            else if (budjet > 1000)
            {
                place = "Europe";
                switch (season)
                {
                    case "summer":
                    case "winter":
                        price = budjet * 90 / 100.0;
                        break;
                }
                if (season == "summer" || season == "winter")
                {
                    placeSleep = "Hotel";
                }
                
            }
           
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{placeSleep} - {price:f2}");
        }
    }
}
