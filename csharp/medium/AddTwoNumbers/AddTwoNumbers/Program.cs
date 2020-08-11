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

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        private static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            ListNode l1child = new ListNode();
            l1.val = 5;
            l1child.val = 8;
            l1.next = l1child;

            ListNode l2 = new ListNode();
            ListNode l2child = new ListNode();
            l2.val = 7;
            l2child.val = 6;
            l2.next = l2child;

            AddTwoNumbers(l1, l2);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string str = "";
            string str2 = "";
            while (l1 != null)
            {
                str += l1.val;
                str2 += l2.val;
                l1 = l1.next;
                l2 = l2.next;
            }

            int sum1 = Int32.Parse(str);
            int sum2 = Int32.Parse(str2);
            int totalSum = sum1 + sum2;
            string[] sumArr = totalSum.ToString().Split("");
            Array.Reverse(sumArr);

            foreach (var item in sumArr)
            {
                Console.WriteLine(item);
            }

            ListNode head = new ListNode();
            head.val = Int32.Parse(sumArr[0]);
            ListNode current = head;
            for (int i = 1; i < sumArr.Length; i++)
            {
                current = current.next;
                current.val = Int32.Parse(sumArr[i]);
            }

            return current;
        }
    }
}