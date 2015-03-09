//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Prefixtest
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
        List<string> list = new List<string>();
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt", true);
        using (writer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string line = Regex.Replace(list[i], @"w\w+", "");
                writer.WriteLine(line);
            }
        }
    }
}
