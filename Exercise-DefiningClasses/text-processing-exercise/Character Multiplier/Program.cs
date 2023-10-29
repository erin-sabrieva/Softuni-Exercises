using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Console.WriteLine(CharMultiplyer(input[0], input[1]));
        }
        public static int CharMultiplyer(string str1, string str2)
        {
            int sum = 0;
            string longest = "";
            string shortest = "";
            if (str1.Length>str2.Length)
            {
                longest=str1;
                shortest=str2;
            }
            else
            {
                shortest=str1;
               longest=str2;
            }
            for (int i = 0; i < shortest.Length; i++)
            {
                sum += str1[i] * str2[i];
            }
            for (int j = shortest.Length; j < longest.Length; j++)
            {
                sum += longest[j];
            }
            return sum;
        }
    }
}
