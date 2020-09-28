using System;

namespace FormGroups
{
    internal class Program
    {
        /*
        1395. Count Number of Teams - Medium difficulty

        There are n soldiers standing in a line. Each soldier is assigned a unique rating value.
        You have to form a team of 3 soldiers amongst them under the following rules:

        Choose 3 soldiers with index (i, j, k) with rating (rating[i], rating[j], rating[k]).
        A team is valid if:  (rating[i] < rating[j] < rating[k]) or (rating[i] > rating[j] > rating[k]) where (0 <= i < j < k < n).

        EXAMPLES
        Input: rating = [2,5,3,4,1]
        Output: 3
        Explanation: We can form three teams given the conditions. (2,3,4), (5,4,1), (5,3,1).
        */

        private static void Main(string[] args)
        {
            int[] testArr = { 2, 5, 3, 4, 1 };
            int[] testArr2 = { 1, 2, 3, 4 };

            Console.WriteLine(Group(testArr));
            Console.WriteLine(Group(testArr2));
        }

        /*
        PSEUDO

        ALGORITHM Group(array)
            DEFINE group = 0

            for i = 0 to array.Length
                for k = 1 to array.length
                    DEFINE neg = 0
                    DEFINE pos = 0
                    pos += ComparePos(array[i], array[j])
                    neg += CompareNeg(array[i], array[j])
                    if neg == 3
                        group++
                        neg == 0
                    if pos == 3
                        group++
                        pos == 0

            return group

        ALGORITHM CompareNeg(num1, num2)
            if num1 < num2
                return 1
            return 0

        ALGORITHM ComparePos(num1, num2)
            if num1 > num2
                return 1
            return 0
        */

        private static int Group(int[] arr)
        {
            int groups = 0;
            int pos = 0;
            int neg = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[k] > temp)
                    {
                        temp = arr[k];
                        pos++;
                    }
                    if (arr[k] < temp)
                    {
                        temp = arr[k];
                        neg++;
                    }
                    if (pos == 2)
                    {
                        groups++;
                        pos = 0;
                    }
                    if (neg == 2)
                    {
                        groups++;
                        neg = 0;
                    }
                }
            }
            return groups;
        }
    }
}