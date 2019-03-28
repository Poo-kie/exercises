using Studies.Strings;
using Xunit;

namespace Studies.Tests.Strings
{
    public class ReverseStringExercisesTests
    {
        [Fact]
        public static void ReverseString_ShouldReverseStringWhenStringLengthIsOdd()
        {
            var arr = new[] { 'h', 'e', 'l', 'l', 'o' };
            ReverseStringExercises.ReverseString(arr);

            Assert.Equal(new[] { 'o', 'l', 'l', 'e', 'h' }, arr);
        }

        [Fact]
        public static void ReverseString_ShouldReverseStringWhenStringLengthIsEven()
        {
            var arr = new[] { 'c', 'e', 'l', 'l', 'a', 'r' };
            ReverseStringExercises.ReverseString(arr);

            Assert.Equal(new[] { 'r', 'a', 'l', 'l', 'e', 'c' }, arr);
        }

        [Fact]
        public static void ReverseString2_ShouldReverseStringWhenStringLengthIsOdd()
        {
            var arr = new[] { 'h', 'e', 'l', 'l', 'o' };
            ReverseStringExercises.ReverseString2(arr);

            Assert.Equal(new[] { 'o', 'l', 'l', 'e', 'h' }, arr);
        }

        [Fact]
        public static void ReverseString2_ShouldReverseStringWhenStringLengthIsEven()
        {
            var arr = new[] { 'c', 'e', 'l', 'l', 'a', 'r' };
            ReverseStringExercises.ReverseString2(arr);

            Assert.Equal(new[] { 'r', 'a', 'l', 'l', 'e', 'c' }, arr);
        }
    }
}
