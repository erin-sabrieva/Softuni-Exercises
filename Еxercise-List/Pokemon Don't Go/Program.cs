using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index;
            int currentValue;
            int sum=0;
            while (nums.Count!=0)
            {
                index = int.Parse(Console.ReadLine());

                if (index<0)
                {
                    currentValue = nums[0];
                    sum += currentValue;
                    nums[0] = nums[nums.Count - 1];

                }
                else if (index>nums.Count-1)
                {
                    currentValue = nums[nums.Count - 1];
                    sum += currentValue;
                    nums[nums.Count - 1] = nums[0];

                }
                else
                {
                    currentValue = nums[index];
                    sum += currentValue;
                    nums.RemoveAt(index);
                }
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i]<=currentValue)
                    {
                        nums[i] += currentValue;
                    }
                    else
                    {
                        nums[i] -= currentValue;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
