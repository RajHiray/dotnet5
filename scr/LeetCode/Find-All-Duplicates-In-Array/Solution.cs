using System;
using System.Collections.Generic;
using System.Text;

namespace Find_All_Duplicates_In_Array
{
    public class Solution
    {
        /// <summary>
        /// Find all the elements that appear twice in this array.
        /// </summary>
        /// <param name="nums">Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array)</param>
        /// <returns></returns>
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> result = new List<int>();
            int lenght = nums.Length, item;
            for (int i = 0; i < lenght; i++)
            {
                item = Math.Abs(nums[i]) - 1;
                if (nums[item] < 0)
                    result.Add(item + 1);
                nums[item] = -Math.Abs(nums[item]);
            }
            return result;
        }
    }
}
