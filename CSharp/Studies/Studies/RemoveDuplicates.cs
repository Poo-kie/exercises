using System;

namespace Studies
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
    }   
}