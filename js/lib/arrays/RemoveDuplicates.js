class RemoveDuplicates {
    
    /**
     * 
     * @param {Array} ints - a sorted set of numbers to remove duplicates from
     * @summary https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
     * 
     * @returns new length of array after duplicates have been removed
     */
    static removeDuplicatesFromSortedInts(ints) {        
        for (let i = 1; i < ints.length; i ++) {
            if (ints[i] == ints[i-1]) {
                ints.splice(i, 1);
                i--;
            }
        }

        return ints.length;
    }

    /**
     * Recursive version
     * @param {Array} ints - a sorted set of numbers to remove duplicates from
     * @summary https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
     * 
     * @returns new length of array after duplicates have been removed
     */
    static removeDuplicatesFromSortedInts2(ints) {        
        return this.removeDuplicatesFromSortedIntsRecursion(ints, 0);
    }

    static removeDuplicatesFromSortedIntsRecursion(ints, idx) {
        if (idx >= ints.length) return ints.length;

        if (ints[idx] == ints[idx-1]) {
            ints.splice(idx, 1);
            idx--;
        }

        return this.removeDuplicatesFromSortedIntsRecursion(ints, ++idx);
    }
}

module.exports = RemoveDuplicates;