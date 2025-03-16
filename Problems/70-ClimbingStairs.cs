public class Solution {
    public int ClimbStairs(int number) {
        
        var n=new int[50];

        n[1] = 1;
        n[2] =2;
        for(int i=3;i<46;i++)
        {
            n[i] = n[i-2] + n[i-1];
        }

        return n[number];

    }
}