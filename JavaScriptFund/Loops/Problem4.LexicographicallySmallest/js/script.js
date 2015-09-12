taskName = "Multiplication Sign";

function Main(bufferElement) {

        var prop,
            list = [];

        for (prop in document) {
            list.push(prop);
        }

        WriteLine('lexicographically smallest element in document object is: ' + list.sort()[0] + '\nlexicographically largest element in document object is: ' + list.sort()[list.length - 1]);

        for (prop in window) {
            list.push(prop);
        }

        WriteLine('lexicographically smallest element in window object is: ' + list.sort()[0] + '\nlexicographically largest element in window object is: ' + list.sort()[list.length - 1]);

        for (prop in navigator) {
            list.push(prop);
        }

        WriteLine('lexicographically smallest element in navigator object is: ' + list.sort()[0] + '\nlexicographically largest element in navigator object is: ' + list.sort()[list.length - 1]);
}