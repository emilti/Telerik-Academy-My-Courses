function inputLine(form) {
    var number = form.number.value;
    var decimal = number % 10;
    var workingNumber = number - decimal;
    workingNumber = workingNumber / 10;
    var hundreds = workingNumber % 10;
    workingNumber = workingNumber - hundreds;
    workingNumber = workingNumber / 10;
    var checkForSeven = workingNumber % 10;
    var resultBool = checkForSeven === 7 ? true : false;
    if (!isNaN(number) && number !== '' && number % 1 === 0) {
        alert("The third digit is 7:" + " " + resultBool);
    }
    else {
        alert("Not a valid number.")
    }
}