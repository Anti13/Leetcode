public class Solution {
    public int MaxProfit(int[] p) {
        
        int result = 0;
        int len = p.Length;      
        if(len ==1)
        return 0;

         int currentMin = p[0];

         for(int i=1;i<len;i++)
         {
            if (p[i] < currentMin)
            {
                currentMin=p[i];
                continue;
            }
            if(p[i]-currentMin > result)
            {
                result = p[i]-currentMin;
            }

         }

        return result;

    }
}