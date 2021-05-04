const str1 = " there's no free lunch - gotta pay yer way. ";
const expected1 = "TNFL-GPYW";
const str2 = "Live from New York, it's Saturday Night!";
const expected2 = "LFNYISN";

function acronymize(str){
var acronym = "";
var wordsArr = str.split(" ")

for (var i = 0; i < wordsArr.length; i++) {
    acronym += wordsArr[0].toUpperCase();
}
return acronym;
}
console.log(acronymize(str1))