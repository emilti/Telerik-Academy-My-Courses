function inputLine(form) {
    var number = form.number.value;        
    var nRightP = number >> 3;    
    var bit = nRightP & 1;
    if (!isNaN(number) && number !== '' && number % 1 === 0) {
        alert("The bit at 3rd position is:" + " " + bit)
    }
    else {
        alert("Not a valid number.")
    }
}