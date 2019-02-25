using Studies;
using Xunit;

namespace Tests
{
    public class ArrayUtilsTests
    {
        [Fact]
        public void RemoveDuplicatesFromSortedInts_ShouldRemoveDuplicatesAndReturnNewArrLength()
        {
            var arr = new[] { 0, 1, 2, 2, 2, 2, 5, 5, 5, 100 };
            var length = ArrayUtils.RemoveDuplicatesFromSortedInts(ref arr);

            Assert.Equal(5, arr.Length);
            Assert.Equal(5, length);

            Assert.Equal(0, arr[0]);
            Assert.Equal(1, arr[1]);
            Assert.Equal(2, arr[2]);
            Assert.Equal(5, arr[3]);
            Assert.Equal(100, arr[4]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts_ShouldNotRemoveNonDuplicates()
        {
            var arr = new[] { 0, 1, 2, 3 };
            var length = ArrayUtils.RemoveDuplicatesFromSortedInts(ref arr);

            Assert.Equal(4, arr.Length);
            Assert.Equal(4, length);

            Assert.Equal(0, arr[0]);
            Assert.Equal(1, arr[1]);
            Assert.Equal(2, arr[2]);
            Assert.Equal(3, arr[3]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts_ShouldReturnSingleArrayElement()
        {
            var arr = new[] { 0 };
            var length = ArrayUtils.RemoveDuplicatesFromSortedInts(ref arr);

            Assert.Single(arr);
            Assert.Equal(1, length);

            Assert.Equal(0, arr[0]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts_ShouldHandleEmptyArrayWithoutErrors()
        {
            var arr = new int[0];
            var length = ArrayUtils.RemoveDuplicatesFromSortedInts(ref arr);

            Assert.Empty(arr);
            Assert.Equal(0, length);
        }

        [Fact]
        public void MaxProfit_ShouldReturnMaximumProfitWithStaggeredPrices()
        {
            var arr = new int[] { 7, 1, 5, 3, 6, 4 };

            var maxProfit = ArrayUtils.MaxProfit(arr);

            Assert.Equal(7, maxProfit);
        }

        [Fact]
        public void MaxProfit_ShouldReturnMaximumProfitWithIncreasingPrices()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            var maxProfit = ArrayUtils.MaxProfit(arr);

            Assert.Equal(5, maxProfit);
        }

        [Fact]
        public void MaxProfit_ShouldReturnMaximumProfitWithDecreasingPrices()
        {
            var arr = new int[] { 6, 5, 4, 3, 2, 1 };

            var maxProfit = ArrayUtils.MaxProfit(arr);

            Assert.Equal(0, maxProfit);
        }
    }
}
