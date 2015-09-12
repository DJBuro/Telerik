/**
 * Created by Buro on 11.6.2015 ã..
 */
function solve(input) {
    var i = 0,
        j = 1,
        k,
        count,
        args = input[0].split(' '),
        len = args.length,
        result = [],
        print = 0;

    for (k = 0; k < args.length; k += 1) {
        args[k] = args[k] * 1;
        result[k] = 0;
    }

    while (i <= len - 2) {
        count = 0;
        while (args[i] > args[j]) {
            count += 1;
            i += 1;
            j += 1;
        }
        result[i] += count;
        count = 0;
        var remI = i;
        while (args[i] < args[j]) {
            result[remI] += 1;
            count = 0;
            i += 1;
            j += 1;
        }
    }

    for (k = 0; k < len; k += 1) {
        if (result[k] > print) {
            print = result[k];
        }
    }

    console.log(print);
}



var test = ['10', '1', '2', '3', '4', '5', '4', '3', '2', '1', '10'];
    reminder = ['5 1 7 4 8', '5 1 7 6 3 6 4 2 3 8', '10 1 2 3 4 5 4 3 2 1 10'];

solve(test);