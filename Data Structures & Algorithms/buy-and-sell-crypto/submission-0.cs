public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int n = prices.Length;
        int ptr1 = 0;
        int ptr2 = 0;
        while (ptr1 < n && ptr2 < n)
        {
            int dif = prices[ptr2] - prices[ptr1];
            max = int.Max(max, dif);
            if(prices[ptr2] < prices[ptr1])
            {
                ptr1 = ptr2;
            }
                ptr2++;
        }
        return max;
    }
}
