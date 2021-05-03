function removeRequest(element){
element.style.classList = "clear"
}
//when accept or close button pressed style changes to clear or html gets removed

    var count = document.getElementById("box-1").value;
    function changeNumber(){
        let myElement = document.querySelector("#box-1");
        console.log(myElement);
        count--;
        myElement.innerHTML = count;
        console.log(count);
    }
//when accept or close button pressed .box-1 decreases
function addNumber(){

}
//when accept button pressed .box-2 number increases
function editProfile(){

}
//create a text field, replace name with text field