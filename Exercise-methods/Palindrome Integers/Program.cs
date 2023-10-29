using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                bool Palindrome = IsItPalindrome(input);
                Console.WriteLine(Palindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
            
        }

        private static bool IsItPalindrome(string input)
        {
            int num = int.Parse(input);
            if (num>=0 && num<=9)
            {
                return true;
            }
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i]== input[input.Length-1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
