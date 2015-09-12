taskName = "Third bit";

function Main(bufferElement) {

    var n = 5;
    var bin = n.toString(2);
    WriteLine(bin[bin.length - 4] == 1 ? '1' : '0');

    var n = 8;
    var bin = n.toString(2);
    WriteLine(bin[bin.length - 4] == 1 ? '1' : '0');

    var n = 0;
    var bin = n.toString(2);
    WriteLine(bin[bin.length - 4] == 1 ? '1' : '0');

    var n = 15;
    var bin = n.toString(2);
    WriteLine(bin[bin.length - 4] == 1 ? '1' : '0');

    var n = 5343;
    var bin = n.toString(2);
    WriteLine(bin[bin.length - 4] == 1 ? '1' : '0');

    var n = 62241;
    var bin = n.toString(2);
    WriteLine(bin[bin.length - 4] == 1 ? '1' : '0');
}