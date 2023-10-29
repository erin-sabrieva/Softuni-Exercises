using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Ако числото е до 100 включително, бонус точките са 5.
            //Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            //Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
            //•	Допълнителни бонус точки (начисляват се отделно от предходните):
            // За четно число  +1 т.
            // За число, което завършва на 5  +2 т.
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 10 / 100.0;
            }
            else
            {
                bonus = number * 20 / 100.0;
            }
             if (number % 2 == 0.0)
            {
                bonus = bonus + 1;
            }
             if (number % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);


        }
    }
}
