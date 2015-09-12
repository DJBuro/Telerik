taskName = "Odd or Even";

function Main(bufferElement) {

    var n = 3;
    WriteLine(n % 2 === 0 ? n + ' is even' : n + ' is odd');

    var n = 2;
    WriteLine(n % 2 === 0 ? n + ' is even' : n + ' is odd');

    var n = -2;
    WriteLine(n % 2 === 0 ? n + ' is even' : n + ' is odd');

    var n = -1;
    WriteLine(n % 2 === 0 ? n + ' is even' : n + ' is odd');

    var n = 1;
    WriteLine(n % 2 === 0 ? n + ' is even' : n + ' is odd');
}