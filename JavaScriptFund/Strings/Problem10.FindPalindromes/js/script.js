taskName = "Problem 10. Find palindromes";
function Main(bufferElement) {

    var test = 'Write a program that extracts from a given text all palindromes "ABBA", "lamal", "exe".',
        print;

    function findPalindromes(text) {
        var i,
            result = [],
            arrOfWords = text.split(' ').map(function(item) {
                return item.replace(/[\.,-\/#!$%\^&\*;:{}=\-_`~()]/g,"");
            }),
            len = arrOfWords.length;

        for (i = 0; i < len; i += 1) {
            if (arrOfWords[i].length > 1 &&
                arrOfWords[i].toLowerCase() === reverseWord(arrOfWords[i].toLowerCase())) {
                result.push(arrOfWords[i]);
            }
        }
        return result;
    }

    function reverseWord(word) {
        return word.split('').reverse().join('');
    }

    print = findPalindromes(test);
    print.forEach(function(item) {
        WriteLine(item);
    })
}