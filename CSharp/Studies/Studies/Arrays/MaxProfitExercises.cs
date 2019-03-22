using System;

namespace Studies.Arrays
{
    public static class MaxProfitExercises
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
        /// </summary>
        /// <param name="prices">Prices of various stocks indexed by day</param>
        /// <returns>The max profit derived from buying and selling stock from <paramref name="prices"/></returns>
        public static int MaxProfit(int[] prices)
        {
            // for an array [a, b, c, d]
            // (b - a) + (d - c) > (d - a)
            // only when b > c

            var buying = false;
            var profit = 0;
            var purchased = 0;
            var maxProfit = 0;

            for (var i = 0; i < prices.Length - 1; i++)
            {
                var potentialProfit = prices[i + 1] - prices[i];

                if (potentialProfit > 0)
                {
                    purchased = buying ? purchased : prices[i];
                    profit = prices[i + 1] - purchased;
                    buying = true;
                }
                else
                {
                    maxProfit += profit;
                    buying = false;
                }
            }

            if (buying) maxProfit += profit;

            return maxProfit;
        }

        /// <summary>
        /// A recursive version
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
        /// </summary>
        /// <param name="prices">Prices of various stocks indexed by day</param>
        /// <returns>The max profit derived from buying and selling stock from <paramref name="prices"/></returns>
        public static int MaxProfit2(int[] prices)
        {
            return MaxProfit2(prices, 0, 0);
        }

        private static int MaxProfit2(int[] prices, int nextIndex, int maxProfit)
        {
            var purchase = FindPurchaseIndex(prices, nextIndex);
            
            if (!purchase.Found)
            {
                return maxProfit;
            }
            
            var sell = FindSellIndex(prices, purchase.Index + 1);
            maxProfit += prices[sell.Index] - prices[purchase.Index];
                
            return MaxProfit2(prices, sell.Index + 1, maxProfit);
        }

        private static FindResult FindPurchaseIndex(int[] prices, int nextIndex) 
        {
            if ((nextIndex + 1) >= prices.Length)
            {
                return new FindResult
                {
                    Found = false,
                    Index = nextIndex
                };
            }

            if (prices[nextIndex + 1] > prices[nextIndex])
            {
                return new FindResult 
                {
                    Found = true,
                    Index = nextIndex
                };
            }

            nextIndex++;
            return FindPurchaseIndex(prices, nextIndex);
        }

        private static FindResult FindSellIndex(int[] prices, int nextIndex)
        {
            if ((nextIndex + 1) >= prices.Length || prices[nextIndex + 1] < prices[nextIndex])
            {
                return new FindResult
                {
                    Found = true,
                    Index = nextIndex
                };
            }

            nextIndex++;
            return FindSellIndex(prices, nextIndex);
        }

        private class FindResult
        {
            public bool Found { get; set; }

            public int Index { get; set; }
        }
    }
}