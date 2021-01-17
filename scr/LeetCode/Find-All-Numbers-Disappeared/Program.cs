using System;
using System.Collections.Generic;

namespace Find_All_Numbers_Disappeared
{
    /* 448. Find All Numbers Disappeared in an Array
    Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
    Find all the elements of [1, n] inclusive that do not appear in this array.

    Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
    Example:
        Input:
        [4,3,2,7,8,2,3,1]
        Output:
        [5,6]     
     */
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            IList<int> result;

            var input1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            result = solution.FindDisappearedNumbers(input1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var input2 = new int[] { 3, 2, 4,2,3 };
            result = solution.FindDisappearedNumbers(input2);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
    }
}
