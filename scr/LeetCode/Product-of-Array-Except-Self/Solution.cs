namespace Product_of_Array_Except_Self
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int lenght = nums.Length,product=1;

            // calculate product left to right
            int[] result = new int[lenght];
            result[0] = 1;
            for (int i = 1; i < lenght; i++)
            {
                result[i] = product * nums[i-1];
                product *= nums[i-1];
            }

            // calculate product right to left and product with result.
            product = 1;            
            for (int i= lenght-2; i >=0 ; i--)
            {
                result[i] *= product * nums[i+1];
                product *= nums[i+1];
            }

            return result;
        }
    }
}
