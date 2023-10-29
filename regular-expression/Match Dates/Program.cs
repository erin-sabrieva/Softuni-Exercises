using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<date>[0-9]{2})(?<separator>[\-\.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";
            
             MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)

            {
                Console.WriteLine($"Day: {item.Groups["date"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}
