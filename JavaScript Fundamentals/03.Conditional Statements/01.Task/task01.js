function inputLine(form){
    var firstNumber = form.firstNumber.value;
    var secondNumber = form.secondNumber.value;
    if (!isNaN(firstNumber) && firstNumber !== '' && !isNaN(secondNumber) && secondNumber !== ''
        && firstNumber % 1 === 0 && secondNumber % 1===0) {
        if (firstNumber > secondNumber) {
            var switcher = firstNumber;
            firstNumber = secondNumber;
            secondNumber = switcher;
            alert("The first  number is bigger than the second number. Their values are switched. First number is: "
                + firstNumber + " and second number is: " + secondNumber);
        }
        else {
            alert("The values of the two numbers are their initial ones. First number is: "
                + firstNumber + " and second number is: " + secondNumber);
        }
    }
    else    {
        alert("Not valid numbers.")
    }

}
