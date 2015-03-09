//Problem 18. Extract e-mails
//
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text;
using System.Text.RegularExpressions;
class ExtractEmail
{
    static void Main()
    {
        string input = "We have some random emails: a939020011@yahoo.com, barrister_victor.otu68@yahoo.com, bella1271@live.com, a.c.department@hotmail.co.za";
        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        MatchCollection emailMatches = emailRegex.Matches(input);

        StringBuilder sb = new StringBuilder();

        foreach (Match emailMatch in emailMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }
        Console.WriteLine(sb.ToString());
    }
}