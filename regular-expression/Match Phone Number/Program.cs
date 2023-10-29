using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone = Console.ReadLine();
            string pattern = @"\+359([ \-])2\1[0-9]{3}\1[0-9]{4}\b";
           Regex regex = new Regex(pattern);
            MatchCollection mathes = regex.Matches(phone);
            Console.WriteLine(string.Join(", ", mathes));
            
        }
    }
}
