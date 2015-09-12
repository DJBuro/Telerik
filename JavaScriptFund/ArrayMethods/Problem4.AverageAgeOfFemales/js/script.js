taskName = "Problem 4. Average age of females";
function Main(bufferElement) {

    var people,
        reminder,
        result = 0,

    people = makePeople(10);
    reminder = people.filter(function (item) {
        return item.gender === 'female';
    });

    reminder.forEach(function(item) {
        item.print();
        result += item.age;
    });
    result = result / reminder.length;
    WriteLine('Average age of females is ' + Math.round(result));

    function makePerson(fname, lname, age, gender) {
        return {
            firstName: fname,
            lastName: lname,
            age: age,
            gender: gender,
            print: function () {
                return WriteLine(this.firstName + ' ' + this.lastName + ' ' + this.age + ' years old ' + this.gender)
            },
            toString: function () {
                return this.firstName + ' ' + this.lastName;
            }
        };
    }

    function makePeople(lenght) {
        var i,
            people = [],
            firstNames = ['Pavel', 'Milena', 'Sandy', 'Mindi', 'Sali', 'Lenka', 'Slavei', 'Mimi', 'Stefcho', 'Ani'],
            lastNames = ['Lenkov', 'Vo', 'Rivera', 'Mindilq', 'Salov', 'Salvador', 'Peevski', 'Peneva', 'Kecov', 'Dudova'];

        for (i = 0; i < lenght; i += 1) {
            people[i] = makePerson(firstNames[i % 10], lastNames[i % 10], Math.round(Math.random()*100 + 1), ((i % 2) ? 'female' : 'male'));
        }
        return people;
    }
}