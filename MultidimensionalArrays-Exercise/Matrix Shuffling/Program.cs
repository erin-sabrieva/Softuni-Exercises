using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[dimension[0],dimension[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] strings = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = strings[col];
                }
            }
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] commands = input.Split();
                if (commands[0]=="swap"&& commands.Length==5&& int.Parse(commands[1])>=0&& int.Parse(commands[1]) < dimension[0]&& int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < dimension[1]&& int.Parse(commands[3]) >= 0 && int.Parse(commands[3]) < dimension[0]&& int.Parse(commands[4]) >= 0 && int.Parse(commands[4]) < dimension[1])
                {
                    string tempValue = matrix[int.Parse(commands[1]), int.Parse(commands[2])];
                    matrix[int.Parse(commands[1]), int.Parse(commands[2])] = matrix[int.Parse(commands[3]), int.Parse(commands[4])];
                    matrix[int.Parse(commands[3]), int.Parse(commands[4])] = tempValue;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
