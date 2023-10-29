using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int power = tokens[1];
            int bombnumber= tokens[0];
           
            for (int i = 0; i < nums.Count; i++)
            {
                int target = nums[i];
                if (target== bombnumber )
                {
                    Bombnumber(nums, power, i);
                    continue;
                }
            }
            Console.WriteLine(nums.Sum());
            
        }

        private static void Bombnumber(List<int> nums, int power, int index)
        {
            int start = Math.Max(0, index-power);
            int end = Math.Min(nums.Count-1, index+power);
            for (int i = start; i <= end; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
