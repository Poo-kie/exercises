describe("RemoveDuplicatesExercises", () => {
    let RemoveDuplicatesExercises = require("../../lib/arrays/RemoveDuplicatesExercises");

    describe("removeDuplicatesFromSortedInts", () => {
        it("should remove duplicates from given array", () => {
            var arr = [1,2,2,2,2,2,3,3,4]
            RemoveDuplicatesExercises.removeDuplicatesFromSortedInts(arr);
            expect(arr).toEqual([1,2,3,4]);
        });
    
        it("should return new length of array", () => {
            var arr = [1,2,2,2,2,2,3,3,4]
            let length = RemoveDuplicatesExercises.removeDuplicatesFromSortedInts(arr);
            expect(length).toEqual(4);
        });
    
        it("should handle empty array", () => {
            var arr = []
            let length = RemoveDuplicatesExercises.removeDuplicatesFromSortedInts(arr);
            expect(length).toEqual(0);
        });
    
        it("should handle single element array", () => {
            var arr = [100]
            let length = RemoveDuplicatesExercises.removeDuplicatesFromSortedInts(arr);
            expect(length).toEqual(1);
        });
    });

    describe("removeDuplicatesFromSortedInts2", () => {
        it("should remove duplicates from given array", () => {
            var arr = [1,2,2,2,2,2,3,3,4]
            RemoveDuplicatesExercises.removeDuplicatesFromSortedInts2(arr);
            expect(arr).toEqual([1,2,3,4]);
        });
    
        it("should return new length of array", () => {
            var arr = [1,2,2,2,2,2,3,3,4]
            let length = RemoveDuplicatesExercises.removeDuplicatesFromSortedInts2(arr);
            expect(length).toEqual(4);
        });
    
        it("should handle empty array", () => {
            var arr = []
            let length = RemoveDuplicatesExercises.removeDuplicatesFromSortedInts2(arr);
            expect(length).toEqual(0);
        });
    
        it("should handle single element array", () => {
            var arr = [100]
            let length = RemoveDuplicatesExercises.removeDuplicatesFromSortedInts2(arr);
            expect(length).toEqual(1);
        });
    });
});