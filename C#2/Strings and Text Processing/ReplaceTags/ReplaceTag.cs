//Problem 15. Replace tags
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text.RegularExpressions;
class ReplaceTag
{
    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string result = Regex.Replace(input, "<a href=\"", "[URL=");
        result = Regex.Replace(result, "</a>", "[/URL]");
        result = Regex.Replace(result, "\">", "]");
        Console.WriteLine(result);
    }
}