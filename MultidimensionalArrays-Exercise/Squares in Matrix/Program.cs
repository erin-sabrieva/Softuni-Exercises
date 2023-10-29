using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[dimension[0], dimension[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
            int count = 0;
                for (int row = 0; row < matrix.GetLength(0)-1; row++)
                {
                    for (int col = 0; col <matrix.GetLength(1)- 1; col++)
                    {
                        if (matrix[row,col]==matrix[row,col+1]&& matrix[row, col] == matrix[row+1, col+ 1] && matrix[row, col] == matrix[row+1, col])
                        {
                            count++;
                        }
                    }
                }
            
           
            Console.WriteLine(count);
        }
    }
}
