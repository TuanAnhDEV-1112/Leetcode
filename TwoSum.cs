using System;
using System.Collections.Generic;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        List<List<int>> table = new List<List<int>>();

        for (int i = 0;i < nums.Length; i++)
        {
            int x = nums[i];

            int y = target - x;

            int key = y * ( y >= 0 ? 1 : -1) % nums.Length;

            if (key < table.Count)
            {

                foreach (int idx in table[key])
                {
                    if (y == nums[idx] && idx != i)
                    {
                        return new int[2] { i, idx };
                    }
                }
            }

            int n = x * (x >= 0 ? 1 : -1) % nums.Length;

            while (table.Count <= n)
            {
                table.Add(new List<int>());
            }

            table[n].Add(i);
        }

        return new int[0];
    }
}