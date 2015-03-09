//Problem 22. Words count
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class CountWords
{
    static void Main()
    {
        //string input = "RegEx Hero is a real-time online Silverlight Regular Expression Tester.";
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        Regex regex = new Regex(@"\w+"); // Find all different words
        MatchCollection words = regex.Matches(input); 
        List<string> result = new List<string>(); // First list for words
        List<int> counter = new List<int>(); // Second list which count in the same index like word

        foreach (var item in words) 
        {
            string reminder = item.ToString().ToLower();
            if (result.Contains(reminder)) //Find if word is found before and only count it if its true
            {
                int index = result.IndexOf(reminder);
                counter[index]++;
                continue;
            }
            else
            {
                result.Add(reminder);
                counter.Add(1);
            }
        }

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine("{0, 12} - {1} times", result[i], counter[i]);
        }
    }
}