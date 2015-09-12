taskName = "Problem 6. Extract text from HTML";
function Main(bufferElement) {

    var input = '<html>\
        <head>\
        <title>Sample site</title>\
        </head>\
        <body>\
        <div>text\
            <div>more text</div>\
            and more...\
        </div>\
        in body\
        </body>\
        </html>';

    function extractText(str) {
        var len = str.length,
            result = '',
            i;

        for (i = 0; i < len; i += 1) {
            if (str[i] === '<') {
                i = str.indexOf('>', i);
            }
            if (str[i] !== '>') {
                result += str[i];
            }
        }

        return result;
    }
    console.log(extractText(input));
    WriteLine(extractText(input));

}