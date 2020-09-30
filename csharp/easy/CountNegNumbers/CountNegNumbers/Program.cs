using System;

namespace CountNegNumbers
{
    public class Program
    {
        /*
         1351. Count Negative Numbers in a Sorted Matrix
        Difficulty - easy

        Given a m * n matrix grid which is sorted in non-increasing order both row-wise and column-wise.

        Return the number of negative numbers in grid.
         */

        private static void Main(string[] args)
        {
            int[][] grid = new int[][]
            {
                new int[] {4, 3, 2, -1 },
                new int[] {3, 2, 1, -1 },
                new int[] {1, 1, -1, -2 },
                new int[] {-1, -1, -2, -3 }
            };

            Console.WriteLine(CountNegatives(grid));
        }

        public static int CountNegatives(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] < 0) count++;
            }
            return count;
        }
    }
}