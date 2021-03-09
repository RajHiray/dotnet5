using System;

namespace RotateImage
{
    class Program
    {
        static void Main(string[] args)
        {

            var input1 = new int[][]  {
                new int[]{1,2,3,4},
                new int[]{5,6,7,8},
                new int[]{9,10,11,12},
                new int[]{13,14,15,16}
                };
            Solution solution = new Solution();
            solution.Rotate(input1);        
        }
    }
}
