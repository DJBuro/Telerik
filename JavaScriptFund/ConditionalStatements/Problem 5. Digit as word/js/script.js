taskName = "Multiplication Sign";

function Main(bufferElement) {

    var digit = '21';
    WriteLine(digit);
    digit = +digit;
    switch (false) {
        case (!isNaN(digit)): console.log('Not a Digit'); WriteLine('Not a Digit');break;
        case !(digit === 0): console.log('Zero'); WriteLine('Zero');break;
        case !(digit === 1): console.log('One'); WriteLine('One');break;
        case !(digit === 2): console.log('Two'); WriteLine('Two');break;
        case !(digit === 3): console.log('Three'); WriteLine('Three');break;
        case !(digit === 4): console.log('Four'); WriteLine('Four');break;
        case !(digit === 5): console.log('Five'); WriteLine('Five');break;
        case !(digit === 6): console.log('Six'); WriteLine('Six');break;
        case !(digit === 7): console.log('Seven'); WriteLine('Seven');break;
        case !(digit === 8): console.log('Eight'); WriteLine('Eight');break;
        case !(digit === 9): console.log('Nine'); WriteLine('Nine');break;
        default : WriteLine('Not a Digit');break;
    }
}