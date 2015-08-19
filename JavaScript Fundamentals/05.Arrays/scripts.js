function problem1(form) {
    var numbers=[];
    var counter;
    for (counter=0;counter<20;counter+=1){
        numbers.push(counter * 5);
        console.log(counter +" - >" + numbers[counter]);
    }
}

function problem2(form) {
    var isEqual = false;
    var line1= form.secondArray1.value;
    var line2= form.secondArray2.value;
    var array1 = line1.split(",");
    var array2 = line2.split(",");
    var diff, index;

    if (array1.length === array2.length)
    {
        isEqual = true;
        diff = 0;
        for (index = 0; index < array1.length; index+=1)
        {

            if (array1[index] !== array2[index])
            {
                isEqual=false;
            }
        }
        //isEqual = diff == 0 ? true : false;
    }
    if (isEqual === true)
    {
        console.log("The two arrays are equal");
    }
    else
    {
        console.log("The two arrays are NOT equal");
    }
}

function problem3(form){
    var line = form.third.value;
    var arrayOfNumbers = line.split(",").map(function(i){
        return parseInt(i, 10);
    });
    var index, currentCount = 1, maxCount = 0, equalNumber, arrayOfEquals = [];

    for (index = 1; index < arrayOfNumbers.length;index+=1){
        if (arrayOfNumbers[index]===arrayOfNumbers[index - 1]){
            currentCount+=1;
            if (currentCount>maxCount){
                maxCount = currentCount;
                equalNumber = arrayOfNumbers[index];
            }
        }
        else{
            currentCount = 1;
        }
    }
    if (maxCount===0){
        equalNumber = arrayOfNumbers[arrayOfNumbers.length - 1];
        maxCount = 1;
    }
    for (index = 0;index<maxCount;index+=1){
        arrayOfEquals[index] = equalNumber;
    }
    console.log(arrayOfEquals.join(","))
}

function problem4(form) {
    var line = form.fourth.value;
    var arrayOfNumbers = line.split(",").map(function (i) {
        return parseInt(i, 10);
    });
    var index, currentCount = 1, maxCount = 0, currentStart, currentFinish, maxStart, maxFinish, isFirst = true, increasingSequence = false, maxIncrArray = [];

    function checkMaxSequence() {
        if (currentCount > maxCount) {
            maxCount = currentCount;
            maxStart = currentStart;
            maxFinish = currentFinish;
        }
    }

    for (index = 1; index < arrayOfNumbers.length; index += 1) {
        if (arrayOfNumbers[index] > arrayOfNumbers[index - 1]) {
            currentCount += 1;
            if (isFirst === true) {
                currentStart = index - 1;
                isFirst = false;
                increasingSequence = true;
            }
            if (index === arrayOfNumbers.length - 1) {
                currentFinish = index;
                checkMaxSequence();
            }
        }
        else if (increasingSequence === true) {
            currentFinish = index - 1;
            isFirst = true;
            checkMaxSequence();
            currentCount = 1;
        }
    }
    for (index = maxStart; index <= maxFinish; index += 1) {
        maxIncrArray[index - maxStart] = arrayOfNumbers[index];
    }
console.log(maxIncrArray.join(","));
}

function problem5(form) {
    var line = form.fifth.value;
    var arrayOfNumbers = line.split(",").map(function (i) {
        return parseInt(i, 10);
    });
    var index,
        currentMin = arrayOfNumbers[0],
        indexOfMin,
        temp,
        currentMinIndex=0;
    for (index = 1; index < arrayOfNumbers.length;index +=1){
        if (arrayOfNumbers[index] < currentMin){
            currentMin = arrayOfNumbers[index];
            indexOfMin = index;
        }
        if (index === arrayOfNumbers.length - 1){
            temp = arrayOfNumbers[currentMinIndex];
            arrayOfNumbers[currentMinIndex] = currentMin;
            arrayOfNumbers[indexOfMin] = temp;
            currentMinIndex++;
            indexOfMin = currentMinIndex;
            index = currentMinIndex;
            currentMin = arrayOfNumbers[currentMinIndex];
        }
    }
    console.log(arrayOfNumbers.join(", "));
}

function problem6(form) {
    var line = form.sixth.value;
    var arrayOfNumbers = line.split(",").map(function (i) {
        return parseInt(i, 10);
    });
    var mostFrequentNumber,
        currentCheckedNumber = arrayOfNumbers[0],
        currentCount = 0,
        maxCount = 0,
        index,
        checkedPosition = 0;

    for(index = 0; index < arrayOfNumbers.length;index+=1){
        if (arrayOfNumbers[index] === currentCheckedNumber){
            currentCount+=1;
        }
        if (arrayOfNumbers.length - 1 === index && index >= checkedPosition){
            if (currentCount > maxCount){
                maxCount = currentCount;
                mostFrequentNumber = arrayOfNumbers[checkedPosition];
            }
            checkedPosition++;
            currentCount = 0;
            index = 0;
            currentCheckedNumber = arrayOfNumbers[checkedPosition];
        }
    }
   var final = mostFrequentNumber + ","
    console.log(final.repeat(maxCount-1) + mostFrequentNumber);
}



function problem7(form) {
    var line = form.seventhArray.value;
    var arrayOfNumbers = line.split(",").map(function (i) {
        return parseInt(i, 10);
    });
    var searchedNumber = form.seventhNumber.value * 1;
    function compareNumbers(a, b) {
         a - b;
    }
    arrayOfNumbers.sort(compareNumbers());


    var targetPos =-1,
        begin = 0,
        end = arrayOfNumbers.length- 1,
        mid;

    while (begin <= end&&targetPos===-1)
    {
        mid = Math.round((begin + end) / 2);
        if (arrayOfNumbers[mid] < searchedNumber)
        {
            begin = mid + 1;
            continue;
        }
        else if (arrayOfNumbers[mid] > searchedNumber)
        {
            end = mid - 1;
            continue;
        }
        else
        {
            targetPos=mid;
        }
    }
    if (targetPos === -1)
    {
        console.log("No value found");
    }
    else
    {
        console.log("The number "+ searchedNumber+ " is at position "+ targetPos + " at the sorted array.");
    }

}