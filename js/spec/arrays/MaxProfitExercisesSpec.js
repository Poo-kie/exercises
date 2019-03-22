describe("MaxProfit", () => {
    let MaxProfitExercises = require("../../lib/arrays/MaxProfitExercises");

    describe("maxProfit", () => {    
        it("should return zero for decreasing prices", () => {
            var arr = [6, 5, 4, 3, 2, 1];
            var maxProfit = MaxProfitExercises.maxProfit(arr);
            expect(maxProfit).toEqual(0);
        });

        it("should return (arr[length] - arr[0]) for increasing prices", () => {
            var arr = [1, 2, 3, 4, 5, 6];
            var maxProfit = MaxProfitExercises.maxProfit(arr);
            expect(maxProfit).toEqual(5);
        });

        it("should return correct max profit for staggered prices", () => {
            var arr = [7, 1, 5, 3, 6, 4];
            var maxProfit = MaxProfitExercises.maxProfit(arr);
            expect(maxProfit).toEqual(7);
        });
    });
});