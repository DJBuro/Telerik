﻿taskName = "Problem 3. Underage people";
function Main(bufferElement) {

    var people,
        result;

    people = makePeople(10);
    result = people.filter(function (item) {
        return item.age >= 18;
    });

    result.forEach(function(item) {
        item.print();
    });

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