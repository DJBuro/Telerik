taskName = "Problem7.FirstLargerThanNeighbours";

function Main(bufferElement) {

    var input = [1, 2, 3, 4, 1, 2, 2, 2, 3, 4, 4, 2, 3, 4];

    WriteLine(input);
    firstLargerThanNeighbours(input);

    function firstLargerThanNeighbours(arr) {
        for (var pos = 0; pos <= arr.length - 1; pos += 1) {
            if (pos == 0) {
                if (arr[pos] > arr[pos + 1]) {
                    WriteLine('0');
                    break;
                }
            }
            else if (pos == arr.length - 1) {
                if (arr[pos] > arr[pos - 1]) {
                    WriteLine('' + pos);
                    break;
                }
                else {
                    WriteLine('There is no position larger than neighbours');
                }
            }
            else {
                if (arr[pos] > arr[pos + 1] && arr[pos] > arr[pos - 1]) {
                    WriteLine('' + pos);
                    break;
                }
            }
        }
    }
}