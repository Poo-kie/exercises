using Studies.Arrays;
using Xunit;

namespace Studies.Tests.Arrays
{
    public class MaxProfitTests
    {
        [Fact]
        public void MaxProfit_ShouldReturnMaximumProfitWithStaggeredPrices()
        {
            var arr = new int[] { 7, 1, 5, 3, 6, 4 };

            var maxProfit = MaxProfitExercises.MaxProfit(arr);

            Assert.Equal(7, maxProfit);
        }

        [Fact]
        public void MaxProfit_ShouldReturnMaximumProfitWithIncreasingPrices()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            var maxProfit = MaxProfitExercises.MaxProfit(arr);

            Assert.Equal(5, maxProfit);
        }

        [Fact]
        public void MaxProfit_ShouldReturnZeroWithDecreasingPrices()
        {
            var arr = new int[] { 6, 5, 4, 3, 2, 1 };

            var maxProfit = MaxProfitExercises.MaxProfit(arr);

            Assert.Equal(0, maxProfit);
        }

        // MaxProfit2

        [Fact]
        public void MaxProfit2_ShouldReturnMaximumProfitWithStaggeredPrices()
        {
            var arr = new int[] { 7, 1, 5, 3, 6, 4 };

            var maxProfit = MaxProfitExercises.MaxProfit2(arr);

            Assert.Equal(7, maxProfit);
        }

        [Fact]
        public void MaxProfit2_ShouldReturnMaximumProfitWithIncreasingPrices()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            var maxProfit = MaxProfitExercises.MaxProfit2(arr);

            Assert.Equal(5, maxProfit);
        }

        [Fact]
        public void MaxProfit2_ShouldReturnZeroWithDecreasingPrices()
        {
            var arr = new int[] { 6, 5, 4, 3, 2, 1 };

            var maxProfit = MaxProfitExercises.MaxProfit2(arr);

            Assert.Equal(0, maxProfit);
        }
    }
}