/**
 * Created by Buro on 11.6.2015 ã..
 */
function so(args) {
    var i, j, k, p,
        len = args.length,
        selectors = [],
        result = [],
        dollarOn = false,
        dollarreminder,
        dollar = [];


        for (i = 0; i < len; i += 1) {
            if(args[i].indexOf('$') > -1) {
                dollar = [];
                dollarreminder = args[i].replace('$', '').trim();
                dollarreminder = dollarreminder.replace('{', '').trim();
                dollar.push(dollarreminder + ' {');
                dollarOn = true;
                for (i = i + 1; i < len; i += 1) {
                    if (args[i].indexOf(';') > -1) {
                        dollar.push(formatProperty(args[i]));
                    } else {
                        i += 1;
                        break;
                    }
                }

            }
            if(args[i].indexOf('{') > -1) {
                if (selectors.length > 0) {
                    result.push('}')
                }
                selectors.push(args[i].trim());
                result.push(formatSelector());
            }
            if(args[i].indexOf('}') > -1) {
                if (!dollarOn) {
                    selectors.pop();
                    if (selectors.length === 0) {
                        result.push('}')
                    }
                } else {
                    result.push('}');
                    k = selectors[selectors.length - 1];
                    p = k.replace('{', '').trim();
                    selectors[selectors.length - 1] = p + dollar[0];
                    result.push(formatSelector());
                    for (j = 1; j < dollar.length; j += 1) {
                        result.push(dollar[j]);
                    }
                    selectors.pop();
                    dollarOn = false;
                }
            }
            if(args[i].indexOf(';') > -1) {
                result.push(formatProperty(args[i]));
            }
        }

    console.log(result.join('\n'));

    function formatProperty(input) {
        var reminder = input.split(':');
        return '  ' + reminder[0].trim() + ': ' + reminder[1].trim();
    }

    function formatSelector() {
        var reminder = [],
            rem;
        for (var i = 0; i < selectors.length; i += 1) {
            rem = selectors[i].replace('{', '');
            reminder.push(rem.trim());
        }
        return reminder.join(' ') + ' {';
    }
}

var test1 = [
    '.jedi {',
    'has: lightsaber;',
    '}'

]

var test = [
'#the-big-b{',
'    color: big-yellow;',
'.little-bs {',
'        color: little-yellow;',
'        $.male            {',
'            color: middle-yellow;',
'        }',
'    }',
'}',
'.muppet           {',
'    skin        :        fluffy;',
'    $.water-spirit    {',
'        powers    :     water;',
'    }',
'    powers    :      all-muppet-powers;',
'}'
];

so(test);