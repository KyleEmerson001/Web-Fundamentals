var arr2d = [ [2, 5, 8],
              [3, 6, 1],
              [5, 7, 7] ];
var result = false
for (var i=0; i<arr2d.length; i++)
    for(var j = 0; j=arr2d[i].length; j++){
        if (arr2d[i][j==value]{
            return true;
        }
        )
    }
var value = 8;
console.log(isPresent2d[arr2d, value]);

// we expect to get back [2, 5, 8, 3, 6, 1, 5, 7, 7]
function flatten(arr2d) {
    var flat = [];
    for (var i=0; i <arr2d.length; i++)
    for(var j = 0; j < arr2d[i].length; j++){
        flat.push(arr2d[i][j]);
        }
    return flat;
}
    
var result = flatten( [ [2, 5, 8], [3, 6, 1], [5, 7, 7] ] );
console.log(result); 