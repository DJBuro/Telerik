taskName = "Problem 7. Parse URL";
function Main(bufferElement) {

    var input = 'http://telerikacademy.com/Courses/Courses/Details/239',
        print,
        protocol,
        server;

    function parseURL(str) {
        var result = [],
            counter = 0,
            len = str.length,
            i;

        for (i = 0; i < len; i += 1) {
            if (str[i] === ':') {
                counter += 1;
                i += 3;
            }
            if (str[i] === '/') {
                counter += 1;
            }
            if (result[counter] === undefined) {
                result[counter] = '';
            }
            result[counter] += str[i];
        }
        return result;
    }

    print = parseURL(input);
    protocol = print.shift();
    server = print.shift();
    WriteLine('{ protocol: ' + protocol);
    WriteLine(' server: ' + server);
    WriteLine(' resource: ' + print.join(''));
}