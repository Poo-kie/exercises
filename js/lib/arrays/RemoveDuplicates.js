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
}

module.exports = RemoveDuplicates;