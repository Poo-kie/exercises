const Queue = require("../data_structures/Queue");

class Rotate {
    
    /**
     * Rotates an array by k with O(1) space
     * https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
     * @param {Array} nums An array of numbers
     * @param {rotate} k The number of slots to rotate each number
     */
    static rotate(nums, k, acc = 0) {
        this._rotate(nums, this._getShift(nums, k), acc);
        
        if (++acc === this._getTotalShiftGroups(nums, k)) return;

        this.rotate(nums, k, acc);
    }

    static _rotate(nums, shift, i) {
        let q = new Queue();
        q.enqueue(nums[i]);

        let j = i;

        do {
            j = this._getShift(nums, j + shift);
            q.enqueue(nums[j]);
            nums[j] = q.dequeue();
        }
        while (j !== i);
    }

    /**
     * Rotates an array by k with O(1) space and uses recursion (tail-recursive functions only so they'll be optimized)
     * https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
     * @param {Array} nums An array of numbers
     * @param {rotate} k The number of slots to rotate each number
     */
    static rotate2(nums, k, acc = 0) {
        let rotations = this._innerRotate(nums, nums[acc], this._getShift(nums, k), acc);
        
        if (++acc === this._getTotalShiftGroups(nums, k)) return;

        this.rotate2(nums, k, acc);
    }

    static _innerRotate(nums, prev, shift, idx, start = undefined) {
        if (start === undefined) start = idx;

        let j = this._getShift(nums, idx + shift);
        let tmp = nums[j];
        nums[j] = prev;
        
        if (j === start) return;

        this._innerRotate(nums, tmp, shift, j, start);
    }

    static _getShift(arr, rotateLength) {
        return rotateLength % arr.length;
    }

    static _getTotalShiftGroups(arr, rotateLength) {
        return this._gcd(arr.length, this._getShift(arr, rotateLength));
    }

    static _gcd(p, q) {
        if (p < q) throw new Error("p must be greater than q");
        if (q === 0) return p;
        
        return this._gcd(q, p % q);
    };
}

module.exports = Rotate;