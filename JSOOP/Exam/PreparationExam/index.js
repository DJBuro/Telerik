function solve() {
    'use strict';
    var module = (function () {
        function findIndexOf(id, collection) {
            var i, len;
            for (i = 0, len = collection.length; i < len; i += 1) {
                if (id === collection[i].id) {
                    return i;
                }
            }
            return -1;
        }

        function getSortingParameters(firstParameter, secondParameter) {
            return function sortByTitleThenByID(first, second) {
                if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }
                else if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                }

                if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                }
                else if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                }
                else {
                    return 0;
                }
            };
        }

        var player,
            playlist,
            playable,
            audio,
            video,
            validator,
            MIN_STRING_LENGHT = 3,
            MAX_STRING_NAME = 25,
            MIN_IMDBRATING = 1,
            MAX_IMDBRATING = 5;

        player = (function () {
            var currentID = 0;
            player = Object.create({});

            Object.defineProperty(player, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentID;
                    this._playlists = [];
                    return this;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateString(val, 'Player name');
                    this._name = val;
                }
            });

            Object.defineProperty(player, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function (playlistToAdd) {
                    validator.validateIfUndefined(playlistToAdd, 'Playlist cannot be undefined!');
                    validator.validateIfUndefined(playlistToAdd.id, 'playlist id is undefined');
                    this._playlists.push(playlistToAdd);
                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Player id ');
                    validator.validateIfNumber(id, 'Player id');
                    var index = findIndexOf(id, this._playlists);
                    if (index < 0) {
                        return null;
                    } else {
                        return this._playlists[index];
                    }
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function (id) {
                    id = validator.validateID(id, 'Playlist remove playable ');
                    var index = findIndexOf(id, this._playlists);
                    if (index < 0) {
                        throw new Error('Cannot find playlist by id!');
                    }

                    this._playlists.splice(index, 1);
                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists', {
                value: function (page, size) {
                    validator.validatePageAndSize(page, size, this._playlists.length);
                    return this._playlists.slice().sort(getSortingParameters('name', 'id')).splice(page * size, size);
                }
            });

            Object.defineProperty(player, 'contains', {
                value: function (playable, playlist) {
                    validator.validatePlayable(playable, 'Playable in contains in player ');
                    validator.validateIfUndefined(playlist, 'Playlist in player ');
                    validator.validateIfUndefined(playlist.id, 'ID Playlist in player ');
                    var index = findIndexOf(playable.id, playlist);
                    return (index < 0);
                }
            });

            Object.defineProperty(player, 'search', {
                value: function (pattern) {
                    var i,
                        j,
                        k,
                        reminder,
                        lenPlaylist = this._playlists.length,
                        lenPlayable,
                        result = [];

                    validator.validateIfUndefined(pattern, 'Pattern ');
                    validator.validateIfString(pattern, 'Pattern ');

                    for (i = 0; i < lenPlaylist; i += 1) {
                        for (j = 0, lenPlayable = this._playlists[i].length; j < lenPlayable; j += 1) {
                            reminder = this._playlists[i][j];
                            reminder = reminder.split(' ');
                            for (k = 0; k < reminder.length; k += 1) {
                                reminder[k].trim().toLowerCase();
                                if (reminder[k] === pattern.trim().toLowerCase()) {
                                    result.push(this._playlists[i]);
                                }
                            }
                        }
                    }

                    for (i = 0; i < result.length; i += 1) {
                        reminder = {};
                        reminder.name = result[i].name;
                        reminder.id = result[i].id;
                    }

                    return reminder;
                }
            });

            return player;
        }());

        playlist = (function () {
            var currentID = 0;
            playlist = Object.create({});

            Object.defineProperty(playlist, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currentID;
                    this._playables = [];
                    return this;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateString(val, 'Playlist name ');
                    this._name = val;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function (playable) {
                    validator.validatePlayable(playable, 'Playlist playable ');
                    this._playables.push(playable);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Playlist playable id ');
                    validator.validateIfNumber(id, 'Playlist playable id ');
                    var index = findIndexOf(id, this._playables);
                    if (index < 0) {
                        return null;
                    } else {
                        return this._playables[index];
                    }
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function (id) {
                    id = validator.validateID(id, 'Playlist remove playable ');
                    var index = findIndexOf(id, this._playables);
                    if (index < 0) {
                        throw new Error('Cannot find playable by id!');
                    }

                    this._playables.splice(index, 1);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function (page, size) {
                    validator.validatePageAndSize(page, size, this._playables.length);
                    return this._playables.slice().sort(getSortingParameters('title', 'id')).splice(page * size, size);
                }
            });

            return playlist;
        }());

        playable = (function () {
            var currentID = 0,
                playable = Object.create({});

            Object.defineProperty(playable, 'init', {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currentID;
                    return this;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function () {
                    return this._title;
                },
                set: function (val) {
                    validator.validateString(val, 'Playable title ');
                    this._title = val;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function () {
                    return this._author;
                },
                set: function (val) {
                    validator.validateString(val, 'Playable author ');
                    this._author = val;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'play', {
                value: function () {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            });

            return playable;
        }());

        audio = (function (parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function (title, author, lenght) {
                    parent.init.call(this, title, author);
                    this.length = lenght;
                    return this;
                }
            });

            Object.defineProperty(audio, 'lenght', {
                get: function () {
                    return this._lenght;
                },
                set: function (val) {
                    validator.validatePositiveNumber(val, 'Audio lenght ');
                    this._lenght = val;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        video = (function (parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function () {
                    return this._imdbRating;
                },
                set: function (val) {
                    validator.validateImdbRating(val, 'Video ');
                    this._imdbRating = val;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            });

            return video;
        }(playable));

        validator = {
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
            validateString: function (val, name) {
                validator.validateIfUndefined(val, name);
                validator.validateIfString(val, name);
                if (val.lenght < MIN_STRING_LENGHT || val.length > MAX_STRING_NAME) {
                    throw new Error(name + 'is not right lenght');
                }
            },
            validatePositiveNumber: function (val, name) {
                validator.validateIfUndefined(val, name);
                validator.validateIfNumber(val, name);
                if (val <= 0) {
                    throw new Error(name + 'is not positive number');
                }
            },
            validateImdbRating: function (val, name) {
                validator.validateIfUndefined(val, name);
                validator.validateIfNumber(val, name);
                if (val < MIN_IMDBRATING || val > MAX_IMDBRATING) {
                    throw new Error(name + 'is not valid imdbRating!');
                }
            },
            validatePlayable: function (val, name) {
                validator.validateIfUndefined(val, name);
                validator.validateIfObject(val, name);
                validator.validateIfUndefined(val.id, name);
            },
            validateID: function (val, name) {
                validator.validateIfUndefined(val, name);
                if (typeof val !== 'number') {
                    val = val.id;
                }
                validator.validateIfUndefined(val, name);
                return val;
            },
            validatePageAndSize: function (page, size, maxLenght) {
                validator.validateIfUndefined(page, 'Page ');
                validator.validateIfUndefined(size, 'Size ');
                validator.validateIfNumber(page, 'Page ');
                validator.validateIfNumber(size, 'Size ');
                validator.validatePositiveNumber(size, 'Size ');
                if (page < 0) {
                    throw new Error('Page cannot be negative number!');
                }
                if (page * size > maxLenght) {
                    throw new Error('Page * Size cannot be more than lenght!');
                }
            }
        };

        return {
            getPlayer: function (name) {
                return Object.create(player).init(name);
            },
            getPlaylist: function (name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function (title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function (title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return module;
}