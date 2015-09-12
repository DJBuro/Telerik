taskName = "Multiplication Sign";

function Main(bufferElement) {

    var a = 5;
    var b = -3;
    var c = 2;

    if (a < 0) {
        if (b < 0) {
            if (c < 0) {
                WriteLine('-')
            } else {
                WriteLine('+')
            }
        } else {
            if (c < 0) {
                WriteLine('+')
            } else {
                WriteLine('-')
            }
        }

    } else {
        if (b < 0) {
            if (c < 0) {
                WriteLine('+')
            } else {
                WriteLine('-')
            }
        } else {
            if (c < 0) {
                WriteLine('-')
            } else {
                WriteLine('+')
            }
        }
    }
}