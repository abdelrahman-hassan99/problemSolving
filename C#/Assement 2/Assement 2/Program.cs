using System;
using System.Collections.Generic;

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            // نخزن القيمة الحالية وموقعها
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        // هذا السطر نظريًا لن يُنفذ لأن الحل مضمون
        throw new ArgumentException("No two sum solution found");
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Index1: {result[0]}, Index2: {result[1]}");
    }
}
