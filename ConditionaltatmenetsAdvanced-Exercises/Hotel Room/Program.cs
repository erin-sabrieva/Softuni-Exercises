using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int broiDays = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double apartamentPrice = 0.0;
            
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.00;
                     if (broiDays > 14)
                    {
                        studioPrice = studioPrice - (studioPrice * 30 / 100.0);
                    }
                     else if (broiDays > 7)
                    {
                        studioPrice = studioPrice - (studioPrice * 5 / 100.0);
                    }
                    else if (broiDays > 14)
                    {
                        studioPrice = studioPrice - (studioPrice * 30 / 100.0);
                    }
                    apartamentPrice = 65.00;
                    if (broiDays > 14)
                    {
                        apartamentPrice = apartamentPrice - (apartamentPrice * 10 / 100.0);
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    if (broiDays > 14)
                    {
                        studioPrice = studioPrice - (studioPrice * 20 / 100.0);
                    }
                    apartamentPrice = 68.70;
                    if (broiDays > 14)
                    {
                        apartamentPrice = apartamentPrice - (apartamentPrice * 10 / 100.0);
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00;
                    apartamentPrice = 77.00;
                    if (broiDays > 14)
                    {
                        apartamentPrice = apartamentPrice - (apartamentPrice * 10 / 100.0);
                    }
                    break;
            }
            double allPriceApartament = broiDays * apartamentPrice;
            double allPriceStudio = broiDays * studioPrice;
            Console.WriteLine($"Apartment: {allPriceApartament:f2} lv.");
            Console.WriteLine($"Studio: {allPriceStudio:f2} lv.");


        }
    }
}
