function problem1(form) {
    var number=form.numberProblem1.value,
        lastDigit,
        digitAsWord;
    number = number * 1;
    lastDigit = number % 10;
    digitAsWord = problem1Solver(lastDigit);
    console.log("The last digit is " + digitAsWord);
}

function problem1Solver(lastDigit){
    var digitAsWord;
    switch(lastDigit)
    {
        case 0:    digitAsWord = "Zero";break;
        case 1:    digitAsWord = "One";break;
        case 2:    digitAsWord = "Two";break;
        case 3:    digitAsWord = "Three";break;
        case 4:    digitAsWord = "Four";break;
        case 5:    digitAsWord = "Five";break;
        case 6:    digitAsWord = "Six";break;
        case 7:    digitAsWord = "Seven";break;
        case 8:    digitAsWord = "Eight";break;
        case 9:    digitAsWord = "Nine";break;
        default : digitAsWord = "Not a number";break;
    }
    return digitAsWord;
}

function problem2(form) {
    var number=form.numberProblem2.value,
        reversedNumber;
    reversedNumber = problem2Solver(number);
    console.log("The reversed number is " + reversedNumber);
}

function problem2Solver(number){
    var reversedNumber;
    reversedNumber = number.split('').reverse().join('');
    return reversedNumber;
}

function problem3(form){
    var text=form.textProblem3.value,
        searchedWord = form.wordProblem3.value,
        isCaseSensitive = document.getElementById('input3-check').checked,
        count,
        textLength = text.length,
        index,
        arrayOfWords;
    var myregex = new RegExp('[-+()*\/,.:;? ]');
    arrayOfWords = text.split(myregex);
    console.log(arrayOfWords.join(','))
    if (isCaseSensitive) {
        count = problem3CaseSensitive(arrayOfWords, searchedWord);
    } else {
        count = problem3CaseInsensitive(arrayOfWords, searchedWord);
    }

    console.log('The count of the word %s in the text is %d',searchedWord,count);

    function problem3CaseSensitive(arrayOfWords, searchedWord){
        var index,
            len = arrayOfWords.length,
            count = 0;

        for (index = 0; index < len ; index ++){
            if (searchedWord === arrayOfWords[index] ){
                count+=1;
            }
        }
        return count;

    }
    function problem3CaseInsensitive(arrayOfWords, searchedWord){
        var index,
            len = arrayOfWords.length,
            count = 0;

        for (index = 0; index < len ; index ++){
            if (searchedWord.toLowerCase() === arrayOfWords[index].toLowerCase()){
                count+=1;
            }
        }
        return count;
    }
}


function problem4() {
    var count = document.getElementsByTagName('div').length;
    document.getElementById('count').innerHTML = 'There are ' + count + ' DIVs in this HTML.';
    console.log('Problem 4: There are %d DIVs.',count);
}

function problem5Solver(len, arrayOfNumbers, searchedNumber) {
    var index,
        count = 0;
    for (index = 0; index < len; index += 1) {
        if (arrayOfNumbers[index] === searchedNumber) {
            count += 1;
        }
    }
    return count;
}
function problem5(form){
    var searchedNumber = form.numberProblem5.value * 1,
        line = form.arrayProblem5.value,
        count = 0,
        index,
        arrayOfNumbers,
        len;
    arrayOfNumbers = line.split(",").map(function(item) {
        return parseInt(item, 10);
    });
    len = arrayOfNumbers.length;
    count = problem5Solver(len,arrayOfNumbers, searchedNumber);
    console.log("The count of occurencies of number %d in the array is: %d",searchedNumber,count)
}

function problem5Test(){
    var searchedNumber = 1,
        arrayOfNumbers=[1,2,3,1],
        len = 4,
        checkCount = 2,
        count = 0;
    count =  problem5Solver(len,arrayOfNumbers,searchedNumber);
    if (checkCount === count){
        console.log("The function is working properly!");
    }
    else{
        console.log("The function is NOT working properly!");
    }
}

function problem6(form){
    var checkedPosition = form.positionProblem6.value * 1,
        line = form.arrayProblem6.value,
        arrayOfNumbers,
        len;
    arrayOfNumbers = line.split(",").map(function(item) {
        return parseInt(item, 10);
    });
    len = arrayOfNumbers.length;
    if (checkedPosition === 0 || checkedPosition >= len - 1){
        console.log("The number at position %d doesn't have two neighbours.",checkedPosition)
    }
    else{
        if (arrayOfNumbers[checkedPosition]>arrayOfNumbers[checkedPosition-1]&&
            arrayOfNumbers[checkedPosition]>arrayOfNumbers[checkedPosition+1]){
          console.log("The number %d at position %d is bigger than its two neighbours",
              arrayOfNumbers[checkedPosition],checkedPosition)
        } else {
            console.log("The number %d at position %d is NOT bigger than its two neighbours",
                arrayOfNumbers[checkedPosition],checkedPosition)
        }
    }
}

function problem7(form){
    var line = form.arrayProblem7.value,
        arrayOfNumbers,
        index,
        len,
        searchedPosition = -1;
    arrayOfNumbers = line.split(",").map(function(item) {
        return parseInt(item, 10);
    });
    len = arrayOfNumbers.length;
    for (index = 1; index < len-1; index+=1){
        if (arrayOfNumbers[index]>arrayOfNumbers[index - 1]
        && arrayOfNumbers[index] > arrayOfNumbers[index+1]){
            searchedPosition = index;
            break;
        }
    }
    if (searchedPosition > -1){
        console.log("The first number bigger than its two neighbours in the array is %d at position %d",
            arrayOfNumbers[searchedPosition],searchedPosition)
    } else {
        console.log("There isn't number in the array bigger than its two neighbours.")
    }
}