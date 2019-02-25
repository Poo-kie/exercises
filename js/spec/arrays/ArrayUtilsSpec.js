describe("ArrayUtils", () => {
    var ArrayUtils = require("../../lib/arrays/ArrayUtils");
    
    it("should remove duplicates from given array", () => {
        var arr = [1,2,2,2,2,2,3,3,4]
        ArrayUtils.removeDuplicatesFromSortedInts(arr);
        expect(arr).toEqual([1,2,3,4]);
    });

    it("should return new length of array", () => {
        var arr = [1,2,2,2,2,2,3,3,4]
        let length = ArrayUtils.removeDuplicatesFromSortedInts(arr);
        expect(length).toEqual(4);
    });

    it("should handle empty array", () => {
        var arr = []
        let length = ArrayUtils.removeDuplicatesFromSortedInts(arr);
        expect(length).toEqual(0);
    });

    it("should handle single element array", () => {
        var arr = [100]
        let length = ArrayUtils.removeDuplicatesFromSortedInts(arr);
        expect(length).toEqual(1);
    });
});