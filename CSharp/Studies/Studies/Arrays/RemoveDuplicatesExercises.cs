using System;

namespace Studies.Arrays
{
    public static class RemoveDuplicatesExercises
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
        /// Recursive version
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
        /// </summary>
        /// <returns>The length of the resized array</returns>
        /// <param name="arr">an array of sorted ints.</param>
        public static int RemoveDuplicatesFromSortedInts2(ref int[] arr)
        {
            var newLength = RemoveDuplicatesFromSortedIntsRecursion(ref arr, 1, 0, arr.Length);

            if (arr.Length != newLength) Array.Resize(ref arr, newLength);

            return arr.Length;
        }
            
        private static int RemoveDuplicatesFromSortedIntsRecursion(ref int[] arr, int idx, int shiftCount, int shiftedArrLength)
        {
            if (idx >= shiftedArrLength) return shiftedArrLength;

            if (arr[idx] == arr[idx-1])
            {
                idx--;
                shiftCount++;
                shiftedArrLength--;
                Array.Copy(arr, idx + 1, arr, idx, arr.Length - (idx + 1));
            }

            return RemoveDuplicatesFromSortedIntsRecursion(ref arr, ++idx, shiftCount, shiftedArrLength);
        }
    }   
}