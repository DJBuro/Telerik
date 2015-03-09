//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class CountLetters
{
    static void Main()
    {
        //string input = "RegEx Hero is a real-time online Silverlight Regular Expression Tester.";
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        Regex regex = new Regex(@"\w"); //Find all chars in text 
        MatchCollection chars = regex.Matches(input);
        List<string> result = new List<string>(); 
        List<int> counter = new List<int>();

        foreach (var item in chars)
        {
            string reminder = item.ToString().ToLower(); 
            if (result.Contains(reminder)) //Check if chars already been found and then only count it in second list 
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
            Console.WriteLine("{0} - {1} times", result[i], counter[i]);
        }
    }
}