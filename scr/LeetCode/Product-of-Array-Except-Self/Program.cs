using System;

namespace Product_of_Array_Except_Self
{
    class Program
    {
        /* 238. Product of Array Except Self
         Given an array nums of n integers where n > 1,  
        return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

        Example:
        Input:  [1,2,3,4]
        Output: [24,12,8,6]
        Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.

        Note: Please solve it without division and in O(n).

        Follow up:
        Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)

         */
        static void Main(string[] args)
        {

            Solution solution = new();
            int[] result;

            var input1 = new int[] { 2, 7, 11, 15 };
            result = solution.ProductExceptSelf(input1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var input2 = new int[] {1, 2, 3, 4};
            result = solution.ProductExceptSelf(input2);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
    }
}
