taskName = "Problem6.";

function Main(bufferElement) {

    function group(array, property) {
        var i,
            len = array.length,
            prop,
            result = {};

        if (property === 'firstname') {
            for (i = 0; i < len; i += 1) {
                if (result[array[i].firstname]) {
                    result[array[i].firstname].push(array[i]);
                } else {
                    result[array[i].firstname] = [array[i]];
                }
            }
            return result;
        }
        if (property === 'lastname') {
            for (i = 0; i < len; i += 1) {
                if (result[array[i].lastname]) {
                    result[array[i].lastname].push(array[i]);
                } else {
                    result[array[i].lastname] = [array[i]];
                }
            }
            return result;
        }
        if (property === 'age') {
            for (i = 0; i < len; i += 1) {
                if (result[array[i].age]) {
                    result[array[i].age].push(array[i]);
                } else {
                    result[array[i].age] = [array[i]];
                }
            }
            return result;
        }
    }

    function print(arr) {
        for (var item in arr) {
            Write(item + ' ')
        }
    }

    var people = [
        { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
        { firstname : 'Bay', lastname: 'Ivan', age: 64},
        { firstname : 'Pesho', lastname: 'Peshov', age: 66 }],
        groupByFirstName = group(people, 'firstname'),
        groupByLastName = group(people, 'lastname'),
        groupByAge = group(people, 'age');

    WriteLine('groupByFirstName');
    print(groupByFirstName);
    WriteLine();
    WriteLine('groupByLastName');
    print(groupByLastName);
    WriteLine();
    WriteLine('groupByAge');
    print(groupByAge);
}