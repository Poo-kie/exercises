class ReverseStringExercises {

    /**
     * reverses the array of characters with O(1) space
     * @param {Array} s an array of characters
     */
    static reverseString(s) {
        let li = s.length - 1;

        for (let i = 0; i < Math.floor(s.length / 2); i++) {
            let tmp = s[i];
            s[i] = s[li - i];
            s[li - i] = tmp;
        } 
    }

    /**
     * reverses the array of characters with O(1) space (recursive version)
     * @param {Array} s an array of characters
     */
    static reverseString2(s) {
        return this.reverseStringRecursion(s, 0, s[0]);
    }

    static reverseStringRecursion(s, idx, tmp) {
        s[idx] = s[(s.length - 1) - idx];
        s[(s.length - 1) - idx] = tmp;
        
        if (idx === Math.floor(s.length / 2)) return;

        return this.reverseStringRecursion(s, ++idx, s[idx]);
    }
}

module.exports = ReverseStringExercises;