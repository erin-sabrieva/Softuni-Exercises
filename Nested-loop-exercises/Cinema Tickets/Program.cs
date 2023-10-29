﻿using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int totalStudentsTickets = 0;
            int totalStandTickets = 0;
            int totalKidTickets = 0;
            int totalTickets = totalStudentsTickets + totalStandTickets + totalKidTickets;

            while (command != "Finish")
            {
                string film = command;
                int initialCapacityForTheFilm = int.Parse(Console.ReadLine());
                int capacityForTheFilm = initialCapacityForTheFilm;

                int studentTickets = 0;
                int standatdTickets = 0;
                int kidTickets = 0;

                string command2 = Console.ReadLine();
                while (command2 != "End")
                {

                    string ticketType = command2;

                    if (ticketType == "student")
                    {
                        studentTickets++;
                        capacityForTheFilm--;
                    }
                    else if (ticketType == "standard")
                    {
                        standatdTickets++;
                        capacityForTheFilm--;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                        capacityForTheFilm--;
                    }

                    if (capacityForTheFilm <= 0)
                    {
                        break;
                    }

                    command2 = Console.ReadLine();
                }

                totalStudentsTickets += studentTickets;
                totalStandTickets += standatdTickets;
                totalKidTickets += kidTickets;



                int totalTicketsForTheFilm = studentTickets + standatdTickets + kidTickets;

                totalTickets += totalTicketsForTheFilm;

                Console.WriteLine($"{film} - {100.0 * totalTicketsForTheFilm / initialCapacityForTheFilm:f2}% full.");

                command = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 * totalStudentsTickets / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * totalStandTickets / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * totalKidTickets / totalTickets:f2}% kids tickets.");
        }
    }
}
