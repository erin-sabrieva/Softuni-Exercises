using System;

namespace arrays_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                
                sum += arr[i];
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
               
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
