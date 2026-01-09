class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int minPrice = prices[0];
        int bestProfit = 0;

        for(int p : prices){
            minPrice = min(minPrice,p);
            bestProfit = max(bestProfit,p-minPrice);
        }
        return bestProfit;
    }
};