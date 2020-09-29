using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;

namespace CorrespondingNode
{
    public class Program
    {
        /*
         1379. 1302. Deepest Leaves Sum
        Difficulty - Medium

        Given a binary tree, return the sum of values of its deepest leaves.

         */

        private static void Main(string[] args)
        {
        }

        //Definition for a binary tree node.
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

        public int DeepestLeavesSum(TreeNode root)
        {
            TreeNode current;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            Hashtable table = new Hashtable();
            int level = 0;

            while (stack.Count != 0)
            {
                level++;
                current = stack.Pop();

                if (current.right != null)
                    stack.Push(current.right);
                if (current.left != null)
                    stack.Push(current.left);

                if (current.right == null && current.left == null)
                {
                    table.Add(level, current.val);
                }
            }
            //DeepestLeavesSum(root, table);
        }

        //private void DeepestLeavesSum(TreeNode root, Hashtable table)
        //{
        //    table.Add(Level, root.val);

        //    if (root.left != null)
        //    {
        //        Level++;
        //        DeepestLeavesSum(root.left);
        //    }
        //    if (root.right != null)
        //    {
        //        DeepestLeavesSum(root.right);
        //        Level++;
        //    }

        //    Level--;
        //}
    }
}