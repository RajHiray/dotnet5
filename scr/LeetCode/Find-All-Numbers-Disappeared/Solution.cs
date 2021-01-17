using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Find_All_Numbers_Disappeared
{
    public class Solution
    {
        /// <summary>
        ///  Find all the elements of [1, n] inclusive that do not appear in this array.
        /// </summary>
        /// <param name="nums">Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array)</param>
        /// <returns></returns>
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            int lenght = nums.Length, item;
            for (int i = 0; i < lenght; i++)
            {
                item = Math.Abs(nums[i]) - 1;
                nums[item] = nums[item] > 0 ? -nums[item] : nums[item];
            }
            for (int i = 0; i < lenght; i++)
            {
                if (nums[i] > 0)
                    result.Add(i + 1);
            }
            return result;
        }

        /// <summary>
        ///  Find all the elements of [1, n] inclusive that do not appear in this array.
        ///  V0
        /// </summary>
        /// <param name="nums">Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array)</param>
        /// <returns></returns>
        public IList<int> FindDisappearedNumbersV0(int[] nums)
        {
            return Enumerable.Range(1, nums.Length).ToList().Except(nums.ToList()).ToList();
        }
    }
}
