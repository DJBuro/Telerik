taskName = "Problem 8. Replace tags";
function Main(bufferElement) {

    var test = '\<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>',
        print;

    function replaceTags(str) {
        var len = str.length,
            i,
            tagStart = '[URL=',
            tagFin = ']',
            tagEnd = '[/URL]',
            result = '';

        for (i = 0; i < len; i += 1) {
            if (str[i] === '<') {
                if (str[i + 1] === 'a') {
                    result += tagStart;
                    i += 8;
                    for (i; i < len; i += 1) {
                        if (str[i] === '>') {
                            result += tagFin;
                            i += 1;
                            break;
                        }
                        result += str[i];
                    }
                }
                else if (str[i + 1] === '/') {
                    if (str[i + 2] === 'a') {
                        result += tagEnd;
                        i += 4;
                    }
                }
            }
            result += str[i];
        }

        return result;
    }

    print = replaceTags(test);
    WriteLine(print);
}