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
        if(list1 ==null && list2==null)
        {
            return null;
        }

                if(list1 ==null && list2!=null)
        {
            return list2;
        }

                if(list1 !=null && list2==null)
        {
            return list1;
        }

        ListNode result =  null;
        var current = result;
        if(list1.val>list2.val)
        {
            var temp =new ListNode(list2.val,null);
            result = temp;
            list2 = list2.next;
        }
        else
        {
            var temp =new ListNode(list1.val,null);
            result = temp;
              list1 = list1.next;
        }
        current = result;



                while(true)
        {
        if(list1 ==null && list2==null)
        {
            break;
        }

                if(list1 ==null && list2!=null)
        {
            var temp =new ListNode(list2.val,null);
            current.next = temp;
             current = temp;
             list2=list2.next;
            continue;


        }
                if(list1 !=null && list2==null)
        {
            var temp =new ListNode(list1.val,null);
           current.next = temp;
             current = temp;
             list1=list1.next;
             continue;
        }

        if(list1.val < list2.val)
        {
            var temp =new ListNode(list1.val,null);
          current.next = temp;
             current = temp;
             list1=list1.next;
        }
        else
        {
            var temp =new ListNode(list2.val,null);
         current.next = temp;
             current = temp;
             list2=list2.next;
        }
 
        }


 

    return result;




    }
}