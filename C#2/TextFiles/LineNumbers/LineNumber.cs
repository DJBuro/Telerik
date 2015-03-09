//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
class LineNumber
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\PeshoGosho.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Files\LineNumbers.txt", true);
        int counter = 1;
        string line = "";

        using (writer)
        {
            using (reader)
            {
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        writer.WriteLine("Line {0} - {1}", counter, line);
                        counter++;
                    }
                }
            }
        }
    }
}