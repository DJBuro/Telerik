taskName = "Problem 2. Correct brackets";
function Main(bufferElement) {

    var test = '((a+b)/5-d)',
        result = false;

    function checkBrackets(str) {
        var counter,
            len,
            i;

        counter = 0;
        for (i = 0, len = str.length; i < len; i += 1) {
            if (str[i] === '(') {
                counter += 1;
            }
            if (str[i] === ')') {
                counter -= 1;
                if (counter < 0) {
                    return false;
                }
            }
        }

        if (counter == 0) {
            return true;
        } else {
            return false;
        }
    }

    result = checkBrackets(test);
    WriteLine(result)
}