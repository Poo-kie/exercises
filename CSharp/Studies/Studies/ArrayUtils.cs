using System;

namespace Studies
{
    public static class ArrayUtils
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
        /// </summary>
        /// <returns>The length of the resized array</returns>
        /// <param name="arr">an array of sorted ints.</param>
        public static int RemoveDuplicatesFromSortedInts(ref int[] arr)
        {
            var shiftCount = 0;
            var shiftedArrLength = arr.Length;

            for(var i = 1; i < shiftedArrLength; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    i--;
                    shiftCount++;
                    shiftedArrLength--;
                    Array.Copy(arr, i + 1, arr, i, arr.Length - (i + 1));
                }
            }

            Array.Resize(ref arr, shiftedArrLength);

            return arr.Length;
        }


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


    }
}
