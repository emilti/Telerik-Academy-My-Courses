//Task 1
function problem1(form){
    var input = form.stringProblem1.value,
        index,
        len = input.length,
        reversedString = '';
    for (index = 0; index < len; index+=1){
        reversedString = input[index] + reversedString;
    }
    console.log(reversedString);
}
//Task 2
function problem2(){
    var input = "((a+b)/5-d)",
    //var  input = ")(a+b))",
         incorrect = false;
    if (input.indexOf('(') > input.indexOf(')'))
    {
        incorrect = true;
    }
    console.log('The brackets are put correctly:%s',!incorrect);
}
//Task 3
function problem3(form){
    var text = form.textProblem3.value,
        searchedString = form.searchedStringProblem3.value,
        substrings = text.split(searchedString),
        count = substrings.length - 1;
    console.log('The count of the strings "%s" in the text is: %i',searchedString,count);
}
//Task 4
function problem4(form){
     var input = form.textProblem4.value,
     // var input ='<upcase>text</upcase>',
        index,
        reverseIndex,
        lengthOfChange,
        command,
        lengthOfCommand,
        formattedString,
        len = input.length,
         addLetter = 0;
    for (index  = 0; index < len; index += 1){
        addLetter = 0;
        if (input[index]==='/' && input[index - 1]=== '<'){
            reverseIndex = index-1;
            while(input[reverseIndex-1]!=='>'){
                reverseIndex-=1;
            }
            lengthOfChange = 0;
            while (input[reverseIndex + lengthOfChange] !== '<') {
                lengthOfChange += 1;
            }
            lengthOfCommand = index + 1;
            command = '';
            while(input[lengthOfCommand]!=='>'){
                command = command +input[lengthOfCommand];
                lengthOfCommand +=1;
            }
            command = command.toLowerCase();
            switch (command){
                case "upcase": formattedString = upcase(input, reverseIndex, index, lengthOfChange);break;
                case "lowcase": formattedString = lowcase(input, reverseIndex, index, lengthOfChange);
                    addLetter = 1;break;
                case "mixcase": formattedString = mixcase(input, reverseIndex, index, lengthOfChange)
                    addLetter = 1
                ;break;
            }
            input = formattedString;
            index = index - 11 - addLetter;
            len = input.length;
        }
    }
    console.log('Formatted text:'+input);
}

function upcase(input, reverseIndex, index, lengthOfChange){
    var formattedString1 = input.substring(0,reverseIndex - 8),
        formattedString2 = input.substring(reverseIndex, reverseIndex + lengthOfChange).toUpperCase(),
        formattedString3 = input.substring(index + 8, input.length   ),
        formattedString = formattedString1 + formattedString2 + formattedString3;
    return formattedString;
}

function lowcase(input, reverseIndex, index, lengthOfChange){
    var formattedString1 = input.substring(0,reverseIndex - 9),
        formattedString2 = input.substring(reverseIndex, reverseIndex + lengthOfChange).toLowerCase(),
        formattedString3 = input.substring(index + 9, input.length ),
        formattedString = formattedString1 + formattedString2 + formattedString3;
    return formattedString;
}

function mixcase(input, reverseIndex, index, lengthOfChange){
    var formattedString1 = input.substring(0,reverseIndex - 9),
        formattedString2 = '',
        formattedString3 = input.substring(index + 9, input.length ),
        formattedString = '',
        i,
        randomNumber;
    for (i = 0; i < lengthOfChange; i+=1){
        randomNumber = getRandom();
        if (randomNumber <0.5) {
            formattedString2 = formattedString2 + input[reverseIndex + i].toLowerCase();
        }
        else{
            formattedString2 = formattedString2 + input[reverseIndex + i].toUpperCase();
        }
    }
    formattedString = formattedString1 + formattedString2 + formattedString3;
    return formattedString;
}

function getRandom() {
    return Math.random();
};

//Task 5
function problem5(form){
    var input = form.textProblem5.value,
        index,
        formattedString = '',
        len = input.length;
    for (index = 0; index < len; index +=1){
        if (input[index] === ' '){
            formattedString = formattedString + '&nbsp';
        } else {
            formattedString = formattedString + input[index];
        }
    }
    console.log('Formatted string is:' + formattedString);
}

//Task 6
function problem6(form){
        var inputText = form.textProblem6.value,
            index,
            formattedString = '',
            len = inputText.length,
            reverseIndex,
            currentTextLength,
            lengthOfCommand,
            indexForCommand,
            input;
    input = inputText.replace(/(\r\n|\n|\r|\t)/g,'');

    for (index  = 0; index < len; index += 1){
        if (input[index]==='/' && input[index - 1]=== '<'){
            reverseIndex = index-1;
            while(input[reverseIndex-1]!=='>'){
                reverseIndex-=1;
            }
            currentTextLength = 0;
            while (input[reverseIndex + currentTextLength] !== '<') {
                currentTextLength += 1;
            }
            lengthOfCommand = 0;
            indexForCommand = index + 1;
            while(input[indexForCommand]!=='>'){
                indexForCommand +=1;
                lengthOfCommand +=1;
            }
            formattedString = deleteCommand(input, reverseIndex, index, currentTextLength, lengthOfCommand);
            input = formattedString;
            index = index - lengthOfCommand - 3;
            len = input.length;
        }
    }
    console.log('Formatted text:'+input);
}


