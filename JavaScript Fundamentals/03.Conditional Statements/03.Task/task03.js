function inputLine(form) {
    var firstNumber = form.firstNumber.value * 1;
    var secondNumber = form.secondNumber.value * 1;
    var thirdNumber = form.thirdNumber.value *1;
    if (!isNaN(firstNumber) && firstNumber !== ''
       && !isNaN(secondNumber) && secondNumber !== ''
      && !isNaN(thirdNumber) && thirdNumber !== '') {
        if (firstNumber > secondNumber && firstNumber > thirdNumber) {
            alert(firstNumber + " is the biggest.");
        }
        else if (firstNumber < secondNumber && secondNumber > thirdNumber) {
            alert(secondNumber + " is the biggest.");
        }
        else if (firstNumber < thirdNumber && secondNumber < thirdNumber) {
            alert(thirdNumber + " is the biggest.");
        }
        else if (firstNumber === secondNumber && secondNumber > thirdNumber) {
            alert("There isn't biggest number.");
        }
        else if (firstNumber === thirdNumber && secondNumber < thirdNumber) {
            alert("There isn't biggest number.");
        }
        else if (secondNumber === thirdNumber && firstNumber < thirdNumber) {
            alert("There isn't biggest number.");
        }
        else if (secondNumber === thirdNumber && firstNumber === thirdNumber) {
            alert("There isn't biggest number.");
        }
    }
    else {
        alert("Not valid numbers.");
    }
}