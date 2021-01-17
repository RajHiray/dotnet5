using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Matrix_Zeroes
{
    public class Solution
    {
        /// <summary>
        /// If an element is 0, set its entire row and column to 0
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[][] matrix)
        {
            int r = matrix.Length;
            int c = matrix[0].Length;
            bool root = false;
            for (int i = 0; i < r; i++)
            {
                if (matrix[i][0] == 0)
                {
                    root = true;
                }
                for (int j = 1; j < c; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < r; i++)
            {
                for (int j = 1; j < c; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // See if the first row needs to be set to zero as well
            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            // See if the first column needs to be set to zero as well
            if (root)
            {
                for (int i = 0; i < r; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}