function minCoinChang() {

    var coinChange = {"quarter": 0, "dime": 0, "nickel": 0, "penny": 0}
    coinChange ["quarter"] = Math.floor(num/25)
    num = num % 25
    coinChange ["dime"] = Math.floor(num/10)
    num = num % 10
    coinChange ["nickle"] = Math.floor(num/5)
    num = num % 25
    coinChange ["penny"] = num
    
    return(counChange)
}

console.log(minCoinChange(321))

function invertObj(obj){
    var invert = {}
    for (let key of Object.keys(obj)){
        let value = obj[key]
        invert[value] = key
    }
    return(invert)
}
console.log(invertObj ({'A':"One", 'B':"Two",'C':"Three"}))