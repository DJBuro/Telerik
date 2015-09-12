taskName = "PointInCircleAndOutsideRectangle";

function Main(bufferElement) {

    var x = 1;
    var y = 4;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle){
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }


    var x = 3;
    var y = 2;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = 0;
    var y = 1;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = 4;
    var y = 1;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = 2;
    var y = 0;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = 4;
    var y = 0;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = 2.5;
    var y = 1.5;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = 3.5;
    var y = 1.5;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }

    var x = -100;
    var y = -100;
    var isInCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3;
    var isOutofRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
    if (isInCircle && !isOutofRectangle) {
        WriteLine('yes')
    }
    else {
        WriteLine('no')
    }
}