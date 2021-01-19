using System;
using System.Collections.Generic;

namespace Spiral_Matrix
{
    class Program
    {
        /* 54. Spiral Matrix
        Given an m x n matrix, return all elements of the matrix in spiral order.

        Example 1:
            Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
            Output: [1,2,3,6,9,8,7,4,5]

        Example 2:
            Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
            Output: [1,2,3,4,8,12,11,10,9,5,6,7]

        Constraints:
            m == matrix.length
            n == matrix[i].length
            1 <= m, n <= 10
            -100 <= matrix[i][j] <= 100
         */
        static void Main(string[] args)
        {
            Solution solution = new();
            IList<int> result;


            var input1 = new int[][] {
                new []{ 1,2,3 },
                new []{ 4,5,6 },
                new []{ 7, 8, 9 }
            };

            var input2 = new int[][] {
                new []{ 1,2,3,4 },
                new []{ 5,6,7,8 },
                new []{ 9, 10, 11, 12 }
            };

            result = solution.SpiralOrder(input1);
            foreach (var item in result)
            {
                Console.Write($" {item} ");
            }
            result = solution.SpiralOrder(input2);
            foreach (var item in result)
            {
                Console.Write($" {item} ");
            }

        }
    }
}
