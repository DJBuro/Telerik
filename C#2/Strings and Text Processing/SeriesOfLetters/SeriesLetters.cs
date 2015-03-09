//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class SeriesLetters
{
    static void Main()
    {
        //string input = "RegEx Hero is a real-time online Silverlight Regular Expression Tester.";
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        Regex regex = new Regex(@"\w"); // Find all lettes one by one
        MatchCollection words = regex.Matches(input); //Save them in collection
        List<string> result = new List<string>();
        string reminder = null;
        
        for (int i = 0; i < words.Count; i++) // Check if it is new put it in list result
        {
            string item = words[i].ToString().ToLower();
            if (item != reminder)
            {
                reminder = item;
                result.Add(item);
            }
            else
            {
                continue;
            }
        }
        
        StringBuilder sb = new StringBuilder();
        foreach (string element in result)
        {
            sb.Append(element);
        }

        Console.WriteLine(sb.ToString());
    }
}