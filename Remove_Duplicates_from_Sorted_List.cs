using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePractice;

public class Remove_Duplicates_from_Sorted_List
{
    public Remove_Duplicates_from_Sorted_List()
    {
        ListNode list1 = new ListNode(){ val=1,next= new ListNode(){ val =1, next = new ListNode(){val = 2, next = null}}};
        ListNode list2 = new ListNode(){ val=1,next= new ListNode(){ val =1, next = new ListNode(){val = 2, next = new ListNode(){ val = 3, next = new ListNode(){ val=3, next = null}}}}};
        ListNode list3 = new ListNode(){ val=1,next= new ListNode(){ val =1, next = new ListNode(){val = 1, next = null}}};
        DeleteDuplicates(list3);
    }
    public ListNode DeleteDuplicates(ListNode head) 
    {
        if(head == null)
        {
            return null;
        }
        var temp = head;
        while(temp != null && temp.next !=null)
        {
            if(temp.val == temp.next.val)
            {
                temp.next = temp.next.next;
            }
            else{
                temp = temp.next;
            }
        }
        return head;
    }
    public class ListNode 
    {
       public int val;
       public ListNode next;
       public ListNode(int val=0, ListNode next=null) {
           this.val = val;
           this.next = next;
       }
   }
}
