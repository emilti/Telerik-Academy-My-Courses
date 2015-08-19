/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

//function a() {
	//return
	function findPrimes(bottom, top) {
		var i, j, topSqrt, arrayOfPrimes = [];
		if (findPrimes.length < 2) {
			throw  new Error;
		}
		bottom = bottom * 1;
		top = top * 1;
		if (isNaN(bottom) || isNaN(top)) {
			throw new Error;
		}

		for (i = bottom; i <= top; i += 1) {
			topSqrt = Math.sqrt(i);
			topSqrt = Math.ceil(topSqrt);
			for (j = 2; j <= topSqrt; j += 1) {
				if ((i % j) === 0 && i !== j) {
					break;
				}
				if (j === topSqrt) {
					arrayOfPrimes.push(i);
				}
			}
		}
		return arrayOfPrimes;
	}
//}


var a = '2', b ='5';
var primes = findPrimes(a,b);
console.log(primes);
//module.exports = findPrimes;
