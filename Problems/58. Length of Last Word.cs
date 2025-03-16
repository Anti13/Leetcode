public class Solution {
    public int LengthOfLastWord(string s) {
        
        bool letterAlready = false;
        int len = s.Length ;
        int counter = 0;

        for(int i=len-1;i>=0;i--)
        {
            if(!char.IsLetter(s[i]) && !letterAlready)
            {
                continue;
            }
            if(char.IsLetter(s[i]))
            {
                letterAlready = true;
                counter ++;
            }
            else{
                break;
            }
        }
    return counter;
    }
}