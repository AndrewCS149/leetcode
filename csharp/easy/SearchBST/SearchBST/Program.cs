using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace SearchBST
{
    internal class Program
    {
        /*
         700. Search in a Binary Search Tree
        Difficulty - easy

        Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node's value equals the given value. Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
         */

        private static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree(4);
            tree.Add(2, 7, 1, 3);
            TreeNode subTree = SearchBST(tree.Root, 2);
            Console.WriteLine(subTree.val);
            Console.WriteLine(subTree.right.val);
            Console.WriteLine(subTree.left.val);
        }

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode subTree = null;
            TreeNode current;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                current = stack.Pop();
                if (current.val == val) return current;

                if (current.right != null)
                    stack.Push(current.right);
                if (current.left != null)
                    stack.Push(current.left);
            }

            return subTree;
        }

        // Definition for BST
        public class BinarySearchTree
        {
            public TreeNode Root { get; set; }
            public int Count { get; set; }

            public BinarySearchTree()
            {
                Count = 0;
            }

            public BinarySearchTree(int value)
            {
                TreeNode root = new TreeNode(value);
                Root = root;
                Count = 1;
            }

            public void Add(params int[] values)
            {
                foreach (int num in values)
                    Add(num);
            }

            private void Add(int num)
            {
                TreeNode newNode = new TreeNode(num);

                if (Root == null)
                    Root = newNode;
                else
                    Add(newNode, Root);
            }

            private void Add(TreeNode newNode, TreeNode root)
            {
                if (newNode.val < root.val)
                {
                    if (root.left == null)
                        root.left = newNode;
                    else
                        Add(newNode, root.left);
                }
                else
                {
                    if (root.right == null)
                        root.right = newNode;
                    else
                        Add(newNode, root.right);
                }
            }

            public void Print()
            {
                if (Root == null) return;

                Stack<TreeNode> stack = new Stack<TreeNode>();
                stack.Push(Root);
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
        }

        // Definition for a binary tree node.
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