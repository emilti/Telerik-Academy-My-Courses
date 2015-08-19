function inputLine(form) {
    var line = form.numbers.value;
    var numbers = line.split(',');
    var max=numbers[0];
    var min = numbers[0];
    for (var i = 0; i <= numbers.length; i++) {
        if ((numbers[i] * 1)>(max *1 ))
        {
            max=numbers[i]
        }
        if ((numbers[i] * 1) < (min *1 )) {
            min = numbers[i]
        }
    }
   alert("Max is "+ max +". Min is " +min);   
}