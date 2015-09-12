/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
	var s = 0,
        n = numbers.length,
        i,
        rem;


    if (numbers.length === 0) {
        return null;
    } else {
        for (i = 0; i < n; i += 1) {
            rem = +numbers[i];
            if (isNaN(rem)) {
                throw new Error;
            }
            s += rem;
        }

        return s;
    }
}

module.exports = sum;