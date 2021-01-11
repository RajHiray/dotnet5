using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class Solution
    {
        /// <summary>
        /// return indices of the two numbers such that they add up to target.
        /// Brute Force
        /// </summary>
        /// <param name="nums">Given an array of integers nums and an integer</param>
        /// <param name="target">target</param>
        /// <returns>result</returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            int[] result = null;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                        result = new int[] { i, j };
                }
            }
            return result;
        }

        /// <summary>
        /// return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums">Given an array of integers nums and an integer</param>
        /// <param name="target">target</param>
        /// <returns>result</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = null;
            List<int> elements = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int remaining = target - nums[i];
                if(elements.Contains(remaining))
                {
                    return new int[] {elements.IndexOf(remaining),i};
                }
                elements.Add(nums[i]);
            }
            return result;
        }
    }
}
