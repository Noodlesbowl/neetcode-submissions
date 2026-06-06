public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> myStack = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (myStack.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                myStack.Add(nums[i]);
            }
        }
        return false;
    }
}