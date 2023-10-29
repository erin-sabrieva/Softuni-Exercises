using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            while (command[0]!= "end")
            {
                if (command[0]== "exchange")
                {
                    int givenIndex = int.Parse(command[1]);
                    arr = ExchangeArr(arr,givenIndex);
                }
                else if (command[0]== "min" || command[0]== "max")
                {
                    FindEvenOrOdd(arr, command[0], command[1]);
                }
                
                else
                {
                    FindNumbers(arr,command[0],int.Parse(command[1]),command[2]);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void FindNumbers(int[] arr, string position, int numbersCount, string evenOdd)
        {
            if (numbersCount>arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (numbersCount==0)
            {
                Console.WriteLine("[]");
                return;
            }
            int resultEvenOrOdd = 1;
            if (evenOdd == "even") resultEvenOrOdd = 0;
            int count=0;
            List<int> nums = new List<int>();
            if (position == "first")
            {
                foreach (int currNum in arr)
                {
                    if (currNum%2==resultEvenOrOdd)
                    {
                        count++;
                        nums.Add(currNum);
                    }
                    if (count == numbersCount) break;
                    
                }
            }
            else
            {
                for (int currIndex=arr.Length-1; currIndex >=0; currIndex--)
                {
                    if (arr[currIndex]%2==resultEvenOrOdd)
                    {
                        count++;
                        nums.Add(arr[currIndex]);
                    }
                    if (count == numbersCount) break;
                    
                }
                nums.Reverse();
            }
            
            Console.WriteLine($"[{string.Join(", ", nums)}]");
           
        }

        private static void FindEvenOrOdd(int[] arr, string minOrMax, string evenOrOdd )
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;
            int resultEven = 1;
            if (evenOrOdd == "even") resultEven = 0;
            for (int currIndex = 0; currIndex < arr.Length; currIndex++)
            {
                if (arr[currIndex]%2==resultEven)
                {
                    if (minOrMax== "min"&& min>=arr[currIndex])
                    {
                        min = arr[currIndex];
                        index = currIndex;
                    }
                    else if (minOrMax=="max"&& max<=arr[currIndex])
                    {
                        max = arr[currIndex];
                        index = currIndex;
                    }
                }
            }
            Console.WriteLine(index > -1 ? index.ToString() : "No matches");
            
        }

        private static int[] ExchangeArr(int[] arr, int givenIndex)
        {
            if (givenIndex<0 || givenIndex>=arr.Length)
            {
                Console.WriteLine("Invalid index");
            }
            int[] exchangedArray = new int[arr.Length];
            int index = 0;
            for (int i = givenIndex+1; i < arr.Length; i++)
            {
                exchangedArray[index] = arr[i];
                index++;
            }
            for (int i = 0; i <= givenIndex; i++)
            {
                exchangedArray[index] = arr[i];
                index++;
            }
            return exchangedArray;
        }
    }
}
 