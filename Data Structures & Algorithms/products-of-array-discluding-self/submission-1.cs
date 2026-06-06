public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int leftProd = 1;
        int n = nums.Length;
        int[] res = new int[n];
        for(int i = 0; i < n; i++)
        {
            if(i != 0)
            {
                leftProd *= nums[i - 1];
            }
            int rightProd = 1;
            for(int j = i + 1; j < n; j++)
            {
                rightProd *= nums[j];
            }
            res[i] = leftProd * rightProd;
        }
        return res;
    }
}
