taskName = "Exchange if greater";

function Main(bufferElement) {

    var a = 5;
    var b = 2;
    if (a > b) {
        WriteLine(a + ' ' + b)
    } else {
        WriteLine(b + ' ' + a)
    }

    var a = 3;
    var b = 4;
    if (a > b) {
        WriteLine(a + ' ' + b)
    } else {
        WriteLine(b + ' ' + a)
    }

    var a = 5.5;
    var b = 4.5;
    if (a > b) {
        WriteLine(a + ' ' + b)
    } else {
        WriteLine(b + ' ' + a)
    }
}