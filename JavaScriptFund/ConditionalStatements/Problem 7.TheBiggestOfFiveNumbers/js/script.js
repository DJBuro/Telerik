taskName = "Multiplication Sign";

function Main(bufferElement) {

    var a = -5;
    var b = -13;
    var c = -1;
    var d = -1;
    var e = -13;

    if (a > b) {
        if (a > c) {
            if (a > d) {
                if (a > e) {
                    WriteLine(a);
                } else {
                    WriteLine(e)
                }
            } else {
                if (d > e) {
                    WriteLine(d);
                } else {
                    WriteLine(e);
                }
            }
        } else {
            if (c > d) {
                if (c > e) {
                    WriteLine(c);
                } else {
                    WriteLine(e);
                }
            } else {
                if (d > e) {
                    WriteLine(d);
                } else {
                    WriteLine(e);
                }
            }
        }
    } else {
        if (b > c) {
            if (b > d) {
                if (b > e) {
                    WriteLine(b);
                } else {
                    WriteLine(e);
                }
            } else {
                if (d > e) {
                    WriteLine(d);
                } else {
                    WriteLine(e);
                }
            }
        } else {
            if (c > d) {
                if (c > e) {
                    WriteLine(c);
                } else {
                    WriteLine(e);
                }
            } else {
                if (d > e) {
                    WriteLine(d);
                } else {
                    WriteLine(e);
                }
            }
        }
    }
}