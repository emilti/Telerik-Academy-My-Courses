function inputLine(form) {
    var firstNumber = form.firstNumber.value * 1;
    var secondNumber = form.secondNumber.value * 1;
    var thirdNumber = form.thirdNumber.value * 1;
    if (!isNaN(firstNumber) && firstNumber !== ''
     && !isNaN(secondNumber) && secondNumber !== ''
    && !isNaN(thirdNumber) && thirdNumber !== '') {
        if (firstNumber > secondNumber && secondNumber >= thirdNumber) {
            alert("Sorted numbers are " + firstNumber + ", " + secondNumber + ", " + thirdNumber)
        }
        else if (firstNumber > thirdNumber && secondNumber <= thirdNumber) {
            alert("Sorted numbers are " + firstNumber + ", " + thirdNumber + ", " + secondNumber)
        }
        else if (firstNumber < secondNumber && firstNumber > thirdNumber) {
            alert("Sorted numbers are " + secondNumber + ", " + firstNumber + ", " + thirdNumber)
        }
        else if (thirdNumber < secondNumber && firstNumber <= thirdNumber) {
            alert("Sorted numbers are " + secondNumber + ", " + thirdNumber + ", " + firstNumber)
        }
        else if (firstNumber < thirdNumber && secondNumber <= firstNumber) {
            alert("Sorted numbers are " + thirdNumber + ", " + firstNumber + ", " + secondNumber)
        }
        else if (secondNumber < thirdNumber && secondNumber >= firstNumber) {
            alert("Sorted numbers are " + thirdNumber + ", " + secondNumber + ", " + firstNumber)
        }
        else if (secondNumber === thirdNumber && secondNumber === firstNumber) {
            alert("Sorted numbers are " + thirdNumber + ", " + secondNumber + ", " + firstNumber)
        }
    }
    else {
        alert("Not valid numbers.")
    }
}