function deleteCommand(input, reverseIndex, index, currentTextLength, lengthOfCommand){
    var formattedString1 = input.substring(0,reverseIndex - lengthOfCommand -2),
        formattedString2 = input.substring(reverseIndex, reverseIndex + currentTextLength),
        formattedString3 = input.substring(index + lengthOfCommand + 2, input.length   ),
        formattedString = formattedString1 + formattedString2 + formattedString3;
    return formattedString;
}

//Task 7
function problem7(form){
    var input = form.textProblem7.value,
    JSONObj = problem7Solver(input);
    console.log(JSONObj);
}

function problem7Solver(input){
    var protocolIndex = input.indexOf(':'),
        protocolStr = input.substring(0, protocolIndex),
        serverIndex = input.indexOf('/', protocolIndex+3),
        serverStr = input.substring(protocolIndex+3, serverIndex),
        resourceStr = input.substring(serverIndex),
        JSONObj = {"PROTOCOL":protocolStr,"SERVER":serverStr, "RESOURCE":resourceStr};
    return JSONObj
}

//Task 8
function problem8(form){
    var input = form.textProblem8.value,
        pattern = "<a href=\"",
        replacement = "[URL=",
        patternB = "\">",
        replacementB = "]",
        patternC = "</a>",
        replacementC = "[/URL]",
        notFinished = true,
        result = '',
        result2 = '',
        finalResult = input;
        while (notFinished) {
            input = finalResult;
            result = input.replace(pattern, replacement);
            if (result === input){
                notFinished = false;
                break;
            }
            result2 = result.replace(patternB, replacementB);
            finalResult = result2.replace(patternC, replacementC);
        }
    console.log("The cnahged text is:" + finalResult);
}

//Task 9
function problem9(form){
    var input = form.textProblem9.value,
        re = /(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))/g,
        mails = input.match(re);
    console.log(mails);
}

//Task 10
function problem10(form){
    var input = form.textProblem10.value,
        rgx = /([a-zA-Z])+/g,
        word,
        words = input.match(rgx),
        listOfPalindromes = [],
        isPalindrome,
        length,
        i;
    console.log("Palindromes are:");
    for (var prop in words)
    {
        word = words[prop];
        isPalindrome = true;
        length = word.length;
        for (i = 0; i < length/2; i+=1)
        {
            if (word[i] !== word[length - i-1])
            {
                isPalindrome = false;
                break;
            }
            //
            if (!!(length % 2) && isPalindrome && i === (length-1) / 2 - 1) {
                console.log(word);
            }
            else if (!(length % 2) && isPalindrome && i === length / 2 -1){
                console.log(word);
            }
        }
    }
}

//Task 11
function problem11(form){
    var input = form.textProblem11.value,
        len,
        index,
        formattedString,
        arrayOfVars = [],
        len = input.length,
        vars,
        rePre,
        num,
        varsFormatted,
        varsFormatted2,
        varsFormatted3,
        stringForFormatting,
        stringForFormattingNew = '',
        stringForFormattingStart,
        re,
        stringForFormattingEnd,
        lenVar,
        varIndex;
    for (index = 0; index < len -1; index+= 1 ){
        if (input[index]=== "'" && input[index + 1] === ','){
            vars = input.substring(index + 2,len);
            stringForFormattingEnd = index;
            break;
        }
    }
    stringForFormattingStart = input.indexOf("'");
    stringForFormatting = input.substring(stringForFormattingStart,stringForFormattingEnd + 1);
    varsFormatted = vars.replace(/ /g,'');
    varsFormatted2 = varsFormatted.replace(/'/g,"");
    varsFormatted3 = varsFormatted2.replace(/\);/g,"");
    arrayOfVars = varsFormatted3.split(',');
    len = stringForFormatting.length;
    lenVar = arrayOfVars.length;
    for (index = 0; index < len; index += 1) {
            //rePre ="{"+index + "}";
            //re = new RegExp("\{"+index + "\}", 'g');
            //stringForFormattingNew = stringForFormatting.replace(re,arrayOfVars[index]);
            //stringForFormatting = stringForFormattingNew;
            if (stringForFormatting[index] === '{' &&
                !isNaN(stringForFormatting[index + 1])&&
                stringForFormatting[index + 2] === '}'){
                stringForFormattingNew = stringForFormattingNew + arrayOfVars[stringForFormatting[index + 1]];
                index = index + 2;
            }
             else if (stringForFormatting[index] === '{' &&
                !isNaN(stringForFormatting[index + 1]) && !isNaN(stringForFormatting[index + 2])&&
                stringForFormatting[index + 3] === '}') {
                num =stringForFormatting[index + 1] +''+ stringForFormatting[index + 2]
                stringForFormattingNew = stringForFormattingNew + arrayOfVars[num * 1];
                index = index + 3;
            } else {
                stringForFormattingNew =stringForFormattingNew + stringForFormatting[index];
            }
    }

    console.log(stringForFormattingNew);
}

//Task 12
function problem12() {
    var people = [{name: 'Peter', age: 14},
            {name: 'Gosho', age: 20},
            {name: 'Rado', age: 18},
            {name: 'Atanas', age: 44},
            {name: 'Stoio', age: 9},];

    var template = document.getElementById('list-item').innerHTML;
    var peopleList = generateList(people, template);
    document.getElementById('list-item').innerHTML = peopleList;
}

function generateList(people, template){
    var len = people.length,
        index,
        result = '';
    for(index = 0; index < len; index += 1){
    result = result + "<li><strong>" + people[index].name + "</strong> <span>" + people[index].age +"</span></li>"
    }
    result = "<ul>" + result + "</ul>";
    return result;
}
