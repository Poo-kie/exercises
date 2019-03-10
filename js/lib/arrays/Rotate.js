const Queue = require("../data_structures/Queue");

class Rotate {
    
    /**
     * Rotates an array by k with O(1) space
     * https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
     * @param {Array} nums An array of numbers
     * @param {rotate} k The number of slots to rotate each number
     */
    static rotate(nums, k, rotateAcc = 0) {
        let rotations = this._rotate(nums, k % nums.length, rotateAcc);
        
        if (++rotateAcc === nums.length / rotations) return;

        this.rotate(nums, k, rotateAcc);
    }

    static _rotate(nums, shift, i) {
        let q = new Queue();
        q.enqueue(nums[i]);

        let j = i;
        let shiftAcc = 0;

        do {
            shiftAcc++;
            j = (j + shift) % nums.length;
            q.enqueue(nums[j]);
            nums[j] = q.dequeue();
        }
        while (j !== i);

        return shiftAcc;
    }

    /**
     * Rotates an array by k with O(1) space and uses recursion (tail-recursive functions only so they'll be optimized)
     * https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
     * @param {Array} nums An array of numbers
     * @param {rotate} k The number of slots to rotate each number
     */
    static rotate2(nums, k, rotateAcc = 0) {
        let rotations = this._innerRotate(nums, nums[rotateAcc], k % nums.length, rotateAcc);
        
        if (++rotateAcc === nums.length / rotations) return;

        this.rotate2(nums, k, rotateAcc);
    }

    static _innerRotate(nums, prev, shift, idx, start = undefined, shiftAcc = 0) {
        if (start === undefined) start = idx;

        let j = (idx + shift) % nums.length;
        let tmp = nums[j];
        
        shiftAcc++;
        nums[j] = prev;
        
        if (j === start) return shiftAcc;

        return this._innerRotate(nums, tmp, shift, j, start, shiftAcc);
    }
}

module.exports = Rotate;