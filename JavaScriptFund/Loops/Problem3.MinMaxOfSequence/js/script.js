taskName = "Multiplication Sign";

function Main(bufferElement) {

    var numbers = [],
        number,
        min = Number.MAX_VALUE,
        max = Number.MIN_VALUE;

    while (number = prompt('Enter number (Enter to exit)')) {
        numbers.push(parseInt(number));
    }

    for (number in numbers) {
        if (numbers[number] >= max) {
            max = numbers[number];
        }

        if (numbers[number] <= min) {
            min = numbers[number];
        }
    }

    WriteLine('min=' + min + ' max=' + max)
}