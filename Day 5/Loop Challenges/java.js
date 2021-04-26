for(var i=1; i<=20; i++) {

    if (i % 2 != 0)
         console.log(i)
  
 }
 for(var i=4; i>-4; i=i-1.5) {
     console.log(i)
 }

 var sum=[]
 for(var i=1; i<=100; i++){
    sum.push(i)
}
console.log(
    sum.reduce((a, b) => a + b, 0)
  )

  var n;
  var total = 1;
  for(n= 1; n<= 100; n++){
      total = total * n;
      if (total>100000000){break}
          }
  console.log(total)