using System;

namespace Single_Number
{
    /* 136. Single Number
    Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    Follow up: Could you implement a solution with a linear runtime complexity and without using extra memory?

    Example 1:
        Input: nums = [2,2,1]
        Output: 1
    
    Example 2:
        Input: nums = [4,1,2,1,2]
        Output: 4

    Example 3:
        Input: nums = [1]
        Output: 1

    Constraints:
        1 <= nums.length <= 3 * 104
        -3 * 104 <= nums[i] <= 3 * 104
        Each element in the array appears twice except for one element which appears only once.
     */
    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new();
            int result;

            var input1 = new int[] { 4, 1, 2, 1, 2 };
            result = solution.SingleNumber(input1);
            Console.WriteLine(result);

            var input2 = new int[] { 2, 2, 1 };
            result = solution.SingleNumber(input2);
            Console.WriteLine(result);

        }
    }
}
