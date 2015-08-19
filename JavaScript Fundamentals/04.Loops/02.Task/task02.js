function inputLine(form) {
    var number =parseInt(form.number.value,10);
    var numbers = new Array(1);
    for (var i = 1; i <= number; i++) {
        if (i % 3 !== 0 && i % 7 !== 0) {
            numbers.push(i);
        }
    }
    alert((numbers.join(", ")));
}