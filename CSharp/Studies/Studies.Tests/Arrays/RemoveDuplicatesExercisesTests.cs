using Studies.Arrays;
using Xunit;

namespace Studies.Tests.Arrays
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void RemoveDuplicatesFromSortedInts_ShouldRemoveDuplicatesAndReturnNewArrLength()
        {
            var arr = new[] { 0, 1, 2, 2, 2, 2, 5, 5, 5, 100 };
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts(ref arr);

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
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts(ref arr);

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
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts(ref arr);

            Assert.Single(arr);
            Assert.Equal(1, length);

            Assert.Equal(0, arr[0]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts_ShouldHandleEmptyArrayWithoutErrors()
        {
            var arr = new int[0];
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts(ref arr);

            Assert.Empty(arr);
            Assert.Equal(0, length);
        }

        // 2

        [Fact]
        public void RemoveDuplicatesFromSortedInts2_ShouldRemoveDuplicatesAndReturnNewArrLength()
        {
            var arr = new[] { 0, 1, 2, 2, 2, 2, 5, 5, 5, 100 };
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts2(ref arr);

            Assert.Equal(5, arr.Length);
            Assert.Equal(5, length);

            Assert.Equal(0, arr[0]);
            Assert.Equal(1, arr[1]);
            Assert.Equal(2, arr[2]);
            Assert.Equal(5, arr[3]);
            Assert.Equal(100, arr[4]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts2_ShouldNotRemoveNonDuplicates()
        {
            var arr = new[] { 0, 1, 2, 3 };
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts2(ref arr);

            Assert.Equal(4, arr.Length);
            Assert.Equal(4, length);

            Assert.Equal(0, arr[0]);
            Assert.Equal(1, arr[1]);
            Assert.Equal(2, arr[2]);
            Assert.Equal(3, arr[3]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts2_ShouldReturnSingleArrayElement()
        {
            var arr = new[] { 0 };
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts2(ref arr);

            Assert.Single(arr);
            Assert.Equal(1, length);

            Assert.Equal(0, arr[0]);
        }

        [Fact]
        public void RemoveDuplicatesFromSortedInts2_ShouldHandleEmptyArrayWithoutErrors()
        {
            var arr = new int[0];
            var length = RemoveDuplicatesExercises.RemoveDuplicatesFromSortedInts2(ref arr);

            Assert.Empty(arr);
            Assert.Equal(0, length);
        }
    }
}
