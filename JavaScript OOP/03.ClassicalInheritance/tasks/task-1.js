/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		function Person(fname, lname, age ) {
			var that  = this;
			Object.defineProperty(that, 'firstname', {
				get: function () {
					return this._firstname;
				},
				set: function (fname) {
					if (fname.length < 3 || fname.length > 20) {
						throw new Error('Name is invalid');
					}
					this._firstname = fname;
					return this;
				},
				configurable: true
			});
			Object.defineProperty(that, 'lastname', {
				get: function () {
					return this._lastname;
				},
				set: function (lname) {
					if (lname.length < 3 || lname.length > 20) {
						throw new Error('Last Name is invalid');
					}
					this._lastname = lname;
					return this;
				},
				configurable: true
			});
			Object.defineProperty(that, 'age', {
				get: function () {
					return this._age;
				},
				set: function (age) {
					if (age < 0 || age > 150) {
						throw new Error('Age is invalid');
					}
					this._age = age;
					return this;
				},
				configurable: true
			});
			Object.defineProperty(that, 'fullname', {
				get: function () {
					return this._fullname;
				},
				set: function (fullname) {
					var names = fullname.split(' ');
					if (names[0].length < 3 || names[0].length > 20 ||
						names[1].length < 3 || names[1].length > 20) {
						throw new Error('Last Name is invalid');
					}
					this._fullname = fullname;
					this._firstname = names[0];
					this._lastname = names[1];
					return this;
				},
				configurable: true
			});

			that.firstname = fname;
			that.lastname = lname;
			that.age = age;
			that.fullname = this.firstname + ' ' + this.lastname;
			return that;
		}
		Person.prototype.introduce = function () {
			return 'Hello! My name is '+this.fullname+' and I am ' + this.age+'-years-old';
		};


		return Person;
	} ());

	

	return Person;
}


module.exports = solve;

//var p = new Person('aaaaa', 'bbbbb', 27);
//console.log(p.firstname +' '+ p.lastname + ' '+p.age)
