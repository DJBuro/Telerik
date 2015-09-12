taskName = "Problem3.OccurrencesOfWord";

function Main(bufferElement) {

    var text,
        word,
        sensitive = false;

    text = 'hello hello hello this is a list of different words that it is';
    word = 'Hello';

    WriteLine(countWords(text, word, sensitive));

    function countWords(text, word, sensitive) {
        var caseSens = sensitive || false;
        var newStr = text.replace(/\W+/g, ' ');
        var words = newStr.split(' ');
        var occurrences = 0;

        if (caseSens) {
            for (var i = 0; i < words.length; i++) {
                if (words[i] === word) {
                    occurrences++;
                }
            }
        }
        else {
            var lowerCase = word.toLowerCase();

            for (var j = 0; j < words.length; j++) {
                if (words[j].toLowerCase() == lowerCase) {
                    occurrences++;
                }
            }
        }

        return occurrences;
    }
}