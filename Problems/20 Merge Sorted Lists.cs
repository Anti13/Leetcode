/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;

        var dummy = new ListNode();
        var current = dummy;

        while(true)
        {
            if(list1 == null || list2 == null)
            {
                break;
            }

            if(list1.val < list2.val)
            {
                current.next= list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        if(list1 !=null)
        {
            current.next = list1;
        }

                if(list2 !=null)
        {
            current.next = list2;
        }
        
        return dummy.next;

    }
}