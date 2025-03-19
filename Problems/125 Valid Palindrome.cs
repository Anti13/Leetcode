public class Solution {
    public bool IsPalindrome(string text) {

        var sb =new StringBuilder();

        foreach (var c in text)
        {
            if(char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }

        var s = sb.ToString();
        var len = s.Length;

        if(len == 1) return true;
        if(len == 2) return s[0] == s[1];

        var left = 0;
        var right = len -1;

        while (true)
        {
            if(left >= right)
            {
                break;
            }

            if(s[left] !=s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}