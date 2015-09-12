/**
 * Created by Buro on 10.6.2015 ã..
 */
function ivo(main) {

    function name(str) {
        var reminderStart = str.indexOf('"');
        var reminderEnd = str.indexOf('"', reminderStart + 1);
        for (var k = reminderStart + 1; k < reminderEnd; k += 1) {
            reminder += str[k];
        }
        return reminder;
    }

    function tagM(str) {
        var x = str.indexOf('<nk-model>'),
            y = str.indexOf('</nk-model>');
        reminder = '';
        for (k = x + 10; k <= y; k += 1) {
            if (!!(str[k] != '<')) {
                reminder += str[k];
            } else {
                for (var key = 0; key < keyValues.length; key += 1) {
                    if (keyValues[key][0] === reminder) {
                        result.push(text[i].replace('<nk-model>' + reminder + '</nk-model>', keyValues[key][1]));
                        return;
                    }
                }
                break;
            }
        }
        result.push(text[i]);
    }

    var args = main.split('\n'),
        lenKey = +args.shift(),
        keyValues = [],
        lenInput,
        text,
        reminder = '',
        reminder2,
        templates = [],
        result = [];

    for (var i = 0; i < lenKey; i += 1) {
        keyValues[i] = args.shift().split('-');
    }

    lenInput = +args.shift();
    text = args;

    for (i = 0; i < lenInput * 1; i += 1) {
        for (var j = 0; j < text[i].length; j += 1) {
            if (text[i][j] === '<') {
                if (text[i][j + 1] === 'n') {
                    switch (text[i][j + 4]) {
                        case 't':
                            if (text[i][j + 13] === 'n') {
                                reminder = '';
                                reminder = name(text[i]);
                                templates.push(reminder);
                                i += 1;
                                reminder = [];
                                while (text[i] !== '</nk-template>') {
                                    reminder.push(text[i]);
                                    i += 1;
                                }
                                templates.push(reminder);
                                if (text[i].trim() === '</nk-template>') {
                                    break;
                                }
                            } else {
                                reminder = '';
                                reminder = name(text[i]);
                                for (var k = 0; k <= templates.length - 1; k += 2) {
                                    if (templates[k] === reminder) {
                                        result = result.concat(templates[k + 1]);
                                        break;
                                    }
                                }
                            }
                            break;
                        case 'i':
                            reminder = '';
                            reminder = name(text[i]);
                            for (k = 0; k < keyValues.length; k += 1) {
                                if (keyValues[k][0] === reminder) {
                                    if (keyValues[k][1] === 'false') {
                                        while (text[i].trim() !== '</nk-if>') {
                                            i += 1;
                                        }
                                        i += 1;
                                        break;
                                    } else {
                                        break;
                                    }
                                }
                            }
                            break;
                        case 'r':
                            reminder = '';
                            reminder2 = [];
                            reminder = name(text[i]);
                            reminder2 = reminder.split(' ');
                            for (k = 0; k < keyValues.length; k += 1) {
                                if (reminder2[reminder2.length - 1] === keyValues[k][0]) {
                                    reminder = [];
                                    reminder = keyValues[k][1].split(';');
                                    for (var p = 0; p < reminder.length; p += 1) {
                                        for (var q = i + 1; q <= lenInput * 1; q += 1) {
                                            text[q].trim();
                                            for (var l = 0; l <= text[q].length - 1; l += 1) {
                                                if (text[q][l] === '<') {
                                                    if (text[q][l + 4] === 'm') {
                                                        if (text[q].trim() === '<nk-model>' + reminder2[0] + '</nk-model>') {
                                                            result.push(reminder[p]);
                                                            break;
                                                        }
                                                    } else if (!(text[i].indexOf('<nk-model>'))) {
                                                        tagM(text[q]);
                                                    }
                                                    result.push(text[q]);
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                    }
                    break;
                } else {
                    if (text[i].indexOf('<nk-model>')) {
                        tagM(text[i]);
                    } else {
                        result.push(text[i]);
                        break;
                    }

                }
                break;
            }

        }
    }
}

var input = '6\ntitle-Telerik Academy\nshowSubtitle-true\nsubTitle-Free training\nshowMarks-false\nmarks-3;4;5;6\nstudents-Ivan;Gosho;Pesho\n42\n<nk-template name="menu">\n    <ul id="menu">\n    <li>Home</li>\n    <li>About us</li>\n</ul>\n</nk-template>\n<nk-template name="footer">\n    <footer>\n    Copyright Telerik Academy 2014\n</footer>\n</nk-template>\n<!DOCTYPE html>\n<html>\n<head>\n<title>Telerik Academy</title>\n</head>\n<body>\n<nk-template render="menu" />\n    <h1><nk-model>title</nk-model></h1>\n<nk-if condition="showSubtitle">\n    <h2><nk-model>subTitle</nk-model></h2>\n<div>{{<nk-model>subTitle</nk-model>}} ;)</div>\n</nk-if>\n<ul>\n    <nk-repeat for="student in students">\n        <li>\n        <nk-model>student</nk-model>\n        </li>\n        <li>Multiline <nk-model>title</nk-model></li>\n    </nk-repeat>\n    </ul>\n    <nk-if condition="showMarks">\n        <div>\n        <nk-model>marks</nk-model>\n        </div>\n        bul.“Alexander Malinov“ ¹33., Sofia, 1729, Bulgaria\n    academy.telerik.com\n    Telerik Software Academy 2014 7 of 7 facebook.com/TelerikAcademy\n    </nk-if>\n<nk-template render="footer" />\n        </body>\n        </html>';
console.log(ivo(input));