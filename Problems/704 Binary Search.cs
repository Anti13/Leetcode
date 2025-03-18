public class Solution {
    public int Search(int[] nums, int target) {
        
        int left =0;
        int right = nums.Length-1;

        while(true)
        { 
            if(left > right)
            return -1;

            int pivot = left + (right-left)/2;

            if(nums[pivot] == target)
            return pivot;

            if(nums[pivot] > target)
            {
                right = pivot-1;
            }
            else
            {
                left = pivot+1;
            }
        }

        return -1;
    }
}