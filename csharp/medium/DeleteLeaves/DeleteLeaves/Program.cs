using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace DeleteLeaves
{
    internal class Program
    {
        /*
         1325. Delete Leaves With a Given Value
        Difficulty - easy

        Given a binary tree root and an integer target, delete all the leaf nodes with value target.

        Note that once you delete a leaf node with value target, if it's parent node becomes a leaf node and has the value target, it should also be deleted (you need to continue doing that until you can't)
         */

        /*
         REPORT
        Difficulty rating: 7

        I was not able to complete this without looking up an answer. I tried to solve it recursively inorder (which is correct), but I did not do it in the correct manner.
         */

        private static void Main(string[] args)
        {
            TreeNode root = new TreeNode();

            Add(root, 10, 5, 2, 2, 15, 12);

            Print(root);

            RemoveLeafNodes(root, 2);

            Print(root);
        }

        public static TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null) return root;

            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);

            if (root.val == target &&
                root.left == null &&
                root.right == null)
                return null;

            return root;
        }

        public static void Add(TreeNode root, params int[] values)
        {
            foreach (int val in values)
                Add(root, val);
        }

        public static void Add(TreeNode root, int value)
        {
            TreeNode newNode = new TreeNode(value);

            if (root.val == 0)
                root.val = value;
            else
                Add(root, newNode);
        }

        private static void Add(TreeNode root, TreeNode newNode)
        {
            if (newNode.val < root.val)
            {
                if (root.left == null)
                    root.left = newNode;
                else
                    Add(root.left, newNode);
            }
            else
            {
                if (root.right == null)
                    root.right = newNode;
                else
                    Add(root.right, newNode);
            }
        }

        public static void Print(TreeNode root)
        {
            if (root == null) return;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            TreeNode current;

            while (stack.Count != 0)
            {
                current = stack.Pop();
                Console.Write(current.val + " - ");

                if (current.right != null)
                    stack.Push(current.right);
                if (current.left != null)
                    stack.Push(current.left);
            }
            Console.WriteLine();
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