function inputLine(form) {
    var firstNumber = form.firstNumber.value*1;
    var secondNumber = form.secondNumber.value*1;
    var thirdNumber = form.thirdNumber.value*1;
    if (!isNaN(firstNumber) && firstNumber !== ''
        && !isNaN(secondNumber) && secondNumber !== ''
       && !isNaN(thirdNumber) && thirdNumber !== '') {
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) {
            alert("The sign of the product is +")
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) {
            alert("The sign of the product is -")
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) {
            alert("The sign of the product is -")
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) {
            alert("The sign of the product is -")
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) {
            alert("The sign of the product is +")
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) {
            alert("The sign of the product is +")
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) {
            alert("The sign of the product is +")
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0) {
            alert("The sign of the product is -")
        }
        else if (firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
            alert("The product is 0")
        }
    }
    else {
        alert("Not valid numbers.")
    }
}