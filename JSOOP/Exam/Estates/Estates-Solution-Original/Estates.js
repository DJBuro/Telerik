function processEstatesAgencyCommands(commands) {
    var validator = {
        generateNameIfNone: function (name) {
            name = name || 'Value';
            return name;
        },
        validateIfUndefined: function (val, name) {
            name = validator.generateNameIfNone(name);
            if (typeof val === 'undefined') {
                throw new Error(name + 'cannot be undefined!');
            }
        },
        validateIfObject: function (val, name) {
            name = validator.generateNameIfNone(name);
            if (typeof val !== 'object') {
                throw new Error(name + 'is not an object');
            }
        },
        validateIfString: function (val, name) {
            name = validator.generateNameIfNone(name);
            if (typeof val !== 'string') {
                throw new Error(name + 'is not string!');
            }
        },
        validateIfNumber: function (val, name) {
            name = validator.generateNameIfNone(name);
            if (typeof  val !== 'number') {
                throw new Error(name + 'is not a number!');
            }
        },
    };

    var estateEngine = (function () {
        var estates,
            uniqueEstatesNames,
            offers;

        function init() {
            estates = [];
            uniqueEstatesNames = [];
            offers = [];
        }

        function executeCommand (cmd) {
            var resultLine,
                currentCommand,
                commandArray;

            commandArray = cmd.split(' ');
            currentCommand = cmd[0];

            return resultLine;
        }

        return {
            init: init,
            executeCommand: executeCommand
        };
    }());

    var result = '';
    estateEngine.init();
    commands.forEach(function(cmd) {
        validator.validateIfUndefined(cmd, 'CMD ');
        validator.validateIfString(cmd, 'CMD ');
        result += estateEngine.executeCommand(cmd) + '\n';
    });
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processEstatesAgencyCommands(arr));
        });
    }
})();
