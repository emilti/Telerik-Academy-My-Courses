function inputLine(form) {
    var x = form.x.value;
    var y = form.y.value;

    var sideC = Math.sqrt((x-1) * (x-1) + (y-1) * (y-1));
    if (!isNaN(x)&&!isNaN(y)&& x != '' && y !='') {
        if (sideC <= 3 && (((y > 1 || y < -1) && (x < -1 || x > 5))||
            ((y <= 1 && y >= -1) && (x < -1 || x > 5))||
            ((y > 1 || y < -1) && (x >= -1 || x <= 5)))) {
            alert("The point (" + x + "," + y + ") is in the circle k((1,1),3) and outside of the rectangle:YES");
        }
        else {
            alert("The point (" + x + "," + y + ") is in the circle k((1,1),3) and outside of the rectangle:NO");
        }
    }
    else
    {
        alert("Not valid numbers for x and y.")
    }
}