describe("ArrayUtils", () => {
    var ArrayUtils = require("../../lib/arrays/ArrayUtils");
    
    describe("removeDuplicatesFromSortedInts", () => {
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

    describe("maxProfit", () => {    
        it("should return zero for decreasing prices", () => {
            var arr = [6, 5, 4, 3, 2, 1];
            var maxProfit = ArrayUtils.maxProfit(arr);
            expect(maxProfit).toEqual(0);
        });

        it("should return (arr[length] - arr[0]) for increasing prices", () => {
            var arr = [1, 2, 3, 4, 5, 6];
            var maxProfit = ArrayUtils.maxProfit(arr);
            expect(maxProfit).toEqual(5);
        });

        it("should return correct max profit for staggered prices", () => {
            var arr = [7, 1, 5, 3, 6, 4];
            var maxProfit = ArrayUtils.maxProfit(arr);
            expect(maxProfit).toEqual(7);
        });
    });

    describe("rotate", () => {
        it("should rotate when k is less than array length", () => {
            var arr = [1,2,3,4,5,6,7];
            ArrayUtils.rotate(arr, 3);
            expect(arr).toEqual([5,6,7,1,2,3,4]);
        });

        it("should rotate when k is greater than array length", () => {
            var arr = [1,2,3,4,5,6,7];
            ArrayUtils.rotate(arr, 13);
            expect(arr).toEqual([2,3,4,5,6,7,1]);
        });

        it("should not rotate when k is zero", () => {
            var arr = [1,2,3,4,5,6,7];
            ArrayUtils.rotate(arr, 0);
            expect(arr).toEqual([1,2,3,4,5,6,7]);
        });
    });
});