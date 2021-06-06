using System;
using System.Collections.Generic;
using System.Text;

namespace TrappingRain
{
    class Solution
    {
        public int Trap(int[] height)
        {
            if (height == null || height.Length <= 0)
            {
                return 0;
            }
            int leftMax = 0, pl = 0, pr = height.Length - 1, totalArea = 0, rightMax = 0;

            while (pl < pr)
            {
                if (height[pl] <= height[pr])
                {
                    rightMax = Math.Max(rightMax, height[pr]);
                    if (leftMax <= height[pl])
                    {
                        leftMax = height[pl];
                    }
                    else
                    {
                        totalArea += Math.Min(rightMax, leftMax) - height[pl];
                    }
                    pl++;
                }
                else
                {
                    leftMax = Math.Max(leftMax, height[pl]);
                    if (rightMax <= height[pr])
                    {
                        //rightMax= Math.Max(leftMax,height[pr]);
                        rightMax = height[pr];
                    }
                    else
                    {
                        totalArea += Math.Min(rightMax, leftMax) - height[pr];
                    }
                    pr--;
                }
            }
            return totalArea;
        }
    }
}
