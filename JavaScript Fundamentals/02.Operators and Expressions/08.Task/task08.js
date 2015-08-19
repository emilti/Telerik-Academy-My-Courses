function inputLine(form) {
    var a = form.a.value;
    var b = form.b.value;
    var h = parseFloat(form.h.value);
    var trapezoidArea;
    if (!isNaN(a) && a !== '' &&
        !isNaN(b) && b !== '' &&
        !isNaN(h) && h !== '' &&
        a > 0 && b > 0 && h > 0) {    
            trapezoidArea = (((a * 1) + (b * 1)) * (h * 1)) / 2;
            alert("The trapezoid area is: " + trapezoidArea);             
    }
    else {
        alert("Not valid numbers for a,b and h. Try again.")
    }
}