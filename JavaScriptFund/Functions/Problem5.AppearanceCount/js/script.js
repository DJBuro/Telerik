taskName = "Problem5.AppearanceCount";

function Main(bufferElement) {

    var input = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5];

    test();

    function test() {
        var test1 = count(1, input),
            test2 = count(2, input),
            test3 = count(3, input),
            test4 = count(4, input),
            test5 = count(5, input),
            result1 = 1,
            result2 = 2,
            result3 = 3,
            result4 = 4,
            result5 = 5;

        WriteLine('Input: ' + input);

        if (test1 === result1) {
            WriteLine('1 --> Once');
            if (test2 === result2) {
                WriteLine('2 --> Twice');
                if (test3 === result3) {
                    WriteLine('3 --> Thrice');
                    if (test4 === result4) {
                        WriteLine('4 --> 4times');
                        if (test5 === result5) {
                            WriteLine('5 --> 5times')
                            WriteLine('All test passed!')
                        }
                    }
                }
            }
        }
    }

    function count(number, array) {
        var counter = 0;
        for (var i in array) {
            if (array[i] == number) {
                counter++;
            }
        }
        return counter;
    }
}