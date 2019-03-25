describe("ReverseStringExercises", () => {
    let ReverseStringExercises = require("../../lib/strings/ReverseStringExercises");

    describe("reverseString", () => {    
        it("should reverse string when string length is odd", () => {
            var arr = ["h", "e", "l", "l", "o"];
            ReverseStringExercises.reverseString(arr);
            expect(arr).toEqual(["o", "l", "l", "e", "h"]);
        });

        it("should reverse string when string length is even", () => {
            var arr = ["c", "e", "l", "l", "a", "r"];
            ReverseStringExercises.reverseString(arr);
            expect(arr).toEqual(["r", "a", "l", "l", "e", "c"]);
        });
    });

    describe("reverseString2", () => {    
        it("should reverse string when string length is odd", () => {
            var arr = ["h", "e", "l", "l", "o"];
            ReverseStringExercises.reverseString2(arr);
            expect(arr).toEqual(["o", "l", "l", "e", "h"]);
        });

        it("should reverse string when string length is even", () => {
            var arr = ["c", "e", "l", "l", "a", "r"];
            ReverseStringExercises.reverseString2(arr);
            expect(arr).toEqual(["r", "a", "l", "l", "e", "c"]);
        });
    });
});