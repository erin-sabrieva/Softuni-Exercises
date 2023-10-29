using System;

namespace conditionaltatmenetsAdvancedExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProject = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int kolumns = int.Parse(Console.ReadLine());
            double income = rows * kolumns;
            if (typeProject == "Premiere")
            {
                income = income * 12.00;
            }
            else if (typeProject == "Normal")
            {
                income = income * 7.50;
            }
            else 
            {
                income = income * 5.00;
            }

            Console.WriteLine("{0:f2} leva", income);


        }
    }
}
