/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/



module.exports = sum;


function a() {
	return function (array) {
		array = array.map(function (e) {
			var a = parseInt(e);
			if (isNaN(a)) {
				throw new Error;
			}
			return a;
		})
		if (array.length === 0) {
			return null;
		}


		var sum = array.reduce(function (a, b) {
			return a + b;
		});
		return sum;
	}
}


