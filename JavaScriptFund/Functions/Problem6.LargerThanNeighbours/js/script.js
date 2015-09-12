taskName = "Problem 6. Larger than neighbours";

function Main(bufferElement) {

    var input = [3, 2, 3, 4, 1, 2, 4, 2, 3, 1, 4, 2, 3, 2],
        pos;

    WriteLine(input);
    pos = prompt('position =');
    largerThanNeighbours(input, pos);

    function largerThanNeighbours(arr, pos) {
        pos = pos*1;
        if (pos < 0 || pos > arr.length - 1) {
            WriteLine('Invalid position!');
        }
        else if (pos == 0) {
            if (arr[pos] > arr[pos + 1]) {
                WriteLine('True');
            }
            else {
                WriteLine('False');
            }
        }
        else if (pos == arr.length - 1) {
            if (arr[pos] > arr[pos - 1]) {
                WriteLine('True');
            }
            else {
                WriteLine('False');
            }
        }
        else {
            if (arr[pos] > arr[pos + 1] && arr[pos] > arr[pos - 1]) {
                WriteLine('True');
            }
            else {
                WriteLine('False');
            }
        }
    }
}