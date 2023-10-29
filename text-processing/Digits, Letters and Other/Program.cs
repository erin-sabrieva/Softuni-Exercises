using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder other = new StringBuilder();
            foreach (var ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digit.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letter.Append(ch);
                }
                else
                {
                    other.Append(ch);
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(other);
        }
    }
}
