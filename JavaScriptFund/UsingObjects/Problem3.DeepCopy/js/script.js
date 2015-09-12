taskName = "Problem3.DeepCopy";

function Main(bufferElement) {

    function createDeepCopy(obj) {
        if (obj === null || typeof obj !== 'object') {
            return obj;
        }

        var copy = obj.constructor();
        for (var prop in obj) {
            copy[prop] = createDeepCopy(obj[prop]);
        }

        return copy;
    }

    var person = {
        firstName: 'Pesho',
        lastName: 'Peshov',
        marks: {
            C1: 6,
            C2: 6,
            COOP: 5,
            HTML: 4,
            CSS: 6
            }
        },
        copy = createDeepCopy(person);

    person.marks.COOP = 4;

    WriteLine('Person COOP: ' + person.marks.COOP);
    WriteLine('Copy COOP' + copy.marks.COOP);
}