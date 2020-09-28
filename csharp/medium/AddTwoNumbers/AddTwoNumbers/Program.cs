using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTwoNumbers
{
    /* Leetcode challenge 2. Add Two Numbers
    You are given two non empty linked lists representing two non negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

    You may Assume the two numbers do not contain any leading zero, except the number zero itself.

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            // TEST 1
            LinkedList l1 = new LinkedList();
            l1.AddFirst(3);
            l1.AddFirst(4);
            l1.AddFirst(2);
            l1.Print();

            Console.WriteLine();

            LinkedList l2 = new LinkedList();
            l2.AddFirst(4);
            l2.AddFirst(6);
            l2.AddFirst(5);
            l2.Print();

            Console.WriteLine();

            LinkedList l3 = AddTwoNumbers(l1, l2);
            l3.Print();

            Console.WriteLine();

            // TEST 2

            LinkedList l4 = new LinkedList();
            l4.AddFirst(3);
            l4.AddFirst(2);
            l4.AddFirst(1);
            l4.Print();

            Console.WriteLine();

            LinkedList l5 = new LinkedList();
            l5.AddFirst(6);
            l5.AddFirst(5);
            l5.AddFirst(4);
            l5.Print();

            Console.WriteLine();

            LinkedList l6 = AddTwoNumbers(l4, l5);
            l6.Print();
        }

        public static LinkedList AddTwoNumbers(LinkedList l1, LinkedList l2)
        {
            Node l1current = l1.Head;
            Node l2current = l2.Head;
            LinkedList newList = new LinkedList();
            string l1sum = "";
            string l2sum = "";

            while (l1current != null)
            {
                l1sum += l1current.Value;
                l2sum += l2current.Value;

                l1current = l1current.Next;
                l2current = l2current.Next;
            }

            int total = Int32.Parse(l1sum) + Int32.Parse(l2sum);
            char[] arr = total.ToString().ToCharArray();

            foreach (char digit in arr)
            {
                newList.AddFirst(Int32.Parse(digit.ToString()));
            }

            return newList;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    public class LinkedList
    {
        public Node Head { get; set; }
        public int Length { get; set; }

        public LinkedList()
        {
            Length = 0;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            if (Length == 0)
                Head = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            Length++;
        }

        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " - ");
                current = current.Next;
            }
        }
    }
}