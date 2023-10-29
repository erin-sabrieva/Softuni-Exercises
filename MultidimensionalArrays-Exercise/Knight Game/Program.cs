using System;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size<3)
            {
                Console.WriteLine(0);
                return;
            }
            char[,] matrix = new char[size, size];
            for (int ro = 0; ro < size; ro++)
            {
                string chars = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[ro, col] = chars[col];
                }
            }
           
            int knightRemoe = 0;
            while (true)
            {
                int countMotAttacking = 0;
                int roMotAttacking = 0;
                int colMotAttacking = 0;
                for (int ro = 0; ro < size; ro++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[ro, col]=='K')
                        {
                            int attachedKnight = CountAttackedNight(ro,col, size,matrix);
                            if (countMotAttacking<attachedKnight)
                            {
                                countMotAttacking = attachedKnight;
                                roMotAttacking = ro;
                                colMotAttacking = col;
                            }
                        }
                    }
                }
                if (countMotAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[roMotAttacking, colMotAttacking] = '0';
                    knightRemoe++;
                }
            }
            Console.WriteLine(knightRemoe);
        }

         static int CountAttackedNight(int ro, int col, int size, char[,] matrix)
        {
            int atttackedKnight = 0;
            if (IsCellValid(ro-1,col- 2, size))
            {
                if (matrix[ro-1,col- 2]=='K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro + 1, col - 2, size))
            {
                if (matrix[ro + 1, col - 2] == 'K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro - 1, col + 2, size))
            {
                if (matrix[ro - 1, col + 2] == 'K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro + 1, col + 2, size))
            {
                if (matrix[ro + 1, col + 2] == 'K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro - 2, col - 1, size))
            {
                if (matrix[ro - 2, col - 1] == 'K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro - 2, col + 1, size))
            {
                if (matrix[ro - 2, col + 1] == 'K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro + 2, col - 1, size))
            {
                if (matrix[ro + 2, col - 1] == 'K')
                {
                    atttackedKnight++;
                }
            }
            if (IsCellValid(ro + 2, col + 1, size))
            {
                if (matrix[ro + 2, col + 1] == 'K')
                {
                    atttackedKnight++;
                }
            }
            return atttackedKnight;

        }
        static bool IsCellValid(int ro, int col, int size)
        {
            return ro >= 0 && ro < size && col >= 0 && col < size;
        }
    }
}
