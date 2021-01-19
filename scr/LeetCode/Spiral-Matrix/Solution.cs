using System.Collections.Generic;

namespace Spiral_Matrix
{
    public class Solution
    {
        /// <summary>
        /// return all elements of the matrix in spiral order.
        /// </summary>
        /// <param name="matrix">Given an m x n matrix,</param>
        /// <returns></returns>
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            int row, col, i, top, btm, right, left, dir;
            row = matrix.Length;
            col = matrix[0].Length;
            top = left = 0;
            btm = row - 1;
            right = col - 1;
            dir = 0;

            while (top <= btm && left <= right)
            {
                if (dir == 0)
                {
                    for (i = left; i <= right; i++)
                    {
                        result.Add(matrix[top][i]);
                    }
                    top++;
                }
                if (dir == 1)
                {
                    for (i = top; i <= btm; i++)
                    {
                        result.Add(matrix[i][right]);
                    }
                    right--;
                }
                if (dir == 2)
                {
                    for (i = right; i >= left; i--)
                    {
                        result.Add(matrix[btm][i]);
                    }
                    btm--;
                }
                if (dir == 3)
                {
                    for (i = btm; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }
                    left++;
                }
                dir = (dir + 1) % 4;
            }
            return result;
        }
    }
}
