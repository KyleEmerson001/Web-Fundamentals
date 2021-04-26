function d6() {
    var roll = 
    1 + Math.floor(Math.random()*6)
    return roll;
}
    
var playerRoll = d6();
console.log("The player rolled: " + playerRoll);