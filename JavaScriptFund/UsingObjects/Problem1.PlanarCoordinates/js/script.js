taskName = "Problem1.PlanarCoordinates";

function Main(bufferElement) {

    function makePoint(x, y) {
        var point = {
            xCoord: x,
            yCoord: y
        };
        return point;
    }

    function makeLine(point1, point2) {
        var reminder = Math.sqrt((point2.xCoord - point1.xCoord)*(point2.xCoord - point1.xCoord) + (point2.yCoord - point1.yCoord)*(point2.yCoord - point1.yCoord))
        var line = {
            lenght: reminder
        };
        return line;
    }

    function checkTriangle(line1, line2, line3) {
        var isTriangle = false;
        if (line1.lenght + line2.lenght > line3.lenght){
            if (line2.lenght + line3.lenght > line1.lenght) {
                if (line3.lenght + line1.lenght > line2.lenght){
                    isTriangle = true;
                }
            }
        }
        return isTriangle;
    }

    var x1 = prompt('x1='),
        y1 = prompt('y1='),
        point1 = makePoint(x1, y1),
        x2 = prompt('x2='),
        y2 = prompt('y2='),
        point2 = makePoint(x2, y2),
        x3 = prompt('x3='),
        y3 = prompt('y3='),
        point3 = makePoint(x3, y3),
        line1 = makeLine(point1, point2),
        line2 = makeLine(point2, point3),
        line3 = makeLine(point3, point1);

    WriteLine('Point 1: (' + point1.xCoord + ', ' + point1.yCoord + ')');
    WriteLine('Point 2: (' + point2.xCoord + ', ' + point2.yCoord + ')');
    WriteLine('Point 3: (' + point3.xCoord + ', ' + point3.yCoord + ')');
    WriteLine('Line 1: Lenght=' + line1.lenght);
    WriteLine('Line 2: Lenght=' + line2.lenght);
    WriteLine('Line 3: Lenght=' + line3.lenght);
    WriteLine('Is it Triangle: ' + checkTriangle(line1, line2, line3));
}