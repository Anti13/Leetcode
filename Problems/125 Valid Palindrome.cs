public class Solution {
    public bool IsPalindrome(string s) {

        var len = s.Length;
        var left = 0;
        var right = len-1;

        while(true)
        {
            if(left >= right) return true;

            while(true)
            {
                if(!char.IsLetterOrDigit(s[left])){
                    left++;

                    if(left >= right) return true;
                }
                else{
                    break;
                }
                
            }

                        while(true)
            {
                if(!char.IsLetterOrDigit(s[right])){
                    right--;

                    if(left >= right) return true;
                }
                else{
                    break;
                }
            }

            if(!(char.ToLower(s[left]) == char.ToLower(s[right])))
            return false;

            left++;
            right --;

        }

        return true;

    }
}