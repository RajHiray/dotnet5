using System;

namespace Contains_Duplicate
{
    class Program
    {
        /* 217. Contains Duplicate 
            Given an array of integers, find if the array contains any duplicates.
            Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
            Example 1:
                Input: [1,2,3,1]
                Output: true
            Example 2:
                Input: [1,2,3,4]
                Output: false
            Example 3:
                Input: [1,1,1,3,3,4,3,2,4,2]
                Output: true
        */

        static void Main(string[] args)
        {
            Solution solution = new();
            bool result;

            var input1 = new int[] { 1, 2, 3, 4, 5 };
            result = solution.ContainsDuplicate(input1);
            Console.WriteLine(result);

            var input2 = new int[] { 1, 4, 3, 4, 5 };
            result = solution.ContainsDuplicate(input2);
            Console.WriteLine(result);
        }
    }
}
