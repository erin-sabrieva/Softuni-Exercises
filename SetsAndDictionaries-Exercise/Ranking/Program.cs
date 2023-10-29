using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestents = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input!= "end of contests")
            {
                string[] commands = input.Split(":");
                contestents.Add(commands[0],commands[1]);
                input = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            while (input2!= "end of submissions")
            {
                string[] tokens = input2.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string candidate = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contestents.ContainsKey(contest)&& contestents[contest]==password)
                {
                    UpsertCandidate(candidate,points,contest,candidates);
                }
                input2 = Console.ReadLine();

            }
            string bestCandidate = candidates.OrderByDescending(x=>x.Value.Values.Sum()).First().Key;
            int totalPoints = candidates[bestCandidate].Values.Sum();
            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in candidates)
            {
                var orderByPoints = item.Value.OrderByDescending(x=>x.Value);
                Console.WriteLine($"{item.Key}");
                foreach (var it in orderByPoints)
                {
                    Console.WriteLine($"#  {it.Key} -> {it.Value}");
                }
            }


        }

       static void UpsertCandidate(string candidate, int points, string contest, SortedDictionary<string, Dictionary<string, int>> candidates)
        {
            if (!candidates.ContainsKey(candidate))
            {
                candidates[candidate] = new Dictionary<string, int>();
            }
            if (!candidates[candidate].ContainsKey(contest))
            {
                candidates[candidate][contest]=0;
            }
            if (candidates[candidate][contest]<points)
            {
                candidates[candidate][contest] = points;
            }
        }
    }
}
