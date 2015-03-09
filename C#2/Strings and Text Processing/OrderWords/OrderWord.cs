//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class OrderWord
{
    static void Main()
    {
        //string input = "RegEx Hero is a real-time online Silverlight Regular Expression Tester.";
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        Regex regex = new Regex(@"\w+"); // Get all words
        MatchCollection words = regex.Matches(input); // Save them in collection 
        List<string> result = new List<string>(); 

        foreach (var item in words) // Check for duplicate
        {
            string reminder = item.ToString().ToLower();
            if (result.Contains(reminder))
            {
                continue;
            }
            else
            {
                result.Add(reminder);
            }
        }

        result.Sort();  
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine("{0}", result[i]);
        }
    }
}
