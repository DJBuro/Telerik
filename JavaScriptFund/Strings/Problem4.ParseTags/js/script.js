taskName = "Problem 4. Parse tags";
function Main(bufferElement) {

    var text = '\We are \<mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.',
        print;

    function parseTags (str) {
        var result = '',
            len,
            i;

        for (i = 0, len = str.length; i < len; i += 1) {
            if (text[i] == '<' && text[i + 1] == 'u') {
                i += 8;
                while (text[i] != '<' ) {
                    result += text[i].toUpperCase();
                    i += 1;
                }
                if(text[i + 1] == '/') {
                    i += 8;
                }
                else {
                    i--;
                }
            }
            else if(text[i] == '<' && text[i + 1] == 'm'){
                i += 9;
                while (text[i] != '<'){
                    if(Math.random() < 0.5){
                        result += text[i].toUpperCase();
                        i += 1;
                    }
                    else{
                        result += text[i].toLowerCase();
                        i += 1;
                    }
                }
                if(text[i + 1] == '/') {
                    i += 9;
                }else {
                    i--;
                }
            }
            else if (text[i] == '<' && text[i + 1] == 'l') {
                i += 9;
                while (text[i] != '<') {
                    result += text[i].toLowerCase();
                    i += 1;
                }
                if(text[i + 1] == '/'){
                    i += 9;
                } else {
                    i--;
                }
            }

            else {
                result += text[i];
            }
        }
        return result;
    }

    print = parseTags(text);
    WriteLine(print)
}