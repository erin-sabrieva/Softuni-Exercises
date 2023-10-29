using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            foreach (string currNum in arr1)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    string secondElement = arr2[i];
                    if (currNum == secondElement)
                    {
                        Console.Write($"{secondElement} ");
                        break;
                    }
                }
            }
        }
    }
}
