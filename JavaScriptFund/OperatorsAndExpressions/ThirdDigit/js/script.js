taskName = "Third digit";

function Main(bufferElement) {

    var n = 5;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");

    var n = 701;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");

    var n = 1732;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");

    var n = 9703;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");

    var n = 877;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");

    var n = 777877;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");

    var n = 9999799;
    var result = n + '';
    var reminder = result.length;
    WriteLine(result[reminder - 3] == 7 ? "true" : "false");
}