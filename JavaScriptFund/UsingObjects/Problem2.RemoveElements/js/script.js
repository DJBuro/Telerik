taskName = "Problem2.RemoveElements";

function Main(bufferElement) {

    Array.prototype.remove = function(value) {
        while (this.indexOf(value) >= 0) {
            this.splice(this.indexOf(value), 1);
        }
        return this;
    };

    var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'],
        result;

    WriteLine('Input  - ' + arr);
    result = arr.remove(1);
    WriteLine('Result - ' + result);
}