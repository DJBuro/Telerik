taskName = "Problem 2. Reverse number";

function Main(bufferElement) {

    var number = prompt('number=')
    reverseNumber(number);

    function reverseNumber(n) {
        var digits,
            result;

        digits = (""+n).split("");
        digits = digits.reverse();
        result = digits.join('');

        WriteLine(result);
    }
}