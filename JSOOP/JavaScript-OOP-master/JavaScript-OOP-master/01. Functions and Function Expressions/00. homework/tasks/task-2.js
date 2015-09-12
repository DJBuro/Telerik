/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(x, y) {
	var result = [],
		i;

	function isPrime(num) {
		var k,
			len = Math.sqrt(num),
			flag = true;
		for (k = 2; k <= len; k += 1) {
			if (!(num % k)) {
				flag = false;
			}
		}
		return flag;
	}

	if (isNaN(+x) || isNaN(+y)) {
		throw new Error('yes');
	} else if (arguments.length < 2) {
		throw new Error('yes');
	}

	for (i = x; i <= y; i += 1) {
		if (isPrime(i)) {
			result.push(i);
		}
	}
	return result;
}

module.exports = findPrimes;
