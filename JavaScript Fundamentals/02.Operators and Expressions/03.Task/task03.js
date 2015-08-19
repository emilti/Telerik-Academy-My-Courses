function inputLine(form) {
    var width = form.width.value;
    var height = form.height.value;
    var area;
    if (width > 0 && height > 0 &&
        !isNaN(width) && width !== '' &&
        !isNaN(height) && height !== '') {
        area = (width*1) * (height*1);
        alert("The rectangle area is" + " " + area);
    }
    else {
        alert("Not valid numbers for width and height. Try again");        
    }
}