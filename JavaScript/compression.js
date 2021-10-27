var compress = function (str) {
    let output = ""
    let counter =0
    let array = []
    for (let i = 0; i<str.length; i++){
      let arr = []
      if(str[i] == str[i+1]){
        counter ++
        }
      if(str[i] != str[i+1]){
      counter++
      arr.push(counter, str[i])
      counter = 0
      array.push(arr)
      }
      }
      output = JSON.stringify(array)
      if (output.length>=str.length){
        return str
        }
      return output
    }
    
    var decompress = function (str) {
    let first = str.replace(/[^a-zA-Z.]+/ig, " ").split(" ")
    let second = str.replace(/[^0-9]+/ig, " ").split(" ")
    if (second.length ==2){
      return str
      }
    let output = ""
    for (let i = 1; i<first.length-1; i++){
      output = output+first[i].repeat(second[i])
      }
    return output
    }