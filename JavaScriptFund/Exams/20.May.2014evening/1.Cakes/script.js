/**
 * Created by Buro on 10.6.2015 ã..
 */
function solve(params) {
    var s = +params[0],
        c1 = +params[1],
        c2 = +params[2],
        c3 = +params[3],
        sum = 0,
        answer = 0;

    for (var i = 0; i < s; i += 1) {
        for (var j = 0; j < s; j += 1) {
            for (var k = 0; k < s; k += 1) {
                sum = i * c3 + j * c2 + k * c1;
                if (sum > s) {
                    break;
                }
                else if (sum === s) {
                    answer = sum;
                    return answer;
                }
                else {
                    if (sum > answer) {
                        answer = sum;
                    }
                }
            }
        }
    }

    console.log(answer);
}

var input = ['110', '19', '29', '39'];
solve(input);
