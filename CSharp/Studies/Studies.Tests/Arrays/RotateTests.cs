using Studies.Arrays;
using Xunit;

namespace Studies.Tests.Arrays
{
    public class RotateTests
    {
        [Fact]
        public void Rotate_ShouldRotateKTimesWhenArrayLengthIsMoreThanKAndPrime()
        {
            var arr = new [] {1,2,3,4,5,6,7};

            RotateExercises.Rotate(arr, 3);
            Assert.Equal(new [] {5,6,7,1,2,3,4}, arr);
        }

        [Fact]
        public void Rotate_ShouldRotateKTimesWhenArrayLengthIsLessThanKAndPrime()
        {
            var arr = new [] {1,2,3,4,5,6,7};

            RotateExercises.Rotate(arr, 13);
            Assert.Equal(new [] {2,3,4,5,6,7,1}, arr);
        }

        [Fact]
        public void Rotate_ShouldNotRotateWhenKIsZero()
        {
            var arr = new [] {1,2,3,4,5,6,7};

            RotateExercises.Rotate(arr, 0);
            Assert.Equal(new [] {1,2,3,4,5,6,7}, arr);
        }

        [Fact]
        public void Rotate_ShouldNotRotateWhenKIsOne()
        {
            var arr = new [] {1,2,3,4,5,6,7};

            RotateExercises.Rotate(arr, 1);
            Assert.Equal(new [] {7,1,2,3,4,5,6}, arr);
        }

        [Fact]
        public void Rotate_ShouldRotateKTimesWhenArrayLengthIsMoreThanKAndEven()
        {
            var arr = new [] {1,2,3,4,5,6};

            RotateExercises.Rotate(arr, 2);
            Assert.Equal(new [] {5,6,1,2,3,4}, arr);
        }

        [Fact]
        public void Rotate_ShouldRotateKTimesWhenArrayLengthIsLessThanKAndEven()
        {
            var arr = new [] {1,2,3,4,5,6};

            RotateExercises.Rotate(arr, 10);
            Assert.Equal(new [] {3,4,5,6,1,2}, arr);
        }

        [Fact]
        public void Rotate_ShouldRotateKTimesWhenArrayLengthIsDivisibleByK()
        {
            var arr = new [] {1,2,3,4,5,6,7,8,9};

            RotateExercises.Rotate(arr, 3);
            Assert.Equal(new [] {7,8,9,1,2,3,4,5,6}, arr);
        }

        [Fact]
        public void Rotate_ShouldRotateKTimesWhenArrayLengthHasCommonFactorWithK()
        {
            var arr = new [] {1,2,3,4,5,6,7,8,9};

            RotateExercises.Rotate(arr, 15);
            Assert.Equal(new [] {4,5,6,7,8,9,1,2,3}, arr);
        }

        // Rotate2

        [Fact]
        public void Rotate2_ShouldRotateKTimesWhenArrayLengthIsMoreThanKAndPrime()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };

            RotateExercises.Rotate2(arr, 3);
            Assert.Equal(new[] { 5, 6, 7, 1, 2, 3, 4 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldRotateKTimesWhenArrayLengthIsLessThanKAndPrime()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };

            RotateExercises.Rotate2(arr, 13);
            Assert.Equal(new[] { 2, 3, 4, 5, 6, 7, 1 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldNotRotateWhenKIsZero()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };

            RotateExercises.Rotate2(arr, 0);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldNotRotateWhenKIsOne()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };

            RotateExercises.Rotate2(arr, 1);
            Assert.Equal(new[] { 7, 1, 2, 3, 4, 5, 6 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldRotateKTimesWhenArrayLengthIsMoreThanKAndEven()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6 };

            RotateExercises.Rotate2(arr, 2);
            Assert.Equal(new[] { 5, 6, 1, 2, 3, 4 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldRotateKTimesWhenArrayLengthIsLessThanKAndEven()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6 };

            RotateExercises.Rotate2(arr, 10);
            Assert.Equal(new[] { 3, 4, 5, 6, 1, 2 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldRotateKTimesWhenArrayLengthIsDivisibleByK()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            RotateExercises.Rotate2(arr, 3);
            Assert.Equal(new[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 }, arr);
        }

        [Fact]
        public void Rotate2_ShouldRotateKTimesWhenArrayLengthHasCommonFactorWithK()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            RotateExercises.Rotate2(arr, 15);
            Assert.Equal(new[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 }, arr);
        }
    }
}