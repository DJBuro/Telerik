/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    // *********** Helper Functions **********
    function checkTitle(title) {
        if (title.length < 1) {
            throw new Error ('String is empty');
        }
        if ((title[0] === ' ') || (title[title.length - 1] === ' ')) {
            throw new Error ('Invalid title!');
        }
        if (/[\s]{2,}/.test(title)) {
            throw new Error ('Invalid title!');
        }

        return title;
    }

    function checkPresentations (presentations) {
        var len = presentations.length;
        if (len === 0) {
            throw new Error('Presentations is empty!');
        }

        for (var i = 0; i < len; i += 1) {
            checkTitle(presentations[i]);
        }

        return presentations;
    }

    function checkName(name) {
        var i,
            len = name.length;

        if (!(name[0] === name[0].toUpperCase())) {
            throw new Error ('First letter is not uppercase!')
        }

        for (i = 1; i < len; i += 1) {
            if (!(name[i] === name[i].toLowerCase())) {
                throw new Error ('Name contains too much uppercase!');
            }
            if (typeof (name[i] * 1) === 'NaN') {
                throw new Error('Name contain digit!')
            }
        }

        return name;
    }

    function checkID (ids, len) {
        if (typeof ids !== 'number') {
            throw new Error ('Homework Id is not a number!')}

        if (ids > len || ids < 1) {
            throw new Error ('Homework ID is not valid!')
        }
    }

    // *************** Solution ***************

	var Course = {
		get title() {
            return this._title;
        },
        set title (value) {
            this._title = value;
        },
        get presentations() {
            return this._presentations;
        },
        set presentations(value) {
            this._presentations = value;//
        },
        get students () {
            return this._students;
        },
        set students(value) {
            this._students = value;
        },
		init: function(title, presentations) {
            this.title = checkTitle(title);
            this.presentations = checkPresentations(presentations);
            this.students = [];
            return this;
        },
		addStudent: function(name) {
            var student = {},
                studentID,
                names = name.split(' ');

            if (!(names.length === 2)) {
                throw new Error ('Invalid Names!')
            }

            //student.firstname = checkName(names[0]);
            //student.lastname = checkName(names[1]);
            studentID = this.students.length + 1;
            //student.studentID = studentID;

            this.students.push({
                firstname: checkName(names[0]),
                lastname: checkName(names[1]),
                id: studentID
            });

            return studentID;
		},
		getAllStudents: function() {
            return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
            checkID(homeworkID, this.presentations.length);
            checkID(studentID, this.students.length);
		},
		pushExamResults: function(results) {
            var reminder,
                i,
                j,
                len;

            if (results.isArray()) {
                throw new Error ('Results are not array!')
            }

            for (i = 0, len = results.length; i < len; i += 1) {
                reminder = results[i].StudentID;
                for (j = i + 1; j < len; j += 1) {
                    if (results[j] === reminder) {
                        throw new Error ('Duplicate!');
                    }
                }
                //if (results[i].Score === 'undefined') {
                //    results[i].Score = 0;
                //}
                checkID(reminder, this.students.length)
            }
		},
		getTopStudents: function() {
		}
	};

	return Course;
}


module.exports = solve;
