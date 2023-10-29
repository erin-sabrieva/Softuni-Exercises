using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Видеокарта – 250 лв./ бр.
            //Процесор – 35 % от цената на закупените видеокарти/ бр.
            //Рам памет – 10 % от цената на закупените видеокарти/ бр.
            double budget = double.Parse(Console.ReadLine());
            int videoCart = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int ramPamet = int.Parse(Console.ReadLine());

            double videoCartPrice = videoCart * 250;
            double procesorPrice = procesor * videoCartPrice * 35 / 100.0;
            double ramPametPrice = ramPamet* videoCartPrice * 10 / 100.0;
            double sum = videoCartPrice + procesorPrice + ramPametPrice;
            if (videoCart > procesor)
            {
                sum = sum - (sum * 15 / 100.0);
            }
            double diference = budget - sum;
            if (diference >= 0)
            {
                Console.WriteLine($"You have {diference:f2} leva left!"); 
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(diference):f2} leva more!");
            }



        }
    }
}
