function inputLine(form) {
    var x = form.x.value;
    var y = form.y.value;
    
    var sideC = Math.sqrt(x * x + y * y);
    if (!isNaN(x) && !isNaN(y) && x != '' && y != '') {
        if (sideC <= 5) {
            alert("The point (" + x + "," + y + ") is in the circle k(0,5)");
        }
        else {
            alert("The point (" + x + "," + y + ") is outside the circle k(0,5)");
        }
    }
    else {
        alert("Not valid numbers for x and y.")
    }
}