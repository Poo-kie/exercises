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

    /**
     * 
     * @param {Array} prices - Prices of various stocks indexed by day
     * @summary https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
     * 
     * @returns The max profit derived from buying and selling stock from {prices}
     */
    static maxProfit2(prices) {
        return this.maxProfitRecursion(prices, 0, 0);
    }

    static maxProfitRecursion(prices, idx, maxProfit) {
        let purchase = this.findPurchaseIndex(prices, idx);

        if (!purchase.found) return maxProfit;

        let sell = this.findSellIndex(prices, idx + 1);
        maxProfit += prices[sell.index] - prices[purchase.index];

        return this.maxProfitRecursion(prices, sell.index + 1, maxProfit);
    }

    static findPurchaseIndex(prices, idx) {
        if (idx >= (prices.length - 1)) return new FindResult(false, -1);

        if ((prices[idx + 1] - prices[idx]) > 0) return new FindResult(true, idx);

        return this.findPurchaseIndex(prices, ++idx);
    }

    static findSellIndex(prices, idx) {
        if (idx >= (prices.length - 1) || (prices[idx] - prices[idx + 1]) > 0) return new FindResult(true, idx);

        return this.findSellIndex(prices, ++idx);
    }
}

class FindResult {
    constructor(found, idx) {
        this.found = found;
        this.index = idx;
    }       
}

module.exports = MaxProfitExercises;