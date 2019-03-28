using System;

namespace Studies.Strings
{
    public static class ReverseStringExercises
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/
        /// reverses the array of characters with O(1) space
        /// </summary>
        /// <param name="str"></param>
        public static void ReverseString(char[] str)
        {
            var len = str.Length - 1;

            for (var i = 0; i < Math.Floor((double)str.Length / 2); i++)
            {
                var tmp = str[i];
                str[i] = str[len - i];
                str[len - i] = tmp;
            }
        }

        /// <summary>
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/
        /// reverses the array of characters with O(1) space (recursive version)
        /// </summary>
        /// <param name="str"></param>
        public static void ReverseString2(char[] str)
        {
            ReverseStringRecursion(str, 0, str[0]);
        }

        private static void ReverseStringRecursion(char[] str, int idx, char tmp)
        {
            str[idx] = str[str.Length - 1 - idx];
            str[str.Length - 1 - idx] = tmp;

            if (idx == Math.Floor((double)str.Length / 2)) return;

            ReverseStringRecursion(str, ++idx, str[idx]);
        }
    }
}
