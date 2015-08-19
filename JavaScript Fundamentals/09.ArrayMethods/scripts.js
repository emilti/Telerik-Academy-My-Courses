/**
 * Created by private on 5.6.2015 ã..
 */
function start(form){
var arrayOfPersons=[],
    person1 = createPerson('Ivan', 'Ivanov', 20, false, arrayOfPersons),
    person2 = createPerson('Petar', 'Petrov', 18, false, arrayOfPersons),
    person3 = createPerson('Dimitar', 'Dimitrov', 38, false, arrayOfPersons),
    person4 = createPerson('Maria', 'Ivanova', 25, true, arrayOfPersons),
    person5 = createPerson('Stanka', 'Stankova', 68, true, arrayOfPersons),
    person6 = createPerson('Antonina', 'Antonieva', 20, true, arrayOfPersons),
    person7 = createPerson('Gergana', 'Gergova', 29, true, arrayOfPersons),
    person8 = createPerson('Dincho', 'Donchev', 18, false, arrayOfPersons),
    person9 = createPerson('Hristo', 'Hristov', 38, false, arrayOfPersons),
    person10 = createPerson('Iliq', 'Iliev', 8, false, arrayOfPersons),
    person11 = createPerson('Slavka', 'Slavova', 17, true, arrayOfPersons),
    person12 = createPerson('Sashka', 'Sashkova', 38, true, arrayOfPersons);
    return arrayOfPersons;

}

//Task 1
function problem1(form){
    var arrayOfPersons = start();
    arrayOfPersons.forEach(function(person, index) {
        console.log(person.fName +' '+ person.lName+ ' at index ' + index + ' in the array has age:' + person.age);
        });
}

function createPerson(firstName, lastName, age, gender, arrayOfPersons){
    var person ={fName:firstName, lName:lastName, age: age, gender:gender};
    arrayOfPersons.push(person);
    return person;
}

//Task 2
function problem2(form){
    var arrayOfPersons,  task2result;
    arrayOfPersons = start();
    task2result = arrayOfPersons.every(checkAge);
    console.log('All persons in the array are at least 18 years old:%s',task2result);
}

function checkAge(person) {
    return person.age >= 18;
}

//Task 3
function problem3(form){
    var arrayOfPersons,  arrayOfUnderaged = [];
    arrayOfPersons = start();
    arrayOfUnderaged = arrayOfPersons.filter(filterKids);
    arrayOfUnderaged.forEach(function(person, index) {
        console.log(person.fName +' '+ person.lName+ ' at index ' + index + ' in the array has age:' + person.age);
    });
}

function filterKids(person){
    return person.age<18;
}

//Task 4
function problem4(form){
    var arrayOfPersons,  arrayOfWomen = [],sum,averageAge;;
    arrayOfPersons = start();
    sum =0;
    arrayOfWomen = arrayOfPersons.filter(filterWomen);
    arrayOfWomen.forEach(function(person, index) {
        console.log(person.fName +' '+ person.lName+ ' at index ' + index + ' in the array has age:' + person.age);
        sum = sum + person.age*1;
    });
    averageAge = sum/arrayOfWomen.length;
    console.log('The average age of all women in the array is '+ averageAge)
}

function filterWomen(person){
    return person.gender === true;
}

//Task 5
function problem5(form){
        var arrayOfPersons, youngest;
    arrayOfPersons = start();
    youngest = arrayOfPersons[0];
    if (!Array.prototype.find){
        Array.prototype.find = function(callback){
            var i,
                len;
            for (i = 0, len = this.length;i < len;i+=1){
                if(callback(this[i],i,this)){
                    return this[i];
                }
            }
            return undefined;
        };
    }
    var youngest =
        arrayOfPersons.sort(function(a, b) {
            return a.age - b.age;
        }).find(function(person) {
            return !person.gender;
        });
    console.log(youngest.fName +' '+ youngest.lName+ ' is the youngest male person in the array ');
}

//task 6
function problem6(form) {
    var arrayOfPersons, result = {},dictionary={},letters = [];
    arrayOfPersons = start();
    //result[arrayOfPersons[0].fName[0]] = [];
    //result[arrayOfPersons[0].fName[0]].push(arrayOfPersons[0]);
    result = arrayOfPersons.reduce(function(dictionary,person) {
        if (!dictionary.hasOwnProperty(person.fName[0])) {
            dictionary[person.fName[0]] = [];
            letters.push(person.fName[0]);
        }
        dictionary[person.fName[0]].push(person);
        return dictionary;
    });
    console.log(result);
}


