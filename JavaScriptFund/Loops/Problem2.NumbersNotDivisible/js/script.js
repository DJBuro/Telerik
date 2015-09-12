taskName = "Multiplication Sign";

function Main(bufferElement) {

    var n = prompt('number = '),
        i;

    for (i = 1; i <=n; i += 1) {
        if (i % 3) {
            if (i % 7) {
                WriteLine(i);
            }
        }
    }
}