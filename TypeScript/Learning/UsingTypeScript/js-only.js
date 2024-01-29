const button2 = document.querySelector("button2")
const input3 = document.getElementById("num3")
const input4 = document.getElementById("num4")

function addJS(num3, num4){
    //if (typeof num1 === "number" && typeof num2 === "number") {
    //    return num1 + num2;
    //}
    //else{
    //    return +num1 + +num2;
    //}
    return num3 + num4;
}

button.addEventListener("click", function(){
    console.log(add(input3.value, input4.value));
})