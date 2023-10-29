using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input!="end")
            {
                string [] command= input.Split();
                if (command[0]== "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passangers = int.Parse(command[0]);
                    FindWagon(wagons,capacity,passangers);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }

        private static void FindWagon(List<int> wagons, int capacity, int passangers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currWagon = wagons[i];
                if (currWagon+passangers<= capacity)
                {
                    wagons[i] += passangers;
                    break;
                }
                
            }
        }
    }
}
