function inputLine(form) {
    var a = parseFloat(form.a.value, 10);
    var b = parseFloat(form.b.value, 10);
    var c = parseFloat(form.c.value, 10);
    var discr = b * b - 4 * a * c;
    if (discr < 0) {
        alert("There are no real roots.")
    }
    else if (discr === 0) {
        var x = -b / (2.0 * a);
        alert("The roots are equal to "+x)
    }
    else
    {
        var x1 = (-b - Math.sqrt(discr)) / (2.0 * a);
        var x2 = (-b + Math.sqrt(discr)) / (2.0 * a);
        alert("The roots are " + x1 +" "+ x2)
    }
}