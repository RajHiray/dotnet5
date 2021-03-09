using System;
using System.Collections.Generic;
using System.Text;

namespace RotateImage
{
    class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length, temp;
            int l = 0, r = n - 1, i, top, btm;

            while (l < r)
            {
                top = l;
                btm = r;
                for (i = 0; i < r - l; i++)
                {
                    temp = matrix[top][l + i];
                    matrix[top][l + i] = matrix[btm - i][l];
                    matrix[btm - i][l] = matrix[btm][r - i];
                    matrix[btm][r - i] = matrix[top + i][r];
                    matrix[top + i][r] = temp;
                }
                r--;
                l++;
            }
        }
    }
}
