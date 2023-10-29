using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0.0;
            int counter = 0;
            while (grade < 13)
            {
                double yearMark = double.Parse(Console.ReadLine());
                if (yearMark < 4.00)
                {
                    if (counter == 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    counter++;
                    continue;

                }
                sum += yearMark;
                grade++;
                

            }
            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):f2}");
            }
            

            
               
        }
    }
}
