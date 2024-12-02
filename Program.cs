//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

using System;
using System.Collections.Generic;

namespace CCAD16_Assignment5_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 2, 4 };

            Console.WriteLine($"Your array is: [{string.Join(", ", nums)}]");
            
            bool repeatNum = DuplicateValue(nums);

            Console.WriteLine($"Does the array contain duplicates? {repeatNum}");
        }

        static bool DuplicateValue(int[] nums)
        {
        Dictionary<int, int> numCounts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numCounts.ContainsKey(num))
                {
                    numCounts[num]++;
                    
                    if (numCounts[num] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    numCounts[num] = 1;
                }
            }

            return false;
        }
    }
}
