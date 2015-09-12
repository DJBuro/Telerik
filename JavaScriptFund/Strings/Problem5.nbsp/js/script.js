taskName = "Problem 5. nbsp";
function Main(bufferElement) {

    var text = 'We are living in an yellow submarine. We don\'t have anything else. ' +
            'Inside the submarine is very tight. So we are drinking all the day. ' +
            'We will move out of it in 5 days.',
        result;

    function replaceWhiteSpaces(text) {
        var result,
            regex;

        regex = new RegExp(' ', 'g');
        result = text.replace(regex, '&nbsp;');

        return result;
    }

    result = replaceWhiteSpaces(text);
    WriteLine(text);
    WriteLine(result);
}