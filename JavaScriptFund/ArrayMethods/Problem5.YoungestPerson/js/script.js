taskName = "Problem 5. Youngest person";
function Main(bufferElement) {

    if (!Array.prototype.find) {
        Array.prototype.find = function (callback) {
            var i, len = this.length;
            for (i = 0; i < len; i += 1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        };
    }

    var people,
        sortedPeople,
        youngest;

    people = makePeople(10);
    sortedPeople = people.sort( function (x, y) {
        return x.age - y.age;
    });

    youngest = sortedPeople.find(function (item) {
        if (item.gender === 'male') {
            return item
        }
    });

    WriteLine(youngest.toString());

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
                return this.firstName + ' ' + this.lastName + ' ' + this.age;
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