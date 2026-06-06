public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> myHash = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) 
        {
            if(myHash.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                myHash.Add(nums[i]);
            }
        }
        return false;
    }
}
