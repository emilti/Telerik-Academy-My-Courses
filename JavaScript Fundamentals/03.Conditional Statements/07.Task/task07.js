function inputLine(form) {
    var a = parseFloat(form.a.value, 10);
    var b = parseFloat(form.b.value, 10);
    var c = parseFloat(form.c.value, 10);
    var d = parseFloat(form.d.value, 10);
    var e = parseFloat(form.e.value, 10);
    if (!isNaN(a) && a !== '' &&
        !isNaN(b) && b !== '' &&
        !isNaN(c) && c !== '' &&
        !isNaN(d) && d !== '' &&
        !isNaN(e) && e !== '') {
        if (a >= b && a >= c && a >= d && a >= e) {
            alert("the biggest variable is " + a)
        }
        else if (b >= a && b >= c && b >= d && d >= e) {
            alert("the biggest variable is " + b)
        }
        else if (c >= a && c >= b && c >= d && c >= e) {
            alert("the biggest variable is " + c)
        }
        else if (d >= a && d >= b && d >= c && d >= e) {
            alert("the biggest variable is " + e)
        }
        else if (e >= a && e >= b && e >= c && e >= d) {
            alert("the biggest variable is " + e)
        }
    }
    else {
        alert("Not valid numbers.")
    }
}