//Problem 12. Parse URL
//
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Text.RegularExpressions;
class URLParse
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string url = Console.ReadLine();
        //string url = "http://telerikacademy.com/Courses/Courses/Details/212";

        Uri uri = new Uri(url);
        string protocol = uri.Scheme;
        string server = uri.Authority;
        string resourse = uri.PathAndQuery;

        Console.WriteLine(@"[protocol] = {0}
[server] = {1}
[resourse] = {2}", protocol, server, resourse);
    }
}