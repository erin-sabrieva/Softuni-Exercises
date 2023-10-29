using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiGrup = int.Parse(Console.ReadLine());
            int sum = 0;
            double vruhMusala = 0.0;
            double vruhMonblan = 0.0;
            double vruhKilimandjaro = 0.0;
            double vruhK2 = 0.0;
            double vruhEverest = 0.0;
            for (int i = 1; i <= broiGrup; i++)
            {
                int broiHora = int.Parse(Console.ReadLine());
                sum += broiHora;
                if (broiHora <= 5)
                {
                    vruhMusala += broiHora;
                }
                else if (broiHora >= 6 && broiHora <= 12)
                {
                    vruhMonblan += broiHora;
                }
                else if (broiHora >=13 && broiHora <=25)
                {
                    vruhKilimandjaro += broiHora;
                }
                else if (broiHora >= 26 && broiHora <= 40)
                {
                    vruhK2 += broiHora;
                }
                else if (broiHora >= 41)
                {
                    vruhEverest += broiHora;
                }
            }
            vruhMusala = vruhMusala / sum * 100.0;
            vruhMonblan = vruhMonblan / sum * 100.0;
            vruhKilimandjaro = vruhKilimandjaro / sum * 100.0;
            vruhK2 = vruhK2 / sum * 100.0;
            vruhEverest = vruhEverest / sum * 100.0;
            Console.WriteLine($"{vruhMusala:f2}%");
            Console.WriteLine($"{vruhMonblan:f2}%");
            Console.WriteLine($"{vruhKilimandjaro:f2}%");
            Console.WriteLine($"{vruhK2:f2}%");
            Console.WriteLine($"{vruhEverest:f2}%");


        }
    }
}
