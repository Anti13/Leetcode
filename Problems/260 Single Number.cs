public class Solution {
    public int[] SingleNumber(int[] nums) {
    int xor = 0;
    int a =0;
    int b=0;

    //xor contains a xor b effectively
    for(int i=0;i<nums.Length;i++)
    {
        xor ^= nums[i];
   }


    //find single 1 bit in this xor
    //we know in this but onlyu either a or b has bit set
    int diff_bit = 1;

    while(true)
    {
        if((xor & diff_bit) != 0)
        break;

        diff_bit <<= 1;
    }

        for(int i=0;i<nums.Length;i++)
    {
        //if a given number has this bit set, it goes into the first group
        if((nums[i] & diff_bit) == 0)
        {
            a ^= nums[i];
        }
        else
        {
            //otherwise it gous into the second group
            b ^= nums[i];
        }
   }


    //a and b always end up on different groups
    return new int[]{a,b};


}
}