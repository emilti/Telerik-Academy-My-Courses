function inputLine(form){
    var number = form.number.value;
    if (!isNaN(number)  && number !== '' && number % 1 === 0 ) {
        if (number % 2 > 0) {
            alert("The number is odd");
        }
        else {
            alert("The number is even")
        }
    }
    else {
        alert("Not a valid number.")
    }
}