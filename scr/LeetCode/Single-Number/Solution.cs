namespace Single_Number
{
    public class Solution
    {
        /// <summary>
        /// every element appears twice except for one. Find that single one.
        /// </summary>
        /// <param name="nums">Given a non-empty array of integers nums </param>
        /// <returns>result</returns>
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];             
            }
            return result;
        }
    }
}
