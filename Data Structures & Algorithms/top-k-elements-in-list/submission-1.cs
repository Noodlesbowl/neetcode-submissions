public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        List<int> returnVal = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (!myDict.ContainsKey(nums[i]))
            {
                myDict.Add(nums[i], 0);
            }
            myDict[nums[i]]++;
        }
        var sortedDic = myDict.OrderByDescending(x => x.Value);
        int count = 0;
        foreach (var rep in sortedDic)
        {
            if (count == k)
                break;
            returnVal.Add(rep.Key);
            count++;
        }
        return returnVal.ToArray();
    }
}
