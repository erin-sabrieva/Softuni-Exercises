using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotaion = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotaion; i++)
            {
                int tempEl = arr[0];
                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = tempEl;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        
    }
}
