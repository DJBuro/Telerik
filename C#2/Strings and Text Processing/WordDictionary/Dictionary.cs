//Problem 14. Word dictionary
//
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
class Dictionary
{
    static void Main()
    {
        string input = @".NET - platform for applications from Microsoft
CLR - managed execution environment for .NET
namespace - hierarchical organization of classes";
        string[] separators = new string[] { "\n", "-"};
        string[] beforeDic = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        for (int i = 0; i < beforeDic.Length; i = i + 2)
        {
            dictionary.Add(beforeDic[i].Trim(), beforeDic[i + 1].Trim());
        }

        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        string result;
        if (dictionary.ContainsKey(word)) // Returns true.
        {
            result = dictionary[word];
            Console.WriteLine(result); // This is the value at cat.
        }
        else
        {
            Console.WriteLine("Dictionary doesn't contains this word");
        }
    }
}