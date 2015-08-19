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
	var Course = {
		init: function(title, presentations) {
			this.title = title;
			this.collectionOfPresentations = presentations;
			this.collectionOfStudents = [];
			this.idCounter = 1;
			return this;
		},
		get title(){
			return this._title;
		},
		set title(value){
			validateTitle(value);
			this._title = value;
		},
		get idCounter(){
			return this._idCounter;
		},
		set idCounter(value){
			this._idCounter = value;
		},
		get collectionOfPresentations(){
			return this._collectionOfPresentations;
		},
		set collectionOfPresentations(collection){
			if (collection.length === 0){
				throw new Error;
			}
			for (var i = 0; i < collection.length; i +=1){
				validateTitle(collection[i]);
			}
			this._collectionOfPresentations = collection;
		},
		addStudent: function(name) {
			var names = name.split(' '),
				student = {},
				currentId = this.idCounter;
			this.idCounter = this.idCounter + 1;
			validateNames(names);
			student = {firstname: names[0], lastname: names[1], id: currentId};
			this.collectionOfStudents.push(student);
			return student.id;

		},
		getAllStudents: function() {
			var collectionOfStrings =[], student;
			for (var i=0; i<this.collectionOfStudents.length; i+=1){
				student = this.collectionOfStudents[i];
				collectionOfStrings.push(student);
			}
			return collectionOfStrings;
		},
		submitHomework: function(studentID, homeworkID) {
			var parsedID =  parseInt(studentID);
			var parsedHomeworkID =  parseInt(homeworkID);
			validateStudentID(studentID, parsedID, this.collectionOfStudents);
			validateHomeworkID(homeworkID,parsedHomeworkID, this.collectionOfPresentations);
		},
		pushExamResults: function(results) {
		},
		getTopStudents: function() {
		}
	}

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


//	var jsoop = Object.create(Course);
//	jsoop.init('Zzz', ['Prezentaciq']);
//	jsoop.addStudent('Aaaa Bbbbb');
//	jsoop.addStudent('Ccc Ddd');
//	jsoop.addStudent('Eee Fff');
//	console.log(jsoop.getAllStudents());



//	var jsoop = Object.create(Course)
//		.init('oop', 'prez1');
//
//	var student = {
//		firstname: 'Aa',
//		lastname: 'Bb'
//	};
//	console.log(jsoop);
//	console.log(student);
//	student.id = jsoop.addStudent(student.firstname + ' ' + student.lastname);
//
//	if (checkStudentList([student], jsoop.getAllStudents())===true){
//
//}
//
//
//function checkStudentList(list1, list2) {
//	if(list1.length !== list2.length)
//		return false;
//
//	function compare(a, b) {
//		return a.id < b.id;
//	}
//
//	list1.sort(compare);
//	list2.sort(compare);
//
//	for(var i in list1) {
//		if(list1[i].id !== list2[i].id)
//			return false;
//		if(list1[i].firstname !== list2[i].firstname)
//			return false;
//		if(list1[i].lastname !== list2[i].lastname)
//			return false;
//	}
//	return true;
//}




