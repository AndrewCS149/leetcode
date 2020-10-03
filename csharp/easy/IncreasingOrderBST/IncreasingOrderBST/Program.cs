using System;
using System.Collections.Generic;

namespace IncreasingOrderBST
{
    public class Program
    {
        /*
         897. Increasing Order Search Tree
        Difficulty - easy

        Given a binary search tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree, and every node has no left child and only 1 right child.

        Example 1:
        Input: [5,3,6,2,4,null,8,1,null,null,null,7,9]
        Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]
         */

        private static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.left.left.left = new TreeNode(1);
            root.right = new TreeNode(6);
            root.right.right = new TreeNode(8);
            root.right.right.left = new TreeNode(7);
            root.right.right.right = new TreeNode(9);

            TreeNode newRoot = IncreasingBST(root);
            Print(newRoot);
            //Console.WriteLine(newRoot.val);
        }

        public static TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode newTree = new TreeNode();
            newTree = IncreasingBST(root, newTree);
            return newTree;
        }

        private static TreeNode IncreasingBST(TreeNode root, TreeNode newTree)
        {
            if (root.left != null)
            {
                return IncreasingBST(root.left, newTree);
            }

            if (root.right != null)
            {
                return IncreasingBST(root.right, newTree);
            }

            return new TreeNode(20);
        }

        //public static TreeNode IncreasingBST(TreeNode root)
        //{
        //    if (root == null) return root;

        //    TreeNode current = root;
        //    TreeNode newCurrent = new TreeNode();
        //    TreeNode newRoot = new TreeNode(); ;
        //    Stack<TreeNode> stack = new Stack<TreeNode>();
        //    int iteration = 0;
        //    while (true)
        //    {
        //        if (current != null)
        //        {
        //            stack.Push(current);
        //            current = current.left;
        //        }
        //        else
        //        {
        //            if (stack.Count == 0) break;

        //            current = stack.Pop();
        //            newCurrent = current;
        //            current = current.right;

        //            if (iteration == 0)
        //            {
        //                newRoot = newCurrent;
        //            }

        //            newCurrent = newCurrent.right;
        //            iteration++;
        //        }
        //    }

        //    return newRoot;
        //}

        public static void Print(TreeNode root)
        {
            TreeNode current = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (true)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                else
                {
                    if (stack.Count == 0) break;
                    current = stack.Pop();
                    Console.Write(current.val + ", ");
                    current = current.right;
                }
            }
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
    }
}