taskName = "Divisible by 7 and 5";

function Main(bufferElement) {

    var n = 3;
    WriteLine(n % 5 === 0 && n % 7 === 0 ? n + ' true' : n + ' false');

    var n = 0;
    WriteLine(n % 5 === 0 && n % 7 === 0 ? n + ' true' : n + ' false');

    var n = 5;
    WriteLine(n % 5 === 0 && n % 7 === 0 ? n + ' true' : n + ' false');

    var n = 7;
    WriteLine(n % 5 === 0 && n % 7 === 0 ? n + ' true' : n + ' false');

    var n = 35;
    WriteLine(n % 5 === 0 && n % 7 === 0 ? n + ' true' : n + ' false');

    var n = 140;
    WriteLine(n % 5 === 0 && n % 7 === 0 ? n + ' true' : n + ' false');
}