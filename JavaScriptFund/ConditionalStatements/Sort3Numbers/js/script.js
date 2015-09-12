taskName = "Multiplication Sign";

function Main(bufferElement) {

    var a = 1;
    var b = 1;
    var c = 1;

    if (a > b) {
        if (b > c) {
            WriteLine(a + ' ' + b + ' ' + c)
        } else {
            WriteLine(a + ' ' + c + ' ' + b)
        }
    } else {
        if (b > c) {
            if (a > c) {
                WriteLine(b + ' ' + a + ' ' + c)
            } else {
                WriteLine(b + ' ' + c + ' ' + a)
            }
        } else {
            WriteLine(c + ' ' + b + ' ' + a)
        }
    }
}