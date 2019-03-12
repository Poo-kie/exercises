using System;
using System.Collections;
using System.Collections.Generic;

namespace Studies.Arrays
{
    public static class RotateExercises 
    {
        /// <summary>
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        /// </summary>
        /// <param name="nums">An array of numbers</param>
        /// <param name="k">The number of slots to rotate each number</param>
        public static void Rotate(int[] nums, int k) 
        {
            Rotate(nums, GetShift(nums, k), GetShiftGroups(nums, k), 0);
        }
        
        private static void Rotate(int[] nums, int shift, int totalGroups, int groupsRotated) 
        {
            RotateGroup(nums, shift, groupsRotated);

            if (++groupsRotated == totalGroups) return;

            Rotate(nums, shift, totalGroups, groupsRotated);
        }

        private static void RotateGroup(int[] nums, int shift, int idx)
        {
            var q = new Queue<int>(2);
            q.Enqueue(nums[idx]);

            var j = idx;

            do 
            {
                j = GetShift(nums, j + shift);
                q.Enqueue(nums[j]);
                nums[j] = q.Dequeue();
            } while (j != idx);
        }

        /// <summary>
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        /// </summary>
        /// <param name="nums">An array of numbers</param>
        /// <param name="k">The number of slots to rotate each number</param>
        public static void Rotate2(int[] nums, int k)
        {
            Rotate(nums, GetShift(nums, k), GetShiftGroups(nums, k), 0);
        }

        private static void Rotate2(int[] nums, int shift, int totalGroups, int groupsRotated)
        {
            RotateGroup2(nums, nums[groupsRotated], shift, groupsRotated, 0);

            if (++groupsRotated == totalGroups) return;

            Rotate(nums, shift, totalGroups, groupsRotated);
        }

        private static void RotateGroup2(int[] nums, int prev, int shift, int idx, int acc)
        {
            var j = GetShift(nums, idx + shift);

            var tmp = nums[j];
            nums[j] = prev;
            
            if (acc == j) return;

            RotateGroup2(nums, tmp, shift, idx, ++acc);
        }

        private static int GetShift(int[] nums, int rotateLength)
        {
            return rotateLength % nums.Length;
        }

        private static int GetShiftGroups(int[] nums, int rotateLength)
        {
            return Gcd(nums.Length, GetShift(nums, rotateLength));
        }

        private static int Gcd(int p, int q) 
        {
            if (p <= q) throw new InvalidOperationException("p must be greater than q to calculate GCD");
            if (q == 0) return p;

            return Gcd(q, p % q);
        }
    }
}