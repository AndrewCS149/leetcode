using System;
using System.Collections;
using System.Collections.Generic;

namespace GroupPeople
{
    internal class Program
    {
        /*
        Challenge 1282:  Group the People Given the Group Size They Belong To

        There are n people whose IDs go from 0 to n - 1 and each person belongs exactly to one group. Given the array groupSizes of length n telling the group size each person belongs to, return the groups there are and the people's IDs each group includes.

        You can return any solution in any order and the same applies for IDs. Also, it is guaranteed that there exists at least one solution.

        EXAMPLES:
        Input: groupSizes = [3,3,3,3,3,1,3]
        Output: [[5],[0,1,2],[3,4,6]]
        Explanation:
        Other possible solutions are [[2,1,6],[5],[0,4,3]] and [[5],[0,6,2],[4,3,1]]

        Input: groupSizes = [2,1,3,3,3,2]
        Output: [[1],[0,5],[2,3,4]]
        */

        private static void Main(string[] args)
        {
        }

        private IList<IList<int>> ReturnGroups(int[] groupSizes)
        {
            IList<IList<int>> groups = new IList<IList<int>>();
        }
    }
}