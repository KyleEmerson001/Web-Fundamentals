//High Pass Filter
function highPass(arr, cutoff) {
    var filteredArr = [];
    for (let i = 0; i < arr.length; i++) {
    if (arr[i] > cutoff)
    filteredArr.push(arr[i])}
    return filteredArr;
}
var result = highPass([6, 8, 3, 10, -2, 5, 9], 5);
console.log(result);

//Evens or Odds
function evensOfOdds(arr) {
    var totalOdds = 0;
    var totalEvens = 0;
    // your code here
}
   
var result = evensOfOdds([6, 8, 3, 10, -2, 5, 9]);
console.log(result); // we expect back "evens are larger"

//Better than Average
function betterThanAverage(arr) {
    var sum = 0;
    // calculate the average
    var count = 0
    // count how many values are greated than the average
    return count;
}
var result = betterThanAverage([6, 8, 3, 10, -2, 5, 9]);
console.log(result); // we expect back 4

//Fibonacci Array
function fibonacciArray(n) {
    // the [0, 1] are the starting values of the array to calculate the rest from
    var fibArr = [0, 1];
    for (let i =2; i<n; i++){
        fibArr.push(fibArr[i-2]+ fibArr[i-1])
    }
    return fibArr;
}
   
var result = fibonacciArray(10);
console.log(result); // we expect back [0, 1, 1, 2, 3, 5, 8, 13, 21, 34]