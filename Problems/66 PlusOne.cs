public class Solution {
    public int[] PlusOne(int[] d) {
        
        var len = d.Length;

        var allNines = true;

        for(int i =0;i<len;i++)
        {
            if(d[i] !=9)
            {
                allNines = false;

                break;
            }
        }

        if(allNines)
        {
            var result = new int[len+1];
            result[0] = 1;
            return result;
        }

        int counter = len-1;
        while(true)
        {
            var remainder = (d[counter] +1) % 10;
            d[counter] = remainder;

            if(remainder == 0)
            {
                counter--;
            }
            else {
                break;
            }
        }

        return d;

    }
}