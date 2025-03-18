
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int len = nums.Length;
        var map = new Dictionary<int,int>();

        for (int i=0;i<len;i++)
        {
            int difference = target - nums[i];
            if(map.ContainsKey(difference))
            {
                return new int[] {map[difference], i};
            }
            else
            {
                map[nums[i]] = i;
            }
        }
    return null;
    }
}