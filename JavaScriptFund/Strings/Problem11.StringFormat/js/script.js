taskName = "Problem 1. Reverse string";
function Main(bufferElement) {

    function stringFormat(str){
        var selfArguments = arguments;
        outputStr = selfArguments[0];
        if (selfArguments.length > 1) {
            for (var i = 1; i < selfArguments.length; i += 1)  {
                for (var j = 0; j < outputStr.length; j+=1) {
                    outputStr = outputStr.replace('{' + (i - 1) + '}', selfArguments[i]);
                }
            }
        }
        return outputStr;
    }

    var input1 = stringFormat('Hello {0}!', 'Peter');
    WriteLine(input1);

    var frmt = '{0}, {1}, {0} text {2}';
    var input2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');
    WriteLine(input2);
}