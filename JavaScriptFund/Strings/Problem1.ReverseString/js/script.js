taskName = "Problem 1. Reverse string";
function Main(bufferElement) {

    var test = 'sample',
        result;

    function reverseString (str) {
        var reminder = str.split('');
        reminder.reverse();
        return reminder.join('');
    }

    result = reverseString(test);
    WriteLine(result)
}