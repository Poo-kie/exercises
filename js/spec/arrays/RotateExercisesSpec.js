describe("RotateExercises", () => {
    let RotateExercises = require("../../lib/arrays/RotateExercises");

    describe("rotate", () => {
        it("should rotate when k is less than array length and arr.length is prime", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate(arr, 3);
            expect(arr).toEqual([5,6,7,1,2,3,4]);
        });

        it("should rotate when k is greater than array length and arr.length is prime", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate(arr, 13);
            expect(arr).toEqual([2,3,4,5,6,7,1]);
        });

        it("should not rotate when k is zero", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate(arr, 0);
            expect(arr).toEqual([1,2,3,4,5,6,7]);
        });

        it("should rotate when k is one", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate(arr, 1);
            expect(arr).toEqual([7,1,2,3,4,5,6]);
        });

        it("should rotate when k is less than array length and arr.length is even", () => {
            var arr = [1,2,3,4,5,6];
            RotateExercises.rotate(arr, 2);
            expect(arr).toEqual([5,6,1,2,3,4]);
        });

        it("should rotate when k is greater than array length and arr.length is even", () => {
            var arr = [1,2,3,4,5,6];
            RotateExercises.rotate(arr, 4);
            expect(arr).toEqual([3,4,5,6,1,2]);
        });

        it("should rotate when k is less than array length and arr.length is odd and divisible by k", () => {
            var arr = [1,2,3,4,5,6,7,8,9];
            RotateExercises.rotate(arr, 3);
            expect(arr).toEqual([7,8,9,1,2,3,4,5,6]);
        });

        it("should rotate when k is less than array length and arr.length is odd and has common factor with k", () => {
            var arr = [1,2,3,4,5,6,7,8,9];
            RotateExercises.rotate(arr, 6);
            expect(arr).toEqual([4,5,6,7,8,9,1,2,3]);
        });
    });

    describe("rotate2", () => {
        it("should rotate when k is less than array length and arr.length is prime", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate2(arr, 3);
            expect(arr).toEqual([5,6,7,1,2,3,4]);
        });

        it("should rotate when k is greater than array length and arr.length is prime", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate2(arr, 13);
            expect(arr).toEqual([2,3,4,5,6,7,1]);
        });

        it("should not rotate when k is zero", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate2(arr, 0);
            expect(arr).toEqual([1,2,3,4,5,6,7]);
        });

        it("should rotate when k is one", () => {
            var arr = [1,2,3,4,5,6,7];
            RotateExercises.rotate2(arr, 1);
            expect(arr).toEqual([7,1,2,3,4,5,6]);
        });

        it("should rotate when k is less than array length and arr.length is even", () => {
            var arr = [1,2,3,4,5,6];
            RotateExercises.rotate2(arr, 2);
            expect(arr).toEqual([5,6,1,2,3,4]);
        });

        it("should rotate when k is greater than array length and arr.length is even", () => {
            var arr = [1,2,3,4,5,6];
            RotateExercises.rotate2(arr, 4);
            expect(arr).toEqual([3,4,5,6,1,2]);
        });

        it("should rotate when k is less than array length and arr.length is odd and divisible by k", () => {
            var arr = [1,2,3,4,5,6,7,8,9];
            RotateExercises.rotate2(arr, 3);
            expect(arr).toEqual([7,8,9,1,2,3,4,5,6]);
        });

        it("should rotate when k is less than array length and arr.length is odd and has common factor with k", () => {
            var arr = [1,2,3,4,5,6,7,8,9];
            RotateExercises.rotate2(arr, 6);
            expect(arr).toEqual([4,5,6,7,8,9,1,2,3]);
        });
    });
});