var count= 0;
function likes(){
    let myElement = document.querySelector("#quantity");
    console.log(myElement);
    count++;
    myElement.innerHTML = count;
    console.log(count);
}