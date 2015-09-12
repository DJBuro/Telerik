taskName = "Multiplication Sign";

function Main(bufferElement) {

    var a = 5;
    var b = 2;
    var c = 8;

    var firstRoot;
    var secondRoot;

    if (a) {
        firstRoot = (-b + Math.sqrt(b*b - 4*a*c)) / (2*a);
        secondRoot = (-b - Math.sqrt(b*b - 4*a*c)) / (2*a);
    } else {
        firstRoot = secondRoot = - ( c / b);
    }

    if (isNaN(firstRoot)) {
        WriteLine('Not real roots')
    } else {
        if (firstRoot === secondRoot) {
            WriteLine('x=' + firstRoot)
        } else {
            WriteLine('x1=' + firstRoot + ' x2=' + secondRoot)
        }
    }
}