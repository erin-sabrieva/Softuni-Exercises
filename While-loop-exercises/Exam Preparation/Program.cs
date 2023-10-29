using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());//2
            string nameZadacha = Console.ReadLine();

            int counter = 0;
            int counter2 = 0;
            double sum = 0.0;
            string lastName = "";
            while (nameZadacha != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sum += grade;


                if (grade <= 4.00)
                {
                    counter++;
                    if (badGrade <= counter)
                    {
                        Console.WriteLine($"You need a break, {counter} poor grades.");
                        break;
                    }
                }
                counter2++;
                lastName = nameZadacha;
                
                nameZadacha = Console.ReadLine();
            }
            if (nameZadacha == "Enough")
            {
                nameZadacha = lastName;
                Console.WriteLine($"Average score: {(sum / counter2):f2}");
                Console.WriteLine($"Number of problems: {counter2}");
                Console.WriteLine($"Last problem: {lastName}");
            }
            
                


            
        }
    }
}
