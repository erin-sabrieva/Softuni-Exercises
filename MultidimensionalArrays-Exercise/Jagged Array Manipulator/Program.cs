using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                double[] cols = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedArray[row] = cols;
            }
            for (int row = 0; row < jaggedArray.Length-1; row++)
            {
                if (jaggedArray[row].Length==jaggedArray[row+1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                        
                    }
                    for (int col = 0; col < jaggedArray[row+1].Length; col++)
                    {
                        jaggedArray[row+1][col] /= 2;

                    }

                }
            }
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] commands = input.Split();
                string word = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                double value = double.Parse(commands[3]);
                if (word=="Add")
                {
                    if (row>=0 && row<jaggedArray.Length&&col>=0&&col<jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else
                {
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                input = Console.ReadLine();
            }

            for (int row = 0; row <rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
