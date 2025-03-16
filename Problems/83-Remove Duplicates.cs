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
    public ListNode DeleteDuplicates(ListNode head) {
        
        if(head == null)
        {
            return head;
        }

        ListNode resultHead = null;

        ListNode lastAdded = null;


    var hash = new HashSet<int>();

var isFirst = true;
        while(true)
        {
            if(head == null)
            {break;}

            var value = head.val;
            if(hash.Contains(value))
            {

            }
            else
            {
                hash.Add(value);
                var temp = new ListNode(value, null);

                if(isFirst)
                {
                    lastAdded = temp;
                    resultHead = temp;
                    isFirst = false;
                }
                else
                {
                                    lastAdded.next = temp;
                lastAdded = temp;
                }

            }

            head = head.next;
            }
        return resultHead;
        }


    
}