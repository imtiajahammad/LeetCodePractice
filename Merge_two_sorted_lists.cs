using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LeetCodePractice
{
    public class Merge_two_sorted_lists
    {
        private int testInteger;
        public Merge_two_sorted_lists()
        {
            ListNode list1 = new ListNode(){ val=1,next= new ListNode(){ val =2, next = new ListNode(){val = 4, next = null}}};
            ListNode list21 = new ListNode(){ val=-1,next= new ListNode(){ val =0, next = new ListNode(){val = 1, next = null}}};
            ListNode list2 = new ListNode(){ val=1,next= new ListNode(){ val =2, next = new ListNode(){val = 3, next = null}}};
            ListNode result = MergeTwoLists(list1, list2);
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
        {
            var head = new ListNode();
            var pivot = head;
            while( list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    Console.Write($"-> {list1.val}");
                    pivot.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    Console.Write($"-> {list2.val}");
                    pivot.next = list2;
                    list2 = list2.next;
                }
                pivot= pivot.next;
            }
            if(list1 == null && list2 != null)
            {
                pivot.next = list2;
            }
            else if( list2 == null && list1 !=null)
            {
                pivot.next = list1;
            }
            return head.next;
        }
    }
    public class ListNode {
       public int val;
       public ListNode next;
       public ListNode(int val=0, ListNode next=null)
       {
           this.val = val;
           this.next = next;
       }
       }
}
