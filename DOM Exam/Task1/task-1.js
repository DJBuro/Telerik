function solve() {
    return function (selector, isCaseSensitive) {
        isCaseSensitive = isCaseSensitive || false;
        selector = selector.match(/\w+/g);
        var newInput = document.createElement('input'),
            newButton = document.createElement('button'),
            newDiv = document.createElement('div'),
            newLabel = document.createElement('label'),
            container = document.getElementById(selector),
            result = ['gosho', 'pesho'],
            i,
            currentLI,
            len,
            fragment = document.createDocumentFragment();

        var mainDiv = newDiv.cloneNode();
        mainDiv.className = 'items-control';

        var addDiv = newDiv.cloneNode();
        var addInput = newInput.cloneNode();
        addInput.className = 'add';
        var addLabel = newLabel.cloneNode();
        addLabel.setAttribute('for', 'add');
        addLabel.innerHTML = 'Enter text: ';
        addInput.type = 'text';
        var addButton = newButton.cloneNode();
        addButton.className = 'button';
        addDiv.className = 'add-controls';

        addDiv.appendChild(addLabel);
        addDiv.appendChild(addInput);
        addDiv.appendChild(addButton);


        var searchDiv = newDiv.cloneNode();
        var searchInput = newInput.cloneNode();
        searchInput.className = 'input';
        var searchLabel = newLabel.cloneNode();
        searchLabel.innerHTML = 'Search: ';
        searchLabel.setAttribute('for', 'input');
        searchDiv.className = 'search-controls';
        searchDiv.appendChild(searchLabel);
        searchDiv.appendChild(searchInput);

        var resultDiv = newDiv.cloneNode();
        resultDiv.className = 'result-controls';
        var ul = document.createElement('ul');
        ul.className = 'items-list';

        var li = document.createElement('li');
        li.className = 'list-item';
        var resultButton = newButton.cloneNode();
        resultButton.className = 'button';
        var resultLabel = newLabel.cloneNode();
        //resultLabel.setAttribute('for', 'button');

        for (i = 0, len = result.length; i < len; i += 1) {
            resultLabel.innerHTML = result[i];
            currentLI = li.cloneNode();
            currentLI.appendChild(resultButton);
            currentLI.appendChild(resultLabel);
            fragment.appendChild(currentLI);
        }

        mainDiv.appendChild(addDiv);
        mainDiv.appendChild(searchDiv);
        ul.appendChild(fragment);
        resultDiv.appendChild(ul);
        mainDiv.appendChild(resultDiv);

        addButton.addEventListener('click', function () {
            if (addInput.value.length > 0) {
                result.push(addInput.value);
            }
        });

        searchInput.addEventListener('change', function () {

        });


        //mainDiv.appendChild(resultDiv);
        container.appendChild(mainDiv);
    };
}

var module = {};
module.exports = solve;