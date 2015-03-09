//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;
class DeleteLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\PeshoGosho.txt");
        List<string> list = new List<string>();
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\Files\PeshoGosho.txt", false);
        using (writer)
        {
            for (int i = 0; i < list.Count; i = i +2)
            {
                writer.WriteLine(list[i]);
            }
        }
    }
}