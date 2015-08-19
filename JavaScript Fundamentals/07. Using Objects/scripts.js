//Task 1
function problem1(form){
var x1 = form.x1Problem1.value,
    y1 = form.y1Problem1.value,
    name1 = 'point1',
    y2 = form.y2Problem1.value,
    x2 = form.x2Problem1.value,
    name2 = 'point2',
    x3 = form.x3Problem1.value,
    y3 = form.y3Problem1.value,
    name3 = 'point3',
    x4 = form.x4Problem1.value,
    y4 = form.y4Problem1.value,
    name4 = 'point4',
    x5 = form.x5Problem1.value,
    y5 = form.y5Problem1.value,
    name5 = 'point5',
    x6 = form.x6Problem1.value,
    y6 = form.y6Problem1.value,
    name6 = 'point6',
    point1 = createPoint(name1,x1,y1),
    point2 = createPoint(name2,x2,y2),
    point3 = createPoint(name3,x3,y3),
    point4 = createPoint(name4,x4,y4),
    point5 = createPoint(name5,x5,y5),
    point6 = createPoint(name6,x6,y6),
    index = 0,
    arrayOfPoints = [],
    selName1 = form.drop1.value,
    selName2 = form.drop2.value,
    selPoint1,
    selPoint2,
    distance,
    sideA,
    sideB,
    sideC;
    arrayOfPoints.push(point1);
    arrayOfPoints.push(point2);
    arrayOfPoints.push(point3);
    arrayOfPoints.push(point4);
    arrayOfPoints.push(point5);
    arrayOfPoints.push(point6);
    for (index =0; index < 6; index+=1){
        if (selName1 === arrayOfPoints[index].name){
            selPoint1 = arrayOfPoints[index];
        }
        if (selName2 === arrayOfPoints[index].name){
            selPoint2 = arrayOfPoints[index];
        }
    }
    distance = calculateDistance(selPoint1,selPoint2);
    console.log(distance);
    sideA = calculateDistance(point1,point2);
    sideB = calculateDistance(point3,point4);
    sideC = calculateDistance(point5,point6);
    if (sideA + sideB > sideC &&
    sideB + sideC > sideA &&
    sideA + sideC > sideB){
        console.log("Side A (point 1 and point 2), Side B (point 3 and point 4) and Side C (point 5 and point 6) can form a triangle")
    } else {
        console.log("Side A (point 1 and point 2), Side B (point 3 and point 4) and Side C (point 5 and point 6) can NOT form a triangle")
    }
}


function calculateDistance(point1,point2) {
    return Math.sqrt((point1.xVal - point2.xVal) * (point1.xVal - point2.xVal) +
        (point1.yVal - point2.yVal) * (point1.yVal - point2.yVal));

}

function createPoint(name,x,y) {
   var point = {name: name, xVal: x, yVal: y
    };
    return point;
}

//Task 2
function problem2(form){
    var removedNumber = form.numberProblem2.value * 1,
        line = form.arrayProblem2.value,
        arrayOfNumbers;
    arrayOfNumbers = line.split(",").map(function(item) {
        return parseInt(item, 10);
    });
    arrayOfNumbers.removeNumber(removedNumber, arrayOfNumbers);
    console.log(arrayOfNumbers.join(', '));
}

Array.prototype.removeNumber = function(removedNumber, arrayOfNumbers) {
    var len = arrayOfNumbers.length,
        index;
    for (index = 0; index < len; index += 1){
        if (arrayOfNumbers[index] === removedNumber){
            arrayOfNumbers.splice(index,1);
            len = arrayOfNumbers.length;
        }
    }
};

//Task 3
function problem3(form) {
    var point1 = {name: 'point1', xVal: 1, yVal:1},
        point2 = {name: 'point2', xVal: 2, yVal:2},
        point3 = deepCopy(point1),
        point4 = deepCopy(point2),
        arrayOfPoints = [],
        deepCopyOfArray;
    arrayOfPoints.push(point1);
    arrayOfPoints.push(point2);
    deepCopyOfArray = deepCopy(arrayOfPoints)
    deepCopyOfArray[0].name = 'CHANGED NAME AFTER COPY';
    console.log('Original array name - ' + arrayOfPoints[0].name);
    console.log('The name of the deep copy -' +deepCopyOfArray[0].name);
    function deepCopy(original){
        return JSON.parse(JSON.stringify(original));
    }
};
//Task 4
function problem4(form){
    var object1 = [],
        object2 = {name:'zzzz'},
        searchedProperty = form.propertyProblem4.value,
        obj1HasProp,
        obj2HasProp;
    object1.push(1);
    obj1HasProp = hasProperty(object1, searchedProperty);
    obj2HasProp = hasProperty(object2, searchedProperty);
    console.log('Object1 has property '+searchedProperty +' -' +obj1HasProp);
    console.log('Object2 has property '+searchedProperty +' -' +obj2HasProp);
}

function hasProperty(obj, property){
    for ( var prop in obj ) {
        if (prop === property){
            return true;
        }
    }
    return false;
}

//Task 5
function problem5(){
    var people = [],
        person1 = {firstname : 'Gosho', lastname: 'Petrov', age: 32 },
        person2 = {firstname : 'Bay', lastname: 'Ivan', age: 81},
        person3 = {firstname : 'Pesho', lastname: 'Peshev', age: 33},
        person4 = {firstname : 'Georgi', lastname: 'Georgiev', age: 18},
        index,
        youngestPerson,
        minAge = Number.MAX_SAFE_INTEGER ,
        len;
    people.push(person1);
    people.push(person2);
    people.push(person3);
    people.push(person4);
    len = people.length;
    for (index = 0; index < len; index+=1 ){
        if (minAge > people[index].age){
            minAge = people[index].age;
            youngestPerson = people[index];
        }
    }
    console.log('The youngest person is %s %s - %d years old',
        youngestPerson.firstname,
        youngestPerson.lastname,
        youngestPerson.age);
}

//Task 6
function problem6(form){
    var people = [],
        person1 = {firstname : 'person1Fname', lastname: 'person1Lname', age: 32 },
        person2 = {firstname : 'person2Fname', lastname: 'person2Lname', age: 81},
        person3 = {firstname : 'person3Fname', lastname: 'person3Lname', age: 33},
        person4 = {firstname : 'person4Fname', lastname: 'person4Lname', age: 18},
        person5 = {firstname : 'person5Fname', lastname: 'person5Lname', age: 22},
        incompletePerson = {lastname: 'incPerson', age: 23},
        key = form.dropProblem6.value,
        index,
        groupedPeople = [],
        len;
    people.push(person1);
    people.push(person2);
    people.push(person3);
    people.push(person4);
    people.push(person5);
    people.push(incompletePerson);

    groupedPeople = grouping(people,key);
    len = groupedPeople.length;
    for (var obj in groupedPeople){
        console.log('%s %s %i',JSON.stringify(groupedPeople[obj].firstname), JSON.stringify(groupedPeople[obj].lastname),groupedPeople[obj].age);
    }
}

function grouping(people, key){
    var groupedPeople = [],
        len,
        index,
        arrayCell;
    len = people.length;
    for (index = 0; index < len; index +=1){
        if (people[index].hasOwnProperty(key)){
            switch (key){
                case 'firstname': arrayCell = people[index].firstname;break;
                case 'lastname': arrayCell = people[index].lastname;break;
                case 'age': arrayCell = people[index].age;break;
            }
            arrayCell = arrayCell.toString();
            groupedPeople[arrayCell] = people[index];
        }
    }
    groupedPeople.splice(groupedPeople.length -1, 1);
    return groupedPeople;
}
