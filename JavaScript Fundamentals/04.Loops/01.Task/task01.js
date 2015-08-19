function inputLine(form) {
    var number = form.number.value;
    var result=1+"\n";
    for (var i=2; i<=number;i++)    {
        result+=i+"\n"
    }
    alert(result)
}