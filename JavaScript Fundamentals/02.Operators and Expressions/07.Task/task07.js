function inputLine(form) {
    var number = form.number.value;
    var checkNumber = Math.sqrt(number);
    var count;
    var isPrime = true;
    if (!isNaN(number) && number !== '' && number % 1 === 0) {
        if (number > 1) {
            for (count = 2; count <= Math.round(checkNumber) ; count += 1) {
                if (number % count === 0) {
                    isPrime = false;
                    break;
                }
                if (count === Math.round(checkNumber)) {
                    isPrime = true;
                }
            }
        }
        else {
            isPrime = false;
        }
        if (isPrime === true) {
            alert("The number IS prime.");
        }
        else {
            alert("The number is NOT prime");
        }
    }
    else {
        alert("Not a valid number.")
    }

}