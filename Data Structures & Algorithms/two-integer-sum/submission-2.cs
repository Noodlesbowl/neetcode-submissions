public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = [];
        for(int i = 0; i < nums.Length; i++)
        {
            int dif = target - nums[i];
            if(map.ContainsKey(dif))
            {
                return [map[dif], i];
            }
            else
            {
                map.Add(nums[i], i);
            }
        }
        return [];
    }
}
