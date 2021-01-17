using System;
using System.Collections.Generic;

namespace Find_All_Duplicates_In_Array
{
    class Program
    {
        /* 442. Find All Duplicates in an Array
        Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
        Find all the elements that appear twice in this array.
        Could you do it without extra space and in O(n) runtime?

        Example:
            Input:
            [4,3,2,7,8,2,3,1]
            Output:
            [2,3]
         */
        static void Main(string[] args)
        {
            Solution solution = new();
            IList<int> result;

            var input1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            result = solution.FindDuplicates(input1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var input2 = new int[] { 4, 3, 4, 2, 3 };
            result = solution.FindDuplicates(input2);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
    }
}
