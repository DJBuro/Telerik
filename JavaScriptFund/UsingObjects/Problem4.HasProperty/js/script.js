taskName = "Problem4.HasProperty";

function Main(bufferElement) {

    function isProperty(obj, prop) {
        if (prop in obj) {
            return true;
        }
        else {
            return false;
        }
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
        };

    WriteLine('firstName? -' + isProperty(person, 'firstName'));
    WriteLine('lastName? -' + isProperty(person, 'lastName'));
    WriteLine('fullName? -' + isProperty(person, 'fullName'));
}