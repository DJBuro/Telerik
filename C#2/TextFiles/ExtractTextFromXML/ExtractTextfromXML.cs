//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text.RegularExpressions;
class ExtractTextfromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\XML.txt");
        string reminder;
        using (reader)
        {
            reminder = reader.ReadToEnd();
        }

        Regex reg = new Regex(@"<.*?>");
        reminder = reg.Replace(reminder, " ");
        Regex whitespaces = new Regex(@"\s+");
        reminder = whitespaces.Replace(reminder, " ");

        Console.WriteLine(reminder);
        StreamWriter writer = new StreamWriter(@"..\..\Files\Text.txt", false);
        using (writer)
        {
            writer.WriteLine(reminder);
        }
    }
}