public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = [];
        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map.Add(nums[i],1);
            }
        }
        var temp = map.OrderByDescending(x=>x.Value);
        int[] res = new int[k];
        int count = 0;
        foreach(var kvp in temp)
        {
            if(count > k -1)
                break;

            res[count] = kvp.Key;
            count++;
        }
        return res;

    }
}
