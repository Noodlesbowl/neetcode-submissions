public class Solution {
    public int[] TwoSum(int[] nums, int target) {
 List<int> collection = [];
 for(int i = 0; i < nums.Length; i++)
 {
     int temp = target - nums[i];
     if(collection.Contains(nums[i]))
     {
         return [collection.IndexOf(nums[i]), i];
     }
     else
     {
         collection.Add(temp);
     }
 }
 return [];
    }
}
