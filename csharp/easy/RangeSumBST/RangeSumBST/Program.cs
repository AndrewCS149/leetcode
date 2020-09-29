using System;
using System.Collections.Generic;

namespace RangeSumBST
{
    internal class Program
    {
        /*
         938. Range Sum of BST
        Difficulty - easy

        Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).

        The binary search tree is guaranteed to have unique values.
         */

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;

            TreeNode current;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                current = stack.Pop();
                if (current.val <= R && current.val >= L)
                    sum += current.val;

                if (current.right != null)
                    stack.Push(current.right);
                if (current.left != null)
                    stack.Push(current.left);
            }
            return sum;
        }

        //Definition for private a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}