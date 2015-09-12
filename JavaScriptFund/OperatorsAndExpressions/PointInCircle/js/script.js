taskName = "Point in Circle";

function Main(bufferElement) {

    var x = 0;
    var y = 1;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = -5;
    var y = 0;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = -4;
    var y = 5;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = 1.5;
    var y = -3;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = -4;
    var y = -3.5;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = 100;
    var y = -30;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = 0;
    var y = 0;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = 0.2;
    var y = -0.8;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = 0.9;
    var y = -4.93;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')

    var x = 2;
    var y = 2.655;
    var r = 5;
    WriteLine((x * x) + (y * y) <= (r * r) ? 'true' : 'false')
}