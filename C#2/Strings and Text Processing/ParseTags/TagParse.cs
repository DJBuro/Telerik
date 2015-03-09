//Problem 5. Parse tags
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

using System;
using System.Text;
class TagParse
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string[] separators = new string[] { "<upcase>", "</upcase>" };
        string[] splitString = input.Split(separators, StringSplitOptions.None);
        string reminder;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < splitString.Length; i++)
        {
            if (i % 2 == 0)
            {
                result.Append(splitString[i]);
            }
            else
            {
                reminder = splitString[i].ToUpper();
                result.Append(reminder);
            }
        }

        Console.WriteLine(result.ToString());
    }
}