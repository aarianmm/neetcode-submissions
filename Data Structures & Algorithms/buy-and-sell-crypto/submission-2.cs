public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int profit = 0;
        for(int sell=0; sell<prices.Length; sell++){
            buy = prices[sell]<prices[buy] ? sell : buy;
            profit = Math.Max(profit, prices[sell] - prices[buy]);
        }
        return profit;
    }
}
