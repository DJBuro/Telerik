taskName = "Problem6.";

function Main(bufferElement) {

    function findOldest(people) {
        var reminder = 0,
            oldest,
            i;

        for (i = 0; i <= people.length - 1; i += 1) {
            if (people[i].age > reminder) {
                oldest = people[i];
            }
        }

        return oldest;
    }

    var people = [
        { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
        { firstname : 'Bay', lastname: 'Ivan', age: 64},
        { firstname : 'Pesho', lastname: 'Peshov', age: 66 }],
        oldest = findOldest(people);

    WriteLine('Oldest is ' + oldest.firstname + ' ' + oldest.lastname);
}