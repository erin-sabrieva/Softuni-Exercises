using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternLetters = new Regex(@"(?<name>[A-Za-z]+)");
            string patternDigit = @"(?<digit>[0-9]+)";
            int sum = 0;
            var partisipants = new Dictionary<string, int>();
            var names = Console.ReadLine().Split(" ").ToList();
            string input = Console.ReadLine();
            while (input!= "end of race")
            {
                MatchCollection matchedName = patternLetters.Matches(input);
                MatchCollection matchedDigits =Regex.Matches(input, patternDigit);
                string currName = string.Join("", matchedName);
                string currDigit = string.Join("", matchedDigits);
                sum = 0;
                for (int i = 0; i < currDigit.Length; i++)
                {
                    sum += int.Parse(currDigit[i].ToString());
                }
                if (!names.Contains(currName))
                {
                    if (!partisipants.ContainsKey(currName))
                    {
                        partisipants.Add(currName, sum);
                    }
                    else
                    {
                        partisipants[currName] += sum;
                    }

                }

                input = Console.ReadLine();
            }
            var winners = partisipants.OrderByDescending(x => x.Value).Take(3);
            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);
            foreach (var item in firstPlace)
            {
                Console.WriteLine($"1st place: {item.Key}");
            }
            foreach (var item in secondPlace)
            {
                Console.WriteLine($"2nd place: {item.Key}");
            }
            foreach (var item in thirdPlace)
            {
                Console.WriteLine($"3rd place: {item.Key}");
            }
        }
    }
}
