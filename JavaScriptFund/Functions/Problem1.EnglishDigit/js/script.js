taskName = "Problem 1. English digit";

function Main(bufferElement) {

    var number = prompt('number=')
    getLastDigit(number);

    function getLastDigit(number) {
        result = number % 10;

        switch (result) {
            case 0: WriteLine('Zero'); break;
            case 1: WriteLine('One'); break;
            case 2: WriteLine('Two'); break;
            case 3: WriteLine('Three'); break;
            case 4: WriteLine('Four'); break;
            case 5: WriteLine('Five'); break;
            case 6: WriteLine('Six'); break;
            case 7: WriteLine('Seven'); break;
            case 8: WriteLine('Eight'); break;
            case 9: WriteLine('Nine'); break;
        }
    }
}