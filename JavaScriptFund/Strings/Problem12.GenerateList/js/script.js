taskName = "Problem 12. Generate list";
function Main(bufferElement) {

    var template = '<strong>-{name}-</strong> <span>-{age}-</span>',
        people = [{name: 'Peter', age: 14},
        {name: 'Ivan', age: 16},
        {name: 'Stojan', age: 18}],
        peopleList;

    function generateList(item, templ){
        var result = '',
            i;
        result +='<ul>';
        for(i = 0; i<item.length; i+=1){
            result +='<li>';
            result += replaceTemplate(item[i],templ);
            result +='</li>';
        }
        result +='</ul>';
        return result;
    }

    function replaceTemplate(it,templ){
        var newString = '';
        newString = templ.replace('-{name}-', it.name);
        newString = newString.replace('-{age}-', it.age);
        return newString;
    }

    peopleList = generateList(people, template);
    WriteLine(peopleList);
}