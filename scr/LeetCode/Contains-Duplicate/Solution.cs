using System;
using System.Collections.Generic;

namespace Contains_Duplicate
{
    public class Solution
    {
        /// <summary>
        /// Check Is Contains Duplicate Elements.
        /// Use Hashset
        /// </summary>
        /// <param name="nums"> Arrayy of Elements</param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            var hash = new HashSet<int>(nums);
            return hash.Count < nums.Length;
        }

        /// <summary>
        /// Check Is Contains Duplicate Elements.
        /// Use Array Sort.
        /// </summary>
        /// <param name="nums"> Arrayy of Elements</param>
        /// <returns></returns>
        public bool ContainsDuplicate1(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }
            return false;
        }
    }
}
