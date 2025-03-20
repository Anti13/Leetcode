
public class Solution {
    public void MoveZeroes(int[] nums) {
        int len = nums.Length;

        int firstZero =-1;
        int firstNonZero =-1;



        while(true)
        {
                    firstZero=FindNext(firstZero, nums, len, true);
        firstNonZero=FindNext(firstZero, nums, len, false);

           if(firstNonZero == len || firstZero == len)
           {
            return;
           }

           var temp = nums[firstZero];
            nums[firstZero] =  nums[firstNonZero];
            nums[firstNonZero] = temp;


        }
        
    }

    private int FindNext(int index, int[] nums ,int len, bool wantZero)
    {        
        while(true)
        {
                        index++;

            if(index > len-1)
            {
                return index;
            }

            if(wantZero && nums[index] ==0)
            {
                return index;
            }
            else  if(!wantZero && nums[index] !=0)
            {
                return index;
            }
        }
    }
}