using System;

namespace TrappingRain
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            int result;

            var input1 = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            result = solution.Trap(input1);
            Console.WriteLine(result);
        }
    }
}
