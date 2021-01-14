using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Duplicate_Number
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> ts = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(ts.Contains(nums[i]))
                {
                    return nums[i];
                }
                ts.Add(nums[i]);
            }
            return -1;
        }
    }
}
