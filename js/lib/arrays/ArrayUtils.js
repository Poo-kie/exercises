class ArrayUtils {
    /**
     * 
     * @param {Array} ints - a sorted set of numbers to remove duplicates from
     * @summary https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
     * 
     * @returns new length of array after duplicates have been removed
     */
    static removeDuplicatesFromSortedInts(ints) {        
        for (let i = 1; i < ints.length; i ++) {
            if (ints[i] == ints[i-1]) {
                ints.splice(i, 1);
                i--;
            }
        }

        return ints.length;
    }

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

module.exports = ArrayUtils;