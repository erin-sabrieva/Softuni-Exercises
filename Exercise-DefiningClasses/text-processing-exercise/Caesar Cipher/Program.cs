﻿using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = (char)(input[i] + 3);
                sb.Append(symbol);
            }
            Console.WriteLine(sb);
        }
    }
}
