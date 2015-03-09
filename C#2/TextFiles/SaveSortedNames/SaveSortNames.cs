//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
class SaveSortNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\Names.txt");
        List<string> listOfNames = new List<string>();

        using (reader)
        {
            string line = "";
            while((line = reader.ReadLine()) != null)
            {
                listOfNames.Add(line);
            }
        }

        listOfNames.Sort();
        StreamWriter writer = new StreamWriter(@"..\..\Files\SortedNames.txt", true);

        using (writer)
        {
            for (int i = 0; i < listOfNames.Count; i++)
            {
                writer.WriteLine(listOfNames[i]);
            }
        }
        Console.WriteLine("Job Done");
    }
}
