using System;

namespace Two_Sum
{
    class Program
    {
        /* 1. Two Sum          
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        Example 1:
            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Output: Because nums[0] + nums[1] == 9, we return [0, 1].

        Example 2:
            Input: nums = [3,2,4], target = 6
            Output: [1,2]

        Example 3:
            Input: nums = [3,3], target = 6
            Output: [0,1]
 
        Constraints:
            2 <= nums.length <= 103
            -109 <= nums[i] <= 109
            -109 <= target <= 109
            Only one valid answer exists.         
         */

        static void Main(string[] args)
        {

            Solution solution = new();
            int[] result;

            var input1 = new int[] { 2, 7, 11, 15 };
            result = solution.TwoSum(input1,9);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var input2 = new int[] { 3, 2, 4 };
            result = solution.TwoSum(input2,6);           

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
    }
}
