taskName = "Problem 9. Extract e-mails";
function Main(bufferElement) {

    var test = 'An email address such as John.Smith@example.com is made up of a local part, an @ symbol, then a domain part. The domain part is ',
        result;

    function extractEmails(text) {
        var i,
            len,
            arr = text.split(' '),
            possibleEmails = [],
            validEmails = [];
        for (i = 0, len = arr.length; i < len; i += 1) {
            if ((arr[i].indexOf('@') > 0) &&
                (arr[i].indexOf('@') < (arr[i].length - 1)) &&
                (arr[i].indexOf('@')) == arr[i].lastIndexOf('@')) {
                possibleEmails.push(arr[i]);
            }
        }
        for (i = 0, len = possibleEmails.length; i < len; i += 1) {
            if ((possibleEmails[i].indexOf('.', possibleEmails[i].indexOf('@')) >
                (possibleEmails[i].indexOf('@') + 1)) &&
                (possibleEmails[i].lastIndexOf('.') <
                (possibleEmails[i].length - 1))) {
                validEmails.push(possibleEmails[i]);
            }
        }
        return [possibleEmails.join(', '), validEmails.join(', ')];
    }

    result = extractEmails(test);
    WriteLine(result[0]);
    WriteLine();
    WriteLine(result[1]);
}