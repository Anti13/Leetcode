public class Solution {
    public bool IsAnagram(string s, string t) {

        int slen = s.Length;
        int tlen = t.Length;

        if(tlen !=slen)
        return false;

        var dic = new Dictionary<char, int>();

        for (int i=0;i<slen;i++)
        {
            if(dic.ContainsKey(s[i]))
            {
                dic[s[i]]++;
            }
            else
            {
                dic[s[i]] = 1;
            }
        }

                for (int i=0;i<tlen;i++)
        {
            if(!dic.ContainsKey(t[i]))
            {
                return false;
            }
            else
            {

                dic[t[i]]--;

                if(dic[t[i]] <0)
                return false;
            }
        }

        return true;

    }
}