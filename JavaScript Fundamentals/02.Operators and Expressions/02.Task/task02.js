function inputLine(form) {
    var number = form.number.value;
    var boolExpression = number % 7 === 0 && number % 5 === 0 ? true : false;
    if (!isNaN(number) && number !== '' && number % 1 === 0) {
        alert("The number is divisible by 5 and 7:" + " " + boolExpression);
    }
    else {
        alert("Not a valid number.")
    }
}