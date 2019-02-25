class ArrayUtils {
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

module.exports = ArrayUtils;