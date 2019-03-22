class MaxProfitExercises {
    
    /**
     * 
     * @param {Array} prices - Prices of various stocks indexed by day
     * @summary https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
     * 
     * @returns The max profit derived from buying and selling stock from {prices}
     */
    static maxProfit(prices) {
        if (prices === undefined || !Array.isArray(prices)) return 0;

        let buying = false;
        let profit = 0;
        let purchased = 0;
        let maxProfit = 0; 

        for(let i = 0; i < prices.length - 1; i++) {
            var potentialProfit = prices[i + 1] - prices[i];

            if (potentialProfit > 0) {
                purchased = buying ? purchased : prices[i];
                profit = prices[i + 1] - purchased;
                buying = true;
            } else {
                maxProfit += profit;
                buying = false;
            }
        }

        if (buying) maxProfit += profit;

        return maxProfit;
    }
}

module.exports = MaxProfitExercises;