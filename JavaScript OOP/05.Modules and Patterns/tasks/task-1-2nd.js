/* Task Description */
/*
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var Student = (function(){
        var Student = {};
        Object.defineProperties(Student,{
            init:{
                value: function(name, id){
                    this.name = name;
                    this.id = id;
                    this._collectionOfHomeworks =[];
                    this.Score = null;
                    this.finalScore = null;
                    return this;
                }
            },
            name:{
                set: function(name) {
                    var names = name.split(' ');
                    validateNames(names);
                    this._firstName = names[0];
                    this._lastName = names[1];
                }
            },
            firstname:{
                get: function(){
                    return this._firstName
                }
            },
            lastname:{
                get: function(){
                    return this._lastName
                }
            },
            id:{
                get: function(){
                    return this._id
                },
                set: function(value){
                    this._id = value;
                }
            },
            collectionOfHomeworks:{
                get: function(){
                    return this._collectionOfHomeworks;
                }
            },
            addHomework:{
                value: function(homework){
                    if (this._collectionOfHomeworks.indexOf(homework)> -1){
                        throw new Error('Homework already added');
                    }
                    this._collectionOfHomeworks.push(homework);
                }
            },
            addExamResult:{
                value: function(studentId, result){
                    if (this.Score!== null){
                        throw new Error('Exam result already added');
                    }
                    if (isNaN(result)){
                        throw new Error;
                    }
                    this.Score = result;
                }
            },
            Score:{
                get: function(){
                    return this._Score
                },
                set:function(value){
                    this._Score = value;
                }
            },
            finalScore:{
                get: function(){
                    return this._finalScore
                },
                set:function(value){
                    this._finalScore = value;
                }
            }

        })
        return Student;
    }())


    var Course = (function() {
        var Course = {};
        Object.defineProperties(Course, {
            init: {
                value: function (title, presentations) {
                    this.title = title;
                    this.collectionOfPresentations = presentations;
                    this.collectionOfStudents = [];
                    this.idCounter = 0;
                    return this;
                }
            },
            title: {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    validateTitle(value);
                    this._title = value;
                }
            },
            idCounter: {
                get: function () {
                    return this._idCounter;
                },
                set: function (value) {
                    this._idCounter = value;
                }
            },
            collectionOfPresentations: {
                get: function () {
                    return this._collectionOfPresentations;
                },
                set: function (collection) {
                    if (collection.length === 0) {
                        throw new Error;
                    }
                    for (var i = 0; i < collection.length; i += 1) {
                        validateTitle(collection[i]);
                    }
                    this._collectionOfPresentations = collection;
                }
            },
            addStudent: {
                value: function (name) {
                    currentId = this.idCounter;
                    this.idCounter = this.idCounter + 1;
                    var student = Object.create(Student).init(name, this.idCounter);
                    //student = {firstname: names[0], lastname: names[1], id: currentId};
                    this.collectionOfStudents.push(student);
                    return student.id;
                }
            },
            getAllStudents: {
                value: function () {
                    //var collectionOfStrings = [], student;
                    //for (var i = 0; i < this.collectionOfStudents.length; i += 1) {
                    //    student = this.collectionOfStudents[i];
                    //    collectionOfStrings.push(student);
                    //}
                    return this.collectionOfStudents;
                }
            },
            submitHomework: {
                value: function (studentID, homeworkID) {
                    var parsedID = parseInt(studentID),
                        parsedHomeworkID = parseInt(homeworkID),
                        currentStudent = {};
                    validateStudentID(studentID, parsedID, this.collectionOfStudents);
                    validateHomeworkID(homeworkID, parsedHomeworkID, this.collectionOfPresentations);
                    currentStudent = this.collectionOfStudents.filter(function filterById(st){
                        if (st.id === parsedID) {
                            return st;
                        }
                    });
                    currentStudent[0].addHomework(homeworkID);

                }
            },
            pushExamResults: {
                value: function (results) {
                    if (Array.isArray(results) === false){
                        throw new Error;
                    }
                    for (var i= 0, resultsLen = results.length; i < resultsLen; i+=1) {
                        var currentStudent, parsedID;
                            if (results[i].hasOwnProperty('StudentID') === false ){
                            throw new Error;
                        }

                        parsedID = parseInt(results[i].StudentID);
                        validateStudentID(results[i].StudentID, parsedID, this.collectionOfStudents);
                        currentStudent = this.collectionOfStudents.filter(function filterById(st) {
                            if (st.id === parsedID) {
                                return st;
                            }
                        });

                        if (results[i].hasOwnProperty('Score') === false){
                            throw new Error;
                        }

                        currentStudent[0].addExamResult(parsedID, results[i].Score);
                    }

                    for (var j = 0, len = this.collectionOfStudents.length; j < len; j+=1){
                        if (this.collectionOfStudents[j].Score === null){
                            this.collectionOfStudents[j].Score = 0;
                        }
                    }
                }
            },
            getTopStudents: {
                value: function () {
                    var topTen;
                    for (var st = 0, len = this.collectionOfStudents.length; st < len; st+=1){
                        this.collectionOfStudents[st].finalScore = (this.collectionOfStudents[st].Score/6)*(75 / 100) +
                        (this.collectionOfStudents[st]._collectionOfHomeworks.length / this.collectionOfPresentations.length)* (25 / 100);
                        console.log(this.collectionOfStudents[st].finalScore);
                    }
                    this.collectionOfStudents.sort(function (a, b) {
                        if (a.finalScore < b.finalScore) {
                            return 1;
                        }
                    });
                    topTen = this.collectionOfStudents.slice(0, 10);
                    return topTen;
                }
            }
        })
        return Course;
    }());

    function validateStudentID(studentID, parsedID, collection) {
        var filteredById;
        if (studentID !== parsedID) {
            throw new Error;
        }

        filteredById = collection.filter(function (student) {
            return student.id === parsedID;
        });
        if (filteredById.length !== 1) {
            throw  new Error;
        }
    }

    function validateHomeworkID(homeworkID,parsedHomeworkID, collectionOfPresentations ){
        var filteredById, presentation;
        if (homeworkID !== parsedHomeworkID) {
            throw new Error;
        }

        presentation = collectionOfPresentations[parsedHomeworkID -1];
        if (presentation === undefined) {
            throw  new Error;
        }
    };

    function validateTitle(title){
        if (title.indexOf('  ') > -1 ||!title || title[0] === ' ' || title[title.length - 1] === ' '){
            throw new Error;
        }
    };

    function validateNames(names){
        var re = new RegExp("[A-Z]{1}[a-z]*");
        if (names.length >2){
            throw new Error;
        }
        var validFirstName = names[0].match(re);
        var validLastName = names[1].match(re);
        if (validFirstName === null || validLastName === null){
            throw  new Error;
        }
    }

    return Course;
}
module.exports = solve;
//    var c = Object.create(Course);
//    c.init('JS-OOP', [
//        'Functions declarions, expressions and IIFEs',
//        'Closures and Scope',
//        'Classical Inheritance in JavaScript',
//        'Prototype-based inheritance',
//        'JavaScript Patterns',
//        'Creating and Using Exceptions',
//        'Object and Object.prototype methods',
//        'ECMAScript 6 classes & inheritance'
//    ]);
//    c.addStudent('Gosho Ivanov');
//    c.addStudent('Pesho Petrov');
//    c.addStudent('Tosho Marinov');
//    c.addStudent('Marin Zaplesa');
//    c.addStudent('Prostak Todorov');
//    c.addStudent('Traktorista Manolov');
//    c.addStudent('Dancho Prostaka');
//    c.addStudent('Muncho Tarikata');
//    c.addStudent('Petarcho Bastuna');
//    c.addStudent('Bastun Angelov');
//
//    c.submitHomework(1, 1);
//    c.submitHomework(1, 3);
//    c.submitHomework(1, 4);
//    c.submitHomework(1, 5);
//    c.submitHomework(1, 6);
//    c.submitHomework(1, 7);
//    c.submitHomework(1, 8);
//
//    c.submitHomework(2, 1);
//    c.submitHomework(2, 2);
//    c.submitHomework(2, 4);
//    c.submitHomework(2, 5);
//    c.submitHomework(2, 7);
//    c.submitHomework(2, 8);
//
//    c.submitHomework(3, 1);
//    c.submitHomework(3, 2);
//    c.submitHomework(3, 3);
//    c.submitHomework(3, 4);
//    c.submitHomework(3, 5);
//    c.submitHomework(3, 7);
//    c.submitHomework(3, 8);
//
//    c.submitHomework(4, 1);
//    c.submitHomework(4, 2);
//    c.submitHomework(4, 4);
//    c.submitHomework(4, 6);
//
//    c.submitHomework(5, 1);
//    c.submitHomework(5, 2);
//    c.submitHomework(5, 3);
//
//    c.submitHomework(6, 1);
//    c.submitHomework(6, 4);
//
//    c.submitHomework(7, 4);
//
//    c.submitHomework(8, 1);
//    c.submitHomework(8, 2);
//    c.submitHomework(8, 3);
//    c.submitHomework(8, 5);
//    c.submitHomework(8, 7);
//    c.submitHomework(8, 8);
//
//    c.submitHomework(9, 1);
//    c.submitHomework(9, 2);
//    c.submitHomework(9, 3);
//    c.submitHomework(9, 4);
//    c.submitHomework(9, 5);
//    c.submitHomework(9, 6);
//    c.submitHomework(9, 7);
//    c.submitHomework(9, 8);
//
//    c.submitHomework(10, 1);
//    c.submitHomework(10, 2);
//    c.submitHomework(10, 4);
//    c.submitHomework(10, 8);
//
//    c.pushExamResults([
//        {
//            StudentID: 5,
//            Score: 3
//        },{
//            StudentID: 1,
//            Score: 5.25
//        },{
//            StudentID: 2,
//            Score: 5
//        },{
//            StudentID: 7,
//            Score: 2.50
//        },{
//            StudentID: 10,
//            Score: 3
//        },{
//            StudentID: 4,
//            Score: 3.75
//        },{
//            StudentID: 9,
//            Score: 5.80
//        },{
//            StudentID: 3,
//            Score: 6
//        },{
//            StudentID: 6,
//            Score: 3.25
//        }
//    ]);
//    console.log(c.getTopStudents());
//
//   var jsoop = Object.create(Course)
//       .init('aa', ['Prez1', 'Prez2']);
//    jsoop.addStudent('Aaa Bbb');
//    jsoop.addStudent('Ccc Ddd');
//    jsoop.addStudent('Eee Fff');
//    jsoop.submitHomework(2,1);
//    jsoop.submitHomework(1,1);
//    jsoop.submitHomework(1,2);
//    jsoop.submitHomework(3,1);
//
//
//   jsoop.pushExamResults([{StudentID:1,score:3},{StudentID:2, score:5}]);
//   console.log(jsoop.getTopStudents());









