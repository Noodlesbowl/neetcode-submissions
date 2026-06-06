public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int find = target - nums[i];
            
            if(dic.ContainsKey(find))
            {
                return new int[]{dic[find], i};
            }
            if(!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = i;
            }
        }
        return new int[]{1, -1};
    }
}
