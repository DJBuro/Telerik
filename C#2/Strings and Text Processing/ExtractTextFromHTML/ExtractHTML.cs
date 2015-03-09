//Problem 25. Extract text from HTML
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ExtractHTML
{
    static Regex htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);
    static void Main()
    {
        string input = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik Academy
    </a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>";

        string titlePattern = @"<title>.*?<\/title>"; // Find title
        Regex titleRegex = new Regex(titlePattern); 
        string title = titleRegex.Match(input).ToString(); // Copy title
        input = Regex.Replace(input, titlePattern, " ");

        input = Regex.Replace(input, @"<.*?>|[\n\r]", "").Trim(); // Replace all HTML tags
        title = Regex.Replace(title, @"<.*?>", " ").Trim();
        input = Regex.Replace(input, @"\s+", " ").Trim(); // Replace inside tabs and big whitespaces with space
        

        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Text: {0}", input);

    }
}
