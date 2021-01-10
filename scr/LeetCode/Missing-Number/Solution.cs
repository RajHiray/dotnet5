namespace Missing_Number
{
    public class Solution
    {
        /// <summary>
        /// return the only number in the range that is missing from the array.
        /// </summary>
        /// <param name="nums">Given an array nums containing n distinct numbers in the range [0, n]</param>
        /// <returns>result</returns>
        public int MissingNumber(int[] nums)
        {
            int result = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                result ^= nums[i - 1];
                result ^= i;
            }
            return result;
        }
    }
}
