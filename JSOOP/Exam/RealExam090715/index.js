function solve() {
    var module = (function () {
        function compareProperties(itemToCompare, itemInArray) {
            for (var p in itemToCompare) {
                if (itemToCompare.hasOwnProperty('_' + p) !== itemInArray.hasOwnProperty(p)) {
                    return false;
                }
                else if (itemToCompare[p] !== itemInArray[p]) {
                    return false;
                }
            }
            return true;
        }

        var validator = {
            generateNameIfNone: function (name) {
                name = name || 'Value';
                return name;
            },
            ifUndefined: function (val, name) {
                name = validator.generateNameIfNone(name);
                if (typeof val === 'undefined') {
                    throw new Error(name + 'cannot be undefined!');
                }
            },
            ifObject: function (val, name) {
                name = validator.generateNameIfNone(name);
                if (typeof val !== 'object') {
                    throw new Error(name + 'is not an object');
                }
            },
            ifString: function (val, name) {
                name = validator.generateNameIfNone(name);
                if (typeof val !== 'string') {
                    throw new Error(name + 'is not string!');
                }
            },
            ifNumber: function (val, name) {
                name = validator.generateNameIfNone(name);
                if (typeof  val !== 'number') {
                    throw new Error(name + 'is not a number!');
                }
            },
            stringLenght: function (val, min, max, name) {
                name = validator.generateNameIfNone(name);
                validator.ifString(val, name);
                if (val.length < min || val.length > max) {
                    throw new Error(name + 'is invalid string lenght!')
                }
            }
        };

        var item,
            book,
            media,
            catalog,
            mediaCatalog,
            bookCatalog;

        item = (function () {
            var currentID = 0,
                item = Object.create({});

            Object.defineProperty(item, 'init', {
                value: function (description, name) {
                    this.name = name;
                    this.description = description;
                    this._id = ++currentID;
                    return this;
                }
            });

            Object.defineProperty(item, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(item, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.ifUndefined(val, 'Item name ');
                    validator.stringLenght(val, 2, 40, 'Item name ');
                    this._name = val;
                }
            });

            Object.defineProperty(item, 'description', {
                get: function () {
                    return this._description;
                },
                set: function (val) {
                    validator.ifUndefined(val, 'Item description ');
                    validator.ifString(val, 'Item description ');
                    if (val === '') {
                        throw new Error('Item description is empry string!')
                    }
                    this._description = val;
                }
            });

            return item;
        }());

        book = (function (parent) {
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function (name, isbn, genre, description) {
                    parent.init.call(this, description, name);
                    this.isbn = isbn;
                    this.genre = genre;
                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function () {
                    return this._isbn;
                },
                set: function (val) {
                    validator.ifUndefined(val, 'Book isbn ');
                    validator.stringLenght(val, 10, 13, 'Book isbn ');
                    if (!(/^\d+$/.test(val))) {
                        throw new Error('isbn contains invalid symbols!')
                    }
                    this._isbn = val;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function () {
                    return this._genre;
                },
                set: function (val) {
                    validator.ifUndefined(val, 'Book genre ');
                    validator.stringLenght(val, 2, 20, 'Book isbn ');
                    this._genre = val;
                }
            });

            return book;
        }(item));

        media = (function (parent) {
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function (name, rating, duration, description) {
                    parent.init.call(this, description, name);
                    this.duration = duration;
                    this.rating = rating;
                    return this;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function () {
                    return this._duration;
                },
                set: function (val) {
                    validator.ifUndefined(val, 'Media duration ');
                    validator.ifNumber(val, 'Media duration ');
                    if (val <= 0) {
                        throw new Error('duration is less than 0!')
                    }
                    this._duration = val;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function () {
                    return this._rating;
                },
                set: function (val) {
                    validator.ifUndefined(val, 'Media rating ');
                    validator.ifNumber(val, 'Media rating ');
                    if (val < 1 || val > 5) {
                        throw new Error('Media rating is not in range!')
                    }
                    this._rating = val;
                }
            });

            return media;
        }(item));

        catalog = (function () {
            var currentCatalogID = 0,
                catalog = Object.create({});

            Object.defineProperty(catalog, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentCatalogID;
                    this._items = [];
                    return this;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(catalog, 'items', {
                get: function () {
                    return this._items;
                }
            });

            Object.defineProperty(catalog, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.stringLenght(val, 2, 40, 'Item name ');
                    this._name = val;
                }
            });

            Object.defineProperty(catalog, 'add', {
                value: function (itemAddToCatalog) {
                    function checkArgsIfItems(arrayForAdd) {
                        for (i = 0; i < arrayForAdd.length; i += 1) {
                            if (!(itemAddToCatalog instanceof item)) {
                                throw new Error('Catalog add cannot accept not item objects!')
                            }
                        }
                    }

                    var i,
                        len = arguments.length;

                    if (len === 0) {
                        throw new Error('Zero args in add method!')
                    }

                    if (Array.isArray(itemAddToCatalog)) {
                        checkArgsIfItems(itemAddToCatalog);
                        this.items.concat(itemAddToCatalog);
                    } else if (typeof itemAddToCatalog === 'object') {
                        checkArgsIfItems(arguments);
                        for (i = 0; i < len; i += 1) {
                            this.items.push(arguments[0]);
                        }
                    }

                    return this;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function (findItem) {
                    var resultFind = [],
                        i,
                        len;

                    if (typeof (findItem) === 'number') {
                        for (i = 0, len = this.items.length; i < len; i += 1) {
                            if (findItem === this.items[i].id) {
                                return resultFind = this.items[i];
                            }
                            return resultFind = null;
                        }
                    }

                    if (typeof (findItem) === 'object') {
                        if (typeof findItem.id !== 'undefined' && typeof findItem.name !== 'undefined') {
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (compareProperties(findItem, this.items[i])) {
                                    resultFind.push(this.items[i]);
                                }
                            }
                        } else if (typeof findItem.id !== 'undefined') {
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (compareProperties(findItem, this.items[i])) {
                                    resultFind.push(this.items[i]);
                                }
                            }
                        } else if (typeof findItem.name !== 'undefined') {
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (compareProperties(findItem, this.items[i])) {
                                    resultFind.push(this.items[i]);
                                }
                            }
                        } else {
                            throw new Error('Find method in catalog dont work!')
                        }
                        return resultFind;
                    }
                    throw new Error('Ebem li go!');
                }
            });
            // moje da kuca!
            Object.defineProperty(catalog, 'search', {
                value: function (pattern) {
                    var resultSearchArray = [],
                        i,
                        len,
                        regex;

                    validator.ifUndefined(pattern, 'Patern ');
                    validator.stringLenght(pattern, 1, 40, 'Patern ');

                    for (i = 0, len = this.items.length; i < len; i += 1) {
                        pattern = pattern.toLowerCase();
                        regex = this.items[i].name.toLowerCase();
                        regex = regex.match(pattern);
                        if (Array.isArray(regex)) {
                            if (regex.length) {
                                resultSearchArray.push(this.items[i]);
                                continue;
                            }
                        }
                        regex = this.items[i].description.toLowerCase();
                        regex = regex.match(pattern);
                        if (Array.isArray(regex)) {
                            if (regex.length) {
                                resultSearchArray.push(this.items[i]);
                            }
                        }
                    }
                    return resultSearchArray;
                }
            });

            return catalog;
        }());

        bookCatalog = (function (parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);
                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function (bookToAddInCatalog) {
                    function checkArgsIfItems(arrayForAdd) {
                        for (i = 0; i < arrayForAdd.length; i += 1) {
                            if (arrayForAdd.prototype !== book.prototype) {
                                throw new Error('Catalog add cannot accept not item objects!')
                            }
                        }
                    }

                    var i,
                        len = arguments.length;

                    validator.ifUndefined(bookToAddInCatalog);
                    if (len === 0) {
                        throw new Error('Zero args in add method!')
                    }

                    if (Array.isArray(bookToAddInCatalog)) {
                        checkArgsIfItems(bookToAddInCatalog);
                        for (i = 0, len = bookToAddInCatalog.length; i < len; i += 1) {
                            this.items.push(bookToAddInCatalog[i]);
                        }
                    } else if (typeof bookToAddInCatalog === 'object') {
                        checkArgsIfItems(arguments);
                        for (i = 0, len = arguments.length; i < len; i += 1) {
                            this.items.push(arguments[i]);
                        }
                    }
                    return this;
                }
            });
            //TODO
            Object.defineProperty(bookCatalog, 'getGenres', {
                value: function () {
                    var genres = [],
                        i,
                        j,
                        rem,
                        len;

                    for (i = 0, len = this.items.length; i < len; i += 1) {
                        if (genres.length === 0) {
                            rem = this.items[i].genre.toLowerCase();
                            genres.push(rem);
                        }

                        for (j = 0; j < genres.length; j += 1) {
                            rem = this.items[i].genre.toLowerCase();
                            if (rem === genres[j]) {
                                break;
                            }
                            genres.push(rem);
                        }
                    }
                }
            });
            
            Object.defineProperty(bookCatalog, 'find', {
                value: function (pattern) {
                    var resultFromFind = [],
                        i,
                        len;


                    validator.ifUndefined(pattern, 'Pattern ');
                    if (typeof pattern === 'number') {
                        return parent.find.call(this, pattern);
                    }
                    if (typeof pattern === 'object') {
                        if (typeof pattern.genre !== 'undefined') {
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (compareProperties(pattern, this.items[i])) {
                                    resultFromFind.push(this.items[i]);
                                }
                            }
                        }
                        resultFromFind = parent.find.call(this, pattern);
                    }
                    return resultFromFind;
                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function (parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);
                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'add', {
                value: function (itemToAdd) {
                    function checkArgsIfItems(arrayForAdd) {
                        for (i = 0; i < arrayForAdd.length; i += 1) {
                            if (arrayForAdd.prototype !== media.prototype) {
                                throw new Error('Catalog add cannot accept not item objects!')
                            }
                        }
                    }

                    var i,
                        len = arguments.length;

                    validator.ifUndefined(itemToAdd);
                    if (len === 0) {
                        throw new Error('Zero args in add method!')
                    }

                    if (Array.isArray(itemToAdd)) {
                        checkArgsIfItems(itemToAdd);
                        this.items.concat(itemToAdd);
                    } else if (typeof itemToAdd === 'object') {
                        checkArgsIfItems(arguments);
                        for (i = 0; i < len; i += 1) {
                            this.items.push(arguments[i]);
                        }
                    }
                    return this;
                }
            });
            //TODO
            return mediaCatalog;
        }(catalog));

        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book).init(name, isbn, genre, description);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media).init(name, rating, duration, description);
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog).init(name);
            }
        }
    }());

    return module;
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
var kkkkk = [book1, book2];
catalog.add(kkkkk);
//catalog.add();

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

//console.log(catalog.search('JS'));
// returns book2

//console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'));