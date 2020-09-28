using System;

namespace RunningSum
{
    internal class Program
    {
        /*
        1480. Running Sum of 1d Array
        Difficulty - Easy

        Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

        */

        private static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            int[] sumArr = RunningSum(arr);

            PrintArray(sumArr);
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] sumsArr = new int[nums.Length];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sumsArr[i] = sum;
            }

            return sumsArr;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + ", ");
            }
        }
    }
}