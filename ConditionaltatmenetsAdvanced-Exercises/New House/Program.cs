using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerName = Console.ReadLine();
            int broiFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());
            double price = 0.0;

            //Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            //"Dahlias", "Tulips", "Narcissus", "Gladiolus"

            if (flowerName == "Roses" )
            {
                price = broiFlowers * 5.00;
                if (broiFlowers > 80)
                {
                    price = price - (price * 10 / 100.0);
                }
                
            }
            else if (flowerName == "Dahlias")
            {
                price = broiFlowers * 3.80;
                if (broiFlowers > 90)
                {
                    price = price - (price * 15 / 100.0);
                }
            }
            else if (flowerName == "Tulips")
            {
                price = broiFlowers * 2.80;
                if (broiFlowers>80)
                {
                    price = price - (price * 15 / 100.0);
                }
            }
            else if (flowerName == "Narcissus")
            {
                price = broiFlowers * 3.00;
                if (broiFlowers< 120)
                {
                    price = price + (price * 15 / 100.0);
                }
            }
            else if (flowerName == "Gladiolus")
            {
                price = broiFlowers * 2.50;
                if (broiFlowers < 80)
                {
                    price = price + (price * 20 / 100.0);
                }
            }
            if (budjet >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {broiFlowers} {flowerName} and {(budjet - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(price - budjet):f2} leva more.");
            }



        }
    }
}
