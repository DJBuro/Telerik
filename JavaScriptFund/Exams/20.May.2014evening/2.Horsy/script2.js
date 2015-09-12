/**
 * Created by Buro on 10.6.2015 ã..
 */
function sol(args) {
    var rowsCols = args.shift().split(' '),
        rowsAll = +rowsCols[0],
        colsAll = +rowsCols[1],
        matrix = [],
        moves = [],
        row = rowsAll - 1,
        col = colsAll - 1,
        sum = 0,
        jump = 0;

    for (var i = 0; i < rowsAll; i += 1) {
        moves[i] = args[i].split('');
        matrix[i] = [];
        for (var j = 0; j < colsAll; j += 1) {
            matrix[i][j] = Math.pow(2, i) - j;
        }
    }

    while(1) {
        if (row < 0 || row >= rowsAll || col < 0 || col >= colsAll) {
            return 'Go go Horsy! Collected ' + sum + ' weeds';
        }

        if (matrix[row][col] === 'used') {
            return 'Sadly the horse is doomed in ' + jump + ' jumps';
        }

        sum += matrix[row][col];
        jump += 1;
        matrix[row][col] = 'used';
        moves[row][col] *= 1;
        switch (moves[row][col]) {
            case 1:
                row -= 2;
                col += 1;
                break;
            case 2:
                row -= 1;
                col += 2;
                break;
            case 3:
                row += 1;
                col += 2;
                break;
            case 4:
                row += 2;
                col += 1;
                break;
            case 5:
                row += 2;
                col -= 1;
                break;
            case 6:
                row += 1;
                col -= 2;
                break;
            case 7:
                row -= 1;
                col -= 2;
                break;
            case 8:
                row -= 2;
                col -= 1;
                break;
        }
    }

}

var input = [
    '3 5',
    '54361',
    '43326',
    '52188'
];
console.log(sol(input));