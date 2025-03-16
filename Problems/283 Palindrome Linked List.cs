
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
    public bool IsPalindrome(ListNode head) {
        if(head == null)
        return false;
        var sb = new StringBuilder();

        while(true)
        {
            if(head == null)
            break;

            sb.Append((head.val).ToString());

            head = head.next;
        }

        return IsPalindrome(sb.ToString()) ;

    }

    private bool IsPalindrome(string s)
    {
        if(string.IsNullOrEmpty(s))
        return false;

        var len = s.Length;

        if(len<1)
        return false;

        var left = 0;
        var right = len-1;


        while(true)
        {
            if(left ==right || left > right)
            {
                return true;
            }

            if(s[left] != s[right])
            return false;

            left++;
            right--;
        }

        return false;
    }
}