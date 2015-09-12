taskName = "Problem 3. Sub-string in text";
function Main(bufferElement) {

    var text = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
        regex = /in/gi,
        reminder;

    reminder = text.match(regex);

    WriteLine(reminder.length)
}