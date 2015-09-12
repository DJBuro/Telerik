taskName = "Point in Circle";

function Main(bufferElement) {

    var n = 1;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 2;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n) ; i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 3;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n) ; i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 4;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n) ; i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 9;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n) ; i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 37;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 97;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 51;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = -3;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)

    var n = 0;
    var isPrime = true;
    if (n < 2) { isPrime = false }
    if (n != Math.round(n)) { isPrime = false }
    for (var i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) { isPrime = false }
    }
    WriteLine(n + ' ' + isPrime)
}