using System;

/*
Challenge 1. Two Sum
Difficulty - Easy

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice
*/

namespace TwoSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 11, 15 };
            int[] arr2 = new int[] { 3, 2, 4 };
            int[] arr3 = new int[] { 2, 5, 5, 11 };

            Console.WriteLine(String.Join(",", TwoSum(arr, 9)));
            Console.WriteLine(String.Join(",", TwoSum(arr2, 6)));
            Console.WriteLine(String.Join(",", TwoSum(arr3, 10)));
        }

        private static int[] TwoSum(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (arr[i] + arr[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
    }
}