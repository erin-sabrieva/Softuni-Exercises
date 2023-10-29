using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typePomeshtenie = Console.ReadLine();
            string ocenka = Console.ReadLine();
             double price = 0.0;
            double allPrice = 0.0;
            switch (typePomeshtenie)
            {
                case "room for one person":
                    price = 18.00;
                    allPrice = (days - 1) * price;
                    break;
                case "apartment":
                    price = 25.00;
                    allPrice = (days - 1) * price;
                    if (days > 15)
                    {
                        allPrice = allPrice - (allPrice * 50 / 100.0);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        allPrice = allPrice - (allPrice * 35 / 100.0);
                    }
                    else if (days < 10)
                    {
                        allPrice = allPrice - (allPrice * 30 / 100.0);
                    }
                    break;
                case "president apartment":
                    price = 35.00;
                    allPrice = (days - 1) * price;
                    if (days > 15)
                    {
                        allPrice = allPrice - (allPrice * 20 / 100.0);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        allPrice = allPrice - (allPrice * 15 / 100.0);
                    }
                    else if (days < 10)
                    {
                        allPrice = allPrice - (allPrice * 10 / 100.0);
                    }

                    break;
            }
            if (ocenka == "positive")
            {
                allPrice = allPrice + (allPrice * 25 / 100.0);
            }
            else
            {
                allPrice = allPrice - (allPrice * 10 / 100.0);
            }
            Console.WriteLine($"{allPrice:f2}");

        }
    }
}